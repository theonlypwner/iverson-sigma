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

        private int[] list;
        private int[][] listProcessed;

        private void recalc()
        {
            //listProcessed = new int[list.Length][];
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
            recalc();
        }
    }
}
