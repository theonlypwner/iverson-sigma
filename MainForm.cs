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
            int val1 = list[position] - listProcessed[depth - 1][position + 1];
            TreeNode choice1 = new TreeNode(
                String.Format("P{0} L {1}{2:+#;-#;+0}={3}",
                    player,
                    list[position],
                    -listProcessed[depth - 1][position + 1],
                    val1
                )
            );
            int val2 = list[position + depth] - listProcessed[depth - 1][position];
            TreeNode choice2 = new TreeNode(
                String.Format("P{0} R {1}{2:+#;-#;+0}={3}",
                    player,
                    list[position + depth],
                    -listProcessed[depth - 1][position],
                    val2
                )
            );
            if (val1 >= val2)
                choice1.BackColor = player == 1 ? color_highlight1 : color_highlight2;
            if (val2 >= val1)
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

        private void RecalcAndRedraw()
        {
            Recalc();
            MakeTree();
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
            RecalcAndRedraw();
        }
    }
}
