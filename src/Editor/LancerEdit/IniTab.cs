using ImGuiNET;
using LibreLancer;
using LibreLancer.ImUI;
using System.IO;
using System.Linq;

namespace LancerEdit
{
    internal class IniTab : EditorTab
    {
        private readonly MainWindow window;
        private readonly ColorTextEdit colorTextEdit;

        private string _filePath;
        private readonly EditableIni ini;
        private EditableIni.IniNode selectedNode = null;
        private ImGuiTreeNodeFlags tflags = ImGuiTreeNodeFlags.OpenOnArrow | ImGuiTreeNodeFlags.OpenOnDoubleClick;
        private BitArray128 openTabs;

        public string FilePath
        {
            get
            {
                return _filePath;
            }
            private set
            {
                _filePath = value;
                DocumentName = FilePath != null ? Path.GetFileName(FilePath) : "Untitled";
                Title = DocumentName;
            }
        }

        public IniTab(MainWindow window, string file)
        {
            this.window = window;
            FilePath = file;
            ini = new EditableIni(file);
            colorTextEdit = new ColorTextEdit();
            colorTextEdit.SetMode(ColorTextEditMode.Ini);
            colorTextEdit.SetText(ini.TextContents);
            openTabs = new BitArray128();
            openTabs[0] = true;
        }

        

        void TabButton(string name, int idx)
        {
            if (TabHandler.VerticalTab($"{name}", openTabs[idx]))
            {
                if (!openTabs[idx])
                {
                    openTabs = new BitArray128();
                    openTabs[idx] = true;
                }
            }
        }

        public override void Draw(double elapsed)
        {
            //ImGui.GetStyle().ScaleAllSizes(2);
            ImGui.Columns(2, "TabColumns", false);
            ImGui.SetColumnWidth(0, 40f);
            ImGuiNative.igBeginGroup();
            TabButton("Hierarchy", 0);
            TabButton("Source", 1);
            ImGuiNative.igEndGroup();
            //ImGui.SameLine();
            ImGui.NextColumn();

            ImGui.BeginChild("##tabchild");
            if (openTabs.Any())
            {
                if (openTabs[0]) Hierarchy();
                if (openTabs[1]) Source();
            }
            ImGui.EndChild();
        }
        private void Hierarchy()
        {

            ImGui.Columns(2, "IniColumns", true);
            ImGui.Separator();
            ImGui.Text("Sections");
            ImGui.NextColumn();
            ImGui.Text("Entry Values");
            ImGui.NextColumn();
            ImGui.Separator();
            //Tree
            ImGui.BeginChild("##scroll");
            for (int i = 0; i < ini.Tree.Count; i++)
            {
                DoNode(ini.Tree[i], i);
            }
            ImGui.TreePop();
            ImGui.EndChild();
            //End Tree
            if (selectedNode is EditableIni.EntryIniNode entryNode)
            {
                ImGui.NextColumn();
                var value = entryNode.Entry.FirstOrDefault()?.ToString();
                if (value != null)
                    ImGui.Text(value);
            }            
        }

        private void Source()
        {
            colorTextEdit.Render("##ColorTextEditor");
        }

        void DoNode(EditableIni.IniNode node, int idx)
        {
            string id = ImGuiExt.IDWithExtra(node.Name, idx);
            if (node.Children.Count > 0)
            {
                var flags = selectedNode == node ? ImGuiTreeNodeFlags.Selected | tflags : tflags;
                var isOpen = ImGui.TreeNodeEx(id, flags);
                if (ImGui.IsItemClicked(0))
                {
                    selectedNode = node;
                }
                //if (node.ResolvedName != null)
                //{
                 //   ImGui.SameLine();
                  //  ImGui.TextDisabled("(" + ImGuiExt.IDSafe(node.ResolvedName) + ")");
                //}
                //ImGui.PushID(id);
                //DoNodeMenu(id, node, parent);
                //ImGui.PopID();
                //int i = 0;
                if (isOpen)
                {
                    for (int i = 0; i < node.Children.Count; i++)
                    {
                        DoNode(node.Children[i], (idx * 1024) + i);
                    }
                    ImGui.TreePop();
                }
            }
            else
            {
                /*
                if (node.Data != null)
                {
                    ImGui.Bullet();
                }
                else
                {
                    ImGui.Text($"  {Icons.BulletEmpty}");
                    ImGui.SameLine();
                }
                */
                bool selected = selectedNode == node;
                if (ImGui.Selectable(id, ref selected))
                {
                    selectedNode = node;
                }
                /*
                if (node.ResolvedName != null)
                {
                    ImGui.SameLine();
                    ImGui.TextDisabled("(" + ImGuiExt.IDSafe(node.ResolvedName) + ")");
                }
                DoNodeMenu(id, node, parent);
                */
            }

        }
    }
}
