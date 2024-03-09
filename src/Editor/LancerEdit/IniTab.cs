using ImGuiNET;
using LibreLancer.ContentEdit;
using LibreLancer.ImUI;
using LibreLancer.Ini;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace LancerEdit
{
    internal class IniTab : EditorTab
    {
        private readonly MainWindow window;

        private string _filePath;

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

        private readonly EditableIni ini;
        EditableIni.IniNode selectedNode = null;
        ImGuiTreeNodeFlags tflags = ImGuiTreeNodeFlags.OpenOnArrow | ImGuiTreeNodeFlags.OpenOnDoubleClick;

        public IniTab(MainWindow window, string file)
        {
            this.window = window;
            FilePath = file;
            ini = new EditableIni(file);
        }

        public override void Draw(double elapsed)
        {
            ImGui.Columns(2, "IniColumns", true);
            ImGui.Separator();
            ImGui.Text("Ini Sections");
            ImGui.NextColumn();
            ImGui.Text("Entry Information");
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
                ImGui.Text(entryNode.Entry.FirstOrDefault()?.ToString());
            }
            
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
