using System.ComponentModel;

namespace CodeLengthAnalyze
{
    partial class StatsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            ""}, -1);
            this.listViewTotal = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewScriptsDetails = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linesOfCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTotal
            // 
            this.listViewTotal.HideSelection = false;
            this.listViewTotal.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.listViewTotal.Location = new System.Drawing.Point(15, 25);
            this.listViewTotal.Name = "listViewTotal";
            this.listViewTotal.Size = new System.Drawing.Size(434, 212);
            this.listViewTotal.TabIndex = 0;
            this.listViewTotal.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Summary";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lines of code by script";
            // 
            // listViewScriptsDetails
            // 
            this.listViewScriptsDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.linesOfCode});
            this.listViewScriptsDetails.HideSelection = false;
            this.listViewScriptsDetails.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.listViewScriptsDetails.Location = new System.Drawing.Point(15, 267);
            this.listViewScriptsDetails.Name = "listViewScriptsDetails";
            this.listViewScriptsDetails.Size = new System.Drawing.Size(434, 370);
            this.listViewScriptsDetails.TabIndex = 3;
            this.listViewScriptsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewScriptsDetails.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "File";
            this.fileName.Width = 324;
            // 
            // linesOfCode
            // 
            this.linesOfCode.Text = "Lines Of Code";
            this.linesOfCode.Width = 94;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 649);
            this.Controls.Add(this.listViewScriptsDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatsForm";
            this.ShowIcon = false;
            this.Text = "StatsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listViewScriptsDetails;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader linesOfCode;
    }
}

