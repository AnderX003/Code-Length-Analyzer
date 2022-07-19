namespace CodeLengthAnalyze
{
    partial class MenuForm
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
            this.checkedListBoxTypes = new System.Windows.Forms.CheckedListBox();
            this.listBoxDirectories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddDirectory = new System.Windows.Forms.Button();
            this.buttonRemoveDirectory = new System.Windows.Forms.Button();
            this.buttonStartAnalyze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxTypes
            // 
            this.checkedListBoxTypes.FormattingEnabled = true;
            this.checkedListBoxTypes.Location = new System.Drawing.Point(12, 167);
            this.checkedListBoxTypes.Name = "checkedListBoxTypes";
            this.checkedListBoxTypes.Size = new System.Drawing.Size(402, 169);
            this.checkedListBoxTypes.TabIndex = 0;
            // 
            // listBoxDirectories
            // 
            this.listBoxDirectories.FormattingEnabled = true;
            this.listBoxDirectories.Location = new System.Drawing.Point(15, 25);
            this.listBoxDirectories.Name = "listBoxDirectories";
            this.listBoxDirectories.Size = new System.Drawing.Size(402, 82);
            this.listBoxDirectories.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Included file types";
            // 
            // buttonAddDirectory
            // 
            this.buttonAddDirectory.Location = new System.Drawing.Point(342, 113);
            this.buttonAddDirectory.Name = "buttonAddDirectory";
            this.buttonAddDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDirectory.TabIndex = 5;
            this.buttonAddDirectory.Text = "Add";
            this.buttonAddDirectory.UseVisualStyleBackColor = true;
            this.buttonAddDirectory.Click += new System.EventHandler(this.buttonAddDirectory_Click);
            // 
            // buttonRemoveDirectory
            // 
            this.buttonRemoveDirectory.Location = new System.Drawing.Point(261, 113);
            this.buttonRemoveDirectory.Name = "buttonRemoveDirectory";
            this.buttonRemoveDirectory.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDirectory.TabIndex = 4;
            this.buttonRemoveDirectory.Text = "Remove";
            this.buttonRemoveDirectory.UseVisualStyleBackColor = true;
            this.buttonRemoveDirectory.Click += new System.EventHandler(this.buttonRemoveDirectory_Click);
            // 
            // buttonStartAnalyze
            // 
            this.buttonStartAnalyze.Location = new System.Drawing.Point(12, 352);
            this.buttonStartAnalyze.Name = "buttonStartAnalyze";
            this.buttonStartAnalyze.Size = new System.Drawing.Size(402, 30);
            this.buttonStartAnalyze.TabIndex = 6;
            this.buttonStartAnalyze.Text = "Analyze";
            this.buttonStartAnalyze.UseVisualStyleBackColor = true;
            this.buttonStartAnalyze.Click += new System.EventHandler(this.buttonStartAnalyze_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 395);
            this.Controls.Add(this.buttonStartAnalyze);
            this.Controls.Add(this.buttonRemoveDirectory);
            this.Controls.Add(this.buttonAddDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDirectories);
            this.Controls.Add(this.checkedListBoxTypes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MenuForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Code Length Analyzer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxTypes;
        private System.Windows.Forms.ListBox listBoxDirectories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddDirectory;
        private System.Windows.Forms.Button buttonRemoveDirectory;
        private System.Windows.Forms.Button buttonStartAnalyze;
    }
}
