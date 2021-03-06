﻿using System;
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

        private static int[] list;
        private static int[][] listProcessed;

        public struct SublistInfo
        {
            // Choice type
            public bool isLeft;
            // Player number
            public int player;
            // Range
            public int position, depth;
            // Accumulated Values
            public int p1, p2;

            public int number { get
            {
                if(isLeft)
                    return list[position];
                else
                    return list[position + depth];
            }}

            public int opposition { get
            {
                // Special case: last depth: no opposition
                if (depth == 0)
                    return 0;
                // Special case: 2 choices left
                if (depth == 1)
                    return list[isLeft ? position + 1 : position];
                // Use computed sublist values
                if(isLeft)
                    return listProcessed[depth - 1][position + 1];
                else
                    return listProcessed[depth - 1][position];
            }}
        }

        private void Recalc()
        {
            // Make the array
            int n = list.Length;
            listProcessed = new int[n][];
            listProcessed[0] = list;
            for (int i = 1; i < n; ++i)
                listProcessed[i] = new int[n - i];
            // Process the list
            for (int gap = 1; gap < n; ++gap)
                for (int x = 0; x < n - gap; ++x)
                    listProcessed[gap][x] = Math.Max(list[x] - listProcessed[gap - 1][x + 1],
                                                    list[x + gap] - listProcessed[gap - 1][x]);
            // value = listProcessed[n - 1][0]
        }

        private void MakeTree(TreeNodeCollection parent, int depth, int position = 0, int p1 = 0, int p2 = 0, int player = 1)
        {
            // Build choice information
            SublistInfo info1 = new SublistInfo(), info2 = new SublistInfo();
            info1.isLeft = true;
            info2.isLeft = false;
            info1.position = info2.position = position;
            info1.depth = info2.depth = depth;
            if (player == 1)
            {
                info1.p1 = p1 + info1.number;
                info2.p1 = p1 + info2.number;
                info1.p2 = info2.p2 = p2;
            }
            else
            {
                info1.p1 = info2.p1 = p1;
                info1.p2 = p2 + info1.number;
                info2.p2 = p2 + info2.number;
            }
            // Make nodes
            if (depth == 0)
            {
                // Add terminal node
                TreeNode choice1 = new TreeNode(String.Format(
                    "P{0} F {1} ({2}{3:+#;-#;+0}={4})",
                    player, info1.number, info1.p1, -info1.p2, info1.p1 - info1.p2
                ));
                choice1.ToolTipText = String.Format(
                    "P{0} takes the final item, {1}. P1 has {2} points; player 2 has {3} points, so P1 has a final value of {4}.",
                    player, info1.number, info1.p1, info1.p2, info1.p1 - info1.p2
                );
                choice1.Tag = info1;
                choice1.BackColor = player == 1 ? color_highlight1 : color_highlight2;
                parent.Add(choice1);
            }
            else
            {
                // Non-terminal nodes
                TreeNode choice1 = new TreeNode(String.Format(
                    "P{0} L {1}{2:+#;-#;+0}={3} ({4})",
                    player, info1.number, -info1.opposition, info1.number - info1.opposition, info1.p1 - info1.p2
                ));
                choice1.ToolTipText = String.Format(
                    "P{0} takes the first, {1}, leaving {2} for the opponent. So far, P1 has {3} points; player 2 has {4} points, so P1 has a value of {5}.",
                    player, info1.number, info1.opposition, info1.p1, info1.p2, info1.p1 - info1.p2
                );
                choice1.Tag = info1;
                TreeNode choice2 = new TreeNode(String.Format(
                    "P{0} R {1}{2:+#;-#;+0}={3} ({4})",
                    player, info2.number, -info2.opposition, info2.number - info2.opposition, info2.p1 - info2.p2
                ));
                choice2.ToolTipText = String.Format(
                    "P{0} takes the last, {1}, leaving {2} for the opponent. So far, P1 has {3} points; player 2 has {4} points, so P1 has a value of {5}.",
                    player, info2.number, info2.opposition, info2.p1, info2.p2, info2.p1 - info2.p2
                );
                choice2.Tag = info2;
                bool best1 = info1.number + info2.opposition >= info2.number + info1.opposition; // (info1.value - info1.opposition >= info2.value - info2.opposition)
                bool best2 = info2.number + info1.opposition >= info1.number + info2.opposition; // (info2.value - info2.opposition >= info1.value - info1.opposition)
                if (best1)
                    choice1.BackColor = player == 1 ? color_highlight1 : color_highlight2;
                if (best2)
                    choice2.BackColor = player == 1 ? color_highlight1 : color_highlight2;
                parent.Add(choice1);
                parent.Add(choice2);
                if (!chkPartial.Checked || best1)
                    MakeTree(choice1.Nodes, depth - 1, position + 1, info1.p1, info1.p2, player ^ 3);
                if (!chkPartial.Checked || best2)
                    MakeTree(choice2.Nodes, depth - 1, position, info2.p1, info2.p2, player ^ 3);
            }
        }

        private void MakeTree()
        {
            treeViewDecisions.BeginUpdate();
            treeViewDecisions.Nodes.Clear();
            MakeTree(treeViewDecisions.Nodes, list.Length - 1);
            treeViewDecisions.EndUpdate();
            treeViewDecisions.SelectedNode = treeViewDecisions.Nodes[0];
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtInput_LostFocus(sender, e);
            toolTip.SetToolTip(txtInput, "Enter the space-separated numbers in the list.");
            toolTip.SetToolTip(chkPartial, "Check to process only the sane subtrees.");
            toolTip.SetToolTip(lblInfoNumber, "The item that the player decided to take.");
            toolTip.SetToolTip(lblInfoOpposition, "The maximum possible value for the opponent.");
            toolTip.SetToolTip(lblInfoValue, "The value for this move, if every following move is sane.");
            toolTip.SetToolTip(lblInfoP1, "Player 1's points so far.");
            toolTip.SetToolTip(lblInfoP2, "Player 2's points so far.");
            toolTip.SetToolTip(lblInfoAccumulated, "Player 1's value so far.");
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

            // Check for an empty list
            if (numbers_int.Count == 0)
            {
                numbers_int.Add(0);
                numbers_str.Add("0");
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
            // Show sublist
            if (info.depth == 0)
                txtInfoSublist.Text = list[info.position].ToString();
            else
            {
                int max = info.position + info.depth;
                if (info.isLeft)
                {
                    txtInfoSublist.Text = list[info.position].ToString() + " [";
                    for (int i = info.position + 1; i <= max; ++i)
                        txtInfoSublist.Text += list[i].ToString() + (i == max ? "]" : " ");
                }
                else
                {
                    txtInfoSublist.Text = "[";
                    for (int i = info.position; i < max; ++i)
                        txtInfoSublist.Text += list[i].ToString() + (i + 1 == max ? "] " : " ");
                    txtInfoSublist.Text += list[max].ToString();
                }
            }
            // Update choice info
            lblInfoNumber.Text = "Number: " + info.number.ToString();
            if (info.depth == 0)
                lblInfoOpposition.Text = "Opposition: None (final item)";
            else
                lblInfoOpposition.Text = "Opposition: " + info.opposition.ToString();
            lblInfoValue.Text = "Value: " + (info.number - info.opposition).ToString();
            lblInfoP1.Text = "P1 Accumulated: " + info.p1.ToString();
            lblInfoP2.Text = "P2 Accumulated: " + info.p2.ToString();
            lblInfoAccumulated.Text = "Accumulated Value: " + (info.p1 - info.p2).ToString();
        }
    }
}
