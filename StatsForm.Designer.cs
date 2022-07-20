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
            this.listViewTotal = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewScriptsDetails = new System.Windows.Forms.ListView();
            this.filePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linesOfCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dotComaCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emptyStrings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTotal
            // 
            this.listViewTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewTotal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.title,
            this.value});
            this.listViewTotal.HideSelection = false;
            this.listViewTotal.Location = new System.Drawing.Point(15, 25);
            this.listViewTotal.Name = "listViewTotal";
            this.listViewTotal.Size = new System.Drawing.Size(967, 118);
            this.listViewTotal.TabIndex = 0;
            this.listViewTotal.UseCompatibleStateImageBehavior = false;
            this.listViewTotal.View = System.Windows.Forms.View.Details;
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
            this.label2.Location = new System.Drawing.Point(9, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Info by script";
            // 
            // listViewScriptsDetails
            // 
            this.listViewScriptsDetails.AllowColumnReorder = true;
            this.listViewScriptsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewScriptsDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.linesOfCode,
            this.emptyStrings,
            this.dotComaCount,
            this.filePath});
            this.listViewScriptsDetails.HideSelection = false;
            this.listViewScriptsDetails.Location = new System.Drawing.Point(12, 185);
            this.listViewScriptsDetails.Name = "listViewScriptsDetails";
            this.listViewScriptsDetails.Size = new System.Drawing.Size(967, 452);
            this.listViewScriptsDetails.TabIndex = 3;
            this.listViewScriptsDetails.UseCompatibleStateImageBehavior = false;
            this.listViewScriptsDetails.View = System.Windows.Forms.View.Details;
            // 
            // filePath
            // 
            this.filePath.Text = "File Path";
            this.filePath.Width = 450;
            // 
            // linesOfCode
            // 
            this.linesOfCode.Text = "Lines Of Code";
            this.linesOfCode.Width = 100;
            // 
            // fileName
            // 
            this.fileName.Text = "File Name";
            this.fileName.Width = 250;
            // 
            // dotComaCount
            // 
            this.dotComaCount.Text = "\';\' count";
            this.linesOfCode.Width = 100;
            // 
            // emptyStrings
            // 
            this.emptyStrings.Text = "Empty Strings";
            this.emptyStrings.Width = 100;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.Width = 300;
            // 
            // value
            // 
            this.value.Text = "Value";
            this.value.Width = 300;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 649);
            this.Controls.Add(this.listViewScriptsDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewTotal);
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
        private System.Windows.Forms.ColumnHeader filePath;
        private System.Windows.Forms.ColumnHeader linesOfCode;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader dotComaCount;
        private System.Windows.Forms.ColumnHeader emptyStrings;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader value;
    }
}

