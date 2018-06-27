using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class PlaylistsTreeViewer : Form
    {
        public PlaylistsTreeViewer(TabControl tabControl)
        {
            InitializeComponent();
            CreateContent(tabControl);
            TreeView.ExpandAll();
        }

        private void CreateContent(TabControl tabControl)
        {
            foreach (TabPage tabPage in tabControl.TabPages)
            {
                var listBox = tabPage.Controls[0] as ListBox;
                if (listBox == null)
                {
                    continue;
                }
                var node = new TreeNode(tabPage.Text);
                foreach (string trackInfo in listBox.Items)
                {
                    node.Nodes.Add(trackInfo);
                }
                TreeView.Nodes.Add(node);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
