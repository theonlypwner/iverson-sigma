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
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.treeViewDecisions = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(83, 15);
            this.txtInput.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(662, 32);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "1 4 5 2 3 3 5 1";
            this.txtInput.LostFocus += new System.EventHandler(this.txtInput_LostFocus);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(15, 15);
            this.lblList.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(56, 29);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "List:";
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Location = new System.Drawing.Point(452, 59);
            this.grpDetails.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpDetails.Size = new System.Drawing.Size(293, 273);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Information";
            // 
            // treeViewDecisions
            // 
            this.treeViewDecisions.Location = new System.Drawing.Point(12, 59);
            this.treeViewDecisions.Name = "treeViewDecisions";
            this.treeViewDecisions.Size = new System.Drawing.Size(431, 279);
            this.treeViewDecisions.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 347);
            this.Controls.Add(this.treeViewDecisions);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.84F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Iverson Exam Sigma Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TreeView treeViewDecisions;
    }
}

