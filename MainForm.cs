using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Collections;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iverson_sigma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private readonly Color color_highlight1 = Color.YellowGreen;
        private readonly Color color_highlight2 = Color.DarkOrange;

        private int[] list;
        private int[][] listProcessed;

        public struct SublistInfo
        {
            public bool isLeft;
            // Range
            public int start, end;
            // Node value
            public int value, opposition;
            // Accumulated Values
            public int p1, p2;
        }

        private void Recalc()
        {
            // Make the array
            int n = list.Length;
            listProcessed = new int[n][];
            for (int i = 0; i < n; ++i)
                listProcessed[i] = new int[n - i];
            // Copy the list
            for (int j = 0; j < n; ++j)
                listProcessed[0][j] = list[j];
            // Process the list
            for (int gap = 1; gap < n; ++gap)
                for (int x = 0; x < n - gap; ++x)
                    listProcessed[gap][x] = Math.Max(list[x] - listProcessed[gap - 1][x + 1],
                                                    list[x + gap] - listProcessed[gap - 1][x]);
            // value = listProcessed[n - 1][0]
        }

        private void MakeTree(TreeNodeCollection parent, int depth, int position = 0, int player = 1)
        {
            // Build choice information
            SublistInfo info1 = new SublistInfo(), info2 = new SublistInfo();
            info1.isLeft = true;
            info2.isLeft = false;
            info1.start = info2.start = position;
            info1.end = info2.end = position + depth;

            info1.value = list[position];
            info1.opposition = listProcessed[depth - 1][position + 1];
            info2.value = list[position + depth];
            info2.opposition = listProcessed[depth - 1][position];

            // Make nodes
            TreeNode choice1 = new TreeNode(
                String.Format("P{0} L {1}{2:+#;-#;+0}={3}",
                    player,
                    info1.value,
                    -info1.opposition,
                    info1.value - info1.opposition
                )
            );
            choice1.Tag = info1;
            TreeNode choice2 = new TreeNode(
                String.Format("P{0} R {1}{2:+#;-#;+0}={3}",
                    player,
                    info2.value,
                    -info2.opposition,
                    info2.value - info2.opposition
                )
            );
            choice2.Tag = info2;
            if (info1.value + info2.opposition >= info2.value + info1.opposition) // (info1.value - info1.opposition >= info2.value - info2.opposition)
                choice1.BackColor = player == 1 ? color_highlight1 : color_highlight2;
            if (info2.value + info1.opposition >= info1.value + info2.opposition) // (info2.value - info2.opposition >= info1.value - info1.opposition)
                choice2.BackColor = player == 1 ? color_highlight1 : color_highlight2;
            parent.Add(choice1);
            parent.Add(choice2);
            if (depth > 1)
            {
                MakeTree(choice1.Nodes, depth - 1, position + 1, player ^ 3);
                MakeTree(choice2.Nodes, depth - 1, position, player ^ 3);
            }
        }

        private void MakeTree()
        {
            treeViewDecisions.BeginUpdate();
            treeViewDecisions.Nodes.Clear();
            MakeTree(treeViewDecisions.Nodes, list.Length - 1);
            treeViewDecisions.EndUpdate();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtInput_LostFocus(sender, e);
        }

        private void txtInput_LostFocus(object sender, EventArgs e)
        {
            ArrayList numbers_int = new ArrayList();
            ArrayList numbers_str = new ArrayList();

            // Get valid numbers
            foreach (string s in txtInput.Text.Split(' '))
            {
                int number;
                if (Int32.TryParse(s, out number))
                {
                    numbers_int.Add(number);
                    numbers_str.Add(number.ToString());
                }
            }

            // Set the text to something valid
            txtInput.Text = String.Join(" ", (string[])numbers_str.ToArray(typeof(string)));

            // Recalculate the list
            list = (int []) numbers_int.ToArray(typeof(int));
            Recalc();

            // Make the tree
            MakeTree();
        }

        private void treeViewDecisions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SublistInfo info = (SublistInfo) e.Node.Tag;
            // Fill out sublist
            if (info.isLeft)
            {
                txtSublist.Text = list[info.start].ToString() + " [";
                for (int i = info.start + 1; i <= info.end; ++i)
                    txtSublist.Text += list[i].ToString() + (i == info.end ? "]" : " ");
            }
            else
            {
                txtSublist.Text = "[";
                for (int i = info.start; i < info.end; ++i)
                    txtSublist.Text += list[i].ToString() + (i + 1 == info.end ? "] " : " ");
                txtSublist.Text += list[info.end].ToString();
            }
            // Choice info
            lblSelectionInfo.Text = String.Format("{0}{1:+#;-#;+0}={2} (# - Opposition = Value)", info.value, -info.opposition, info.value - info.opposition);
            lblSelectionAccumulated.Text = String.Format("?-?=? (P1-P2=Accmulated)", info.p1, info.p2, info.p1 - info.p2);
            // Choose First
            // Choose Last
        }
    }
}
