namespace iverson_sigma
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpInfoFirst = new System.Windows.Forms.GroupBox();
            this.lblFirstAccumulated = new System.Windows.Forms.Label();
            this.lblFirstValue = new System.Windows.Forms.Label();
            this.lblFirstOpposition = new System.Windows.Forms.Label();
            this.txtSublist = new System.Windows.Forms.TextBox();
            this.treeViewDecisions = new System.Windows.Forms.TreeView();
            this.lblSelectionInfo = new System.Windows.Forms.Label();
            this.lblSelectionAccumulated = new System.Windows.Forms.Label();
            this.grpInfoLast = new System.Windows.Forms.GroupBox();
            this.lblLastAccumulated = new System.Windows.Forms.Label();
            this.lblLastValue = new System.Windows.Forms.Label();
            this.lblLastOpposition = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.grpInfoFirst.SuspendLayout();
            this.grpInfoLast.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(66, 14);
            this.txtInput.Margin = new System.Windows.Forms.Padding(5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(604, 32);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "1 4 5 2 3 3 5 1";
            this.txtInput.LostFocus += new System.EventHandler(this.txtInput_LostFocus);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(14, 22);
            this.lblList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(42, 20);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List:";
            // 
            // grpInfo
            // 
            this.grpInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfo.Controls.Add(this.lblSelectionAccumulated);
            this.grpInfo.Controls.Add(this.grpInfoLast);
            this.grpInfo.Controls.Add(this.grpInfoFirst);
            this.grpInfo.Controls.Add(this.txtSublist);
            this.grpInfo.Controls.Add(this.lblSelectionInfo);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(370, 56);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(5);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpInfo.Size = new System.Drawing.Size(300, 301);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // grpInfoFirst
            // 
            this.grpInfoFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfoFirst.Controls.Add(this.lblFirstAccumulated);
            this.grpInfoFirst.Controls.Add(this.lblFirstValue);
            this.grpInfoFirst.Controls.Add(this.lblFirstOpposition);
            this.grpInfoFirst.Location = new System.Drawing.Point(8, 99);
            this.grpInfoFirst.Name = "grpInfoFirst";
            this.grpInfoFirst.Size = new System.Drawing.Size(284, 94);
            this.grpInfoFirst.TabIndex = 1;
            this.grpInfoFirst.TabStop = false;
            this.grpInfoFirst.Text = "Choose First (?)";
            // 
            // lblFirstAccumulated
            // 
            this.lblFirstAccumulated.AutoSize = true;
            this.lblFirstAccumulated.Location = new System.Drawing.Point(6, 65);
            this.lblFirstAccumulated.Name = "lblFirstAccumulated";
            this.lblFirstAccumulated.Size = new System.Drawing.Size(200, 20);
            this.lblFirstAccumulated.TabIndex = 0;
            this.lblFirstAccumulated.Text = "?-?=? (P1-P2=Accmulated)";
            // 
            // lblFirstValue
            // 
            this.lblFirstValue.AutoSize = true;
            this.lblFirstValue.Location = new System.Drawing.Point(6, 45);
            this.lblFirstValue.Name = "lblFirstValue";
            this.lblFirstValue.Size = new System.Drawing.Size(138, 20);
            this.lblFirstValue.TabIndex = 0;
            this.lblFirstValue.Text = "Maximum Value: ?";
            // 
            // lblFirstOpposition
            // 
            this.lblFirstOpposition.AutoSize = true;
            this.lblFirstOpposition.Location = new System.Drawing.Point(6, 23);
            this.lblFirstOpposition.Name = "lblFirstOpposition";
            this.lblFirstOpposition.Size = new System.Drawing.Size(102, 20);
            this.lblFirstOpposition.TabIndex = 0;
            this.lblFirstOpposition.Text = "Opposition: ?";
            // 
            // txtSublist
            // 
            this.txtSublist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSublist.Location = new System.Drawing.Point(10, 27);
            this.txtSublist.Margin = new System.Windows.Forms.Padding(5);
            this.txtSublist.Name = "txtSublist";
            this.txtSublist.ReadOnly = true;
            this.txtSublist.Size = new System.Drawing.Size(280, 24);
            this.txtSublist.TabIndex = 0;
            this.txtSublist.Text = "? ? ?";
            this.txtSublist.LostFocus += new System.EventHandler(this.txtInput_LostFocus);
            // 
            // treeViewDecisions
            // 
            this.treeViewDecisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewDecisions.Location = new System.Drawing.Point(11, 53);
            this.treeViewDecisions.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewDecisions.Name = "treeViewDecisions";
            this.treeViewDecisions.Size = new System.Drawing.Size(352, 307);
            this.treeViewDecisions.TabIndex = 4;
            this.treeViewDecisions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDecisions_AfterSelect);
            // 
            // lblSelectionInfo
            // 
            this.lblSelectionInfo.AutoSize = true;
            this.lblSelectionInfo.Location = new System.Drawing.Point(8, 56);
            this.lblSelectionInfo.Name = "lblSelectionInfo";
            this.lblSelectionInfo.Size = new System.Drawing.Size(220, 20);
            this.lblSelectionInfo.TabIndex = 0;
            this.lblSelectionInfo.Text = "?-?=? (# - Opposition = Value)";
            // 
            // lblSelectionAccumulated
            // 
            this.lblSelectionAccumulated.AutoSize = true;
            this.lblSelectionAccumulated.Location = new System.Drawing.Point(8, 76);
            this.lblSelectionAccumulated.Name = "lblSelectionAccumulated";
            this.lblSelectionAccumulated.Size = new System.Drawing.Size(200, 20);
            this.lblSelectionAccumulated.TabIndex = 0;
            this.lblSelectionAccumulated.Text = "?-?=? (P1-P2=Accmulated)";
            // 
            // grpInfoLast
            // 
            this.grpInfoLast.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfoLast.Controls.Add(this.lblLastAccumulated);
            this.grpInfoLast.Controls.Add(this.lblLastValue);
            this.grpInfoLast.Controls.Add(this.lblLastOpposition);
            this.grpInfoLast.Location = new System.Drawing.Point(8, 199);
            this.grpInfoLast.Name = "grpInfoLast";
            this.grpInfoLast.Size = new System.Drawing.Size(284, 94);
            this.grpInfoLast.TabIndex = 1;
            this.grpInfoLast.TabStop = false;
            this.grpInfoLast.Text = "Choose Last (?)";
            // 
            // lblLastAccumulated
            // 
            this.lblLastAccumulated.AutoSize = true;
            this.lblLastAccumulated.Location = new System.Drawing.Point(6, 65);
            this.lblLastAccumulated.Name = "lblLastAccumulated";
            this.lblLastAccumulated.Size = new System.Drawing.Size(200, 20);
            this.lblLastAccumulated.TabIndex = 0;
            this.lblLastAccumulated.Text = "?-?=? (P1-P2=Accmulated)";
            // 
            // lblLastValue
            // 
            this.lblLastValue.AutoSize = true;
            this.lblLastValue.Location = new System.Drawing.Point(6, 45);
            this.lblLastValue.Name = "lblLastValue";
            this.lblLastValue.Size = new System.Drawing.Size(138, 20);
            this.lblLastValue.TabIndex = 0;
            this.lblLastValue.Text = "Maximum Value: ?";
            // 
            // lblLastOpposition
            // 
            this.lblLastOpposition.AutoSize = true;
            this.lblLastOpposition.Location = new System.Drawing.Point(6, 23);
            this.lblLastOpposition.Name = "lblLastOpposition";
            this.lblLastOpposition.Size = new System.Drawing.Size(102, 20);
            this.lblLastOpposition.TabIndex = 0;
            this.lblLastOpposition.Text = "Opposition: ?";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 371);
            this.Controls.Add(this.treeViewDecisions);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Iverson Exam Sigma Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpInfoFirst.ResumeLayout(false);
            this.grpInfoFirst.PerformLayout();
            this.grpInfoLast.ResumeLayout(false);
            this.grpInfoLast.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TreeView treeViewDecisions;
        private System.Windows.Forms.TextBox txtSublist;
        private System.Windows.Forms.GroupBox grpInfoFirst;
        private System.Windows.Forms.Label lblFirstOpposition;
        private System.Windows.Forms.Label lblFirstValue;
        private System.Windows.Forms.Label lblFirstAccumulated;
        private System.Windows.Forms.Label lblSelectionInfo;
        private System.Windows.Forms.Label lblSelectionAccumulated;
        private System.Windows.Forms.GroupBox grpInfoLast;
        private System.Windows.Forms.Label lblLastAccumulated;
        private System.Windows.Forms.Label lblLastValue;
        private System.Windows.Forms.Label lblLastOpposition;
    }
}

