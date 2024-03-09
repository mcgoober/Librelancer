using LibreLancer.Ini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LancerEdit
{
    internal class EditableIni
    {
        public string File { get; }

        public string TextContents { get; set; }

        public IList<IniNode> Tree { get; }

        public bool IsOpen => true;

        public EditableIni(string file)
        {
            File = file;
            Tree = [];
            LoadFile();
        }

        private void LoadFile()
        {
            var stream = new FileStream(File, FileMode.Open, FileAccess.Read);
            var sections = IniFile.ParseFile(File, stream);
            foreach (var section in sections)
            {
                var sectionNode = new SectionIniNode() { Section = section };
                Tree.Add(sectionNode);
                foreach (var entry in section)
                {
                    var entryNode = new EntryIniNode() { Entry = entry };
                    sectionNode.Children.Add(entryNode);
                }
            }
        }

        public class IniNode
        {
            public virtual string Name { get; set; }

            public IniNode Parent { get; set; }

            public IList<IniNode> Children { get; } = [];
        }

        public class SectionIniNode : IniNode
        {
            public Section Section { get; set; }

            public override string Name
            {
                get
                {
                    return Section.Name;
                }
                set
                {
                }
            }
        }

        public class EntryIniNode : IniNode
        {
            public Entry Entry { get; set; }

            public override string Name
            {
                get
                {
                    return Entry.Name;
                }
                set
                {
                }
            }
        }        
    }
}
