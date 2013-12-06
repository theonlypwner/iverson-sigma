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
            this.lblInfoAccumulated = new System.Windows.Forms.Label();
            this.lblInfoP2 = new System.Windows.Forms.Label();
            this.lblInfoP1 = new System.Windows.Forms.Label();
            this.lblInfoValue = new System.Windows.Forms.Label();
            this.txtInfoSublist = new System.Windows.Forms.TextBox();
            this.lblInfoNumber = new System.Windows.Forms.Label();
            this.lblInfoOpposition = new System.Windows.Forms.Label();
            this.treeViewDecisions = new System.Windows.Forms.TreeView();
            this.grpInfo.SuspendLayout();
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
            this.grpInfo.Controls.Add(this.lblInfoAccumulated);
            this.grpInfo.Controls.Add(this.lblInfoP2);
            this.grpInfo.Controls.Add(this.lblInfoP1);
            this.grpInfo.Controls.Add(this.lblInfoValue);
            this.grpInfo.Controls.Add(this.txtInfoSublist);
            this.grpInfo.Controls.Add(this.lblInfoNumber);
            this.grpInfo.Controls.Add(this.lblInfoOpposition);
            this.grpInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfo.Location = new System.Drawing.Point(370, 56);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(5);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpInfo.Size = new System.Drawing.Size(300, 241);
            this.grpInfo.TabIndex = 3;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // lblInfoAccumulated
            // 
            this.lblInfoAccumulated.AutoSize = true;
            this.lblInfoAccumulated.Location = new System.Drawing.Point(8, 214);
            this.lblInfoAccumulated.Name = "lblInfoAccumulated";
            this.lblInfoAccumulated.Size = new System.Drawing.Size(164, 20);
            this.lblInfoAccumulated.TabIndex = 0;
            this.lblInfoAccumulated.Text = "Accumulated Value: ?";
            // 
            // lblInfoP2
            // 
            this.lblInfoP2.AutoSize = true;
            this.lblInfoP2.Location = new System.Drawing.Point(8, 194);
            this.lblInfoP2.Name = "lblInfoP2";
            this.lblInfoP2.Size = new System.Drawing.Size(142, 20);
            this.lblInfoP2.TabIndex = 0;
            this.lblInfoP2.Text = "P2 Accumulated: ?";
            // 
            // lblInfoP1
            // 
            this.lblInfoP1.AutoSize = true;
            this.lblInfoP1.Location = new System.Drawing.Point(8, 174);
            this.lblInfoP1.Name = "lblInfoP1";
            this.lblInfoP1.Size = new System.Drawing.Size(142, 20);
            this.lblInfoP1.TabIndex = 0;
            this.lblInfoP1.Text = "P1 Accumulated: ?";
            // 
            // lblInfoValue
            // 
            this.lblInfoValue.AutoSize = true;
            this.lblInfoValue.Location = new System.Drawing.Point(8, 96);
            this.lblInfoValue.Name = "lblInfoValue";
            this.lblInfoValue.Size = new System.Drawing.Size(67, 20);
            this.lblInfoValue.TabIndex = 0;
            this.lblInfoValue.Text = "Value: ?";
            // 
            // txtInfoSublist
            // 
            this.txtInfoSublist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfoSublist.Location = new System.Drawing.Point(10, 27);
            this.txtInfoSublist.Margin = new System.Windows.Forms.Padding(5);
            this.txtInfoSublist.Name = "txtInfoSublist";
            this.txtInfoSublist.ReadOnly = true;
            this.txtInfoSublist.Size = new System.Drawing.Size(280, 24);
            this.txtInfoSublist.TabIndex = 0;
            this.txtInfoSublist.Text = "? ? ?";
            this.txtInfoSublist.LostFocus += new System.EventHandler(this.txtInput_LostFocus);
            // 
            // lblInfoNumber
            // 
            this.lblInfoNumber.AutoSize = true;
            this.lblInfoNumber.Location = new System.Drawing.Point(8, 56);
            this.lblInfoNumber.Name = "lblInfoNumber";
            this.lblInfoNumber.Size = new System.Drawing.Size(82, 20);
            this.lblInfoNumber.TabIndex = 0;
            this.lblInfoNumber.Text = "Number: ?";
            // 
            // lblInfoOpposition
            // 
            this.lblInfoOpposition.AutoSize = true;
            this.lblInfoOpposition.Location = new System.Drawing.Point(8, 76);
            this.lblInfoOpposition.Name = "lblInfoOpposition";
            this.lblInfoOpposition.Size = new System.Drawing.Size(139, 20);
            this.lblInfoOpposition.TabIndex = 0;
            this.lblInfoOpposition.Text = "Best Opposition: ?";
            // 
            // treeViewDecisions
            // 
            this.treeViewDecisions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewDecisions.Location = new System.Drawing.Point(11, 53);
            this.treeViewDecisions.Margin = new System.Windows.Forms.Padding(2);
            this.treeViewDecisions.Name = "treeViewDecisions";
            this.treeViewDecisions.ShowNodeToolTips = true;
            this.treeViewDecisions.Size = new System.Drawing.Size(352, 247);
            this.treeViewDecisions.TabIndex = 4;
            this.treeViewDecisions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDecisions_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TreeView treeViewDecisions;
        private System.Windows.Forms.TextBox txtInfoSublist;
        private System.Windows.Forms.Label lblInfoOpposition;
        private System.Windows.Forms.Label lblInfoValue;
        private System.Windows.Forms.Label lblInfoAccumulated;
        private System.Windows.Forms.Label lblInfoP2;
        private System.Windows.Forms.Label lblInfoP1;
        private System.Windows.Forms.Label lblInfoNumber;
    }
}

