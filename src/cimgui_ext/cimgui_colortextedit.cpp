// MIT License - Copyright (c) Callum McGing
// This file is subject to the terms and conditions defined in
// LICENSE, which is part of this source code package

#include "cimgui_ext.h"
#include "imgui.h"
#include "TextEditor.h"
#include <string>
#include <cstring>

const TextEditor::LanguageDefinition& Ini()
{
	static bool inited = false;
	static TextEditor::LanguageDefinition langDef;
	if (!inited)
	{		
		langDef.mKeywords.clear();
		langDef.mIdentifiers.clear();
		
		//langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("($|@)?\\\"(\\\\.|[^\\\"])*\\\"", TextEditor::PaletteIndex::String));
		langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)([eE][+-]?[0-9]+)?[fF]?", TextEditor::PaletteIndex::Number));
		//langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("[+-]?[0-9]+[Uu]?[lL]?[lL]?", TextEditor::PaletteIndex::Number));
		//langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("0[0-7]+[Uu]?[lL]?[lL]?", TextEditor::PaletteIndex::Number));
		//langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("0[xX][0-9a-fA-F]+[uU]?[lL]?[lL]?", TextEditor::PaletteIndex::Number));
		langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("[a-zA-Z_][a-zA-Z0-9_]*", TextEditor::PaletteIndex::Identifier));
		langDef.mTokenRegexStrings.push_back(std::make_pair<std::string, TextEditor::PaletteIndex>("[\\[\\]\\=]", TextEditor::PaletteIndex::Punctuation));

		//langDef.mCommentStart = "/*";
		//langDef.mCommentEnd = "*/";
		langDef.mSingleLineComment = ";";

		langDef.mCaseSensitive = true;
		//langDef.mAutoIndentation = true;

		langDef.mName = "Ini";

		inited = true;
	}
	return langDef;
}


IGEXPORT texteditor_t igExtTextEditorInit()
{
	TextEditor *editor = new TextEditor();
    editor->SetShowWhitespaces(false);
	editor->SetColorizerEnable(false);
	return (texteditor_t)editor;
}

IGEXPORT void igExtTextEditorSetMode(texteditor_t textedit, texteditor_mode_t mode)
{
    TextEditor *editor = (TextEditor*)textedit;
    if(mode == TEXTEDITOR_MODE_LUA) {
        editor->SetLanguageDefinition(TextEditor::LanguageDefinition::Lua());
        editor->SetColorizerEnable(true);
    }
	else if (mode == TEXTEDITOR_MODE_INI) {
        editor->SetLanguageDefinition(Ini());
        editor->SetColorizerEnable(true);		
	}
    else {
        editor->SetColorizerEnable(false);
    }
}
IGEXPORT void igExtTextEditorSetReadOnly(texteditor_t textedit, int readonly)
{
    TextEditor *editor = (TextEditor*)textedit;
    editor->SetReadOnly(readonly != 0 ? true : false);
}

IGEXPORT const char *igExtTextEditorGetText(texteditor_t textedit)
{
	TextEditor *editor = (TextEditor*)textedit;
	return strdup(editor->GetText().c_str());
}

IGEXPORT void igExtFree(void *mem)
{
	free(mem);
}

IGEXPORT void igExtTextEditorSetText(texteditor_t textedit, const char *text)
{
	TextEditor *editor = (TextEditor*)textedit;
	editor->SetText(text);
}

IGEXPORT int igExtTextEditorIsTextChanged(texteditor_t textedit)
{
	TextEditor *editor = (TextEditor*)textedit;
	return editor->IsTextChanged() ? 1 : 0;
}

IGEXPORT void igExtTextEditorGetCoordinates(texteditor_t textedit, int32_t *x, int32_t *y)
{
	TextEditor *editor = (TextEditor*)textedit;
	auto cpos = editor->GetCursorPosition();
	*x = (int32_t)cpos.mColumn;
	*y = (int32_t)cpos.mLine;
}

IGEXPORT void igExtTextEditorRender(texteditor_t textedit, const char *id)
{
	TextEditor *editor = (TextEditor*)textedit;
	editor->Render(id, false, ImVec2(0,0), false);
}

IGEXPORT void igExtTextEditorFree(texteditor_t textedit)
{
	delete ((TextEditor*)textedit);
}
