﻿namespace MainFile
{
    partial class Demo
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
            this.excelsheet1 = new MainFile.Excelsheet();
            this.SuspendLayout();
            // 
            // excelsheet1
            // 
            this.excelsheet1.Location = new System.Drawing.Point(0, -3);
            this.excelsheet1.Name = "excelsheet1";
            this.excelsheet1.Size = new System.Drawing.Size(895, 767);
            this.excelsheet1.TabIndex = 0;
            // 
            // Demo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 766);
            this.Controls.Add(this.excelsheet1);
            this.Name = "Demo";
            this.Text = "Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private Excelsheet excelsheet1;









    }
}