﻿namespace Semester_Projekt_1
{
    partial class SaelgerFilterForm
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 246, 218);
            panel1.Location = new Point(35, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 711);
            panel1.TabIndex = 0;
            // 
            // SaelgerFilterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(871, 765);
            Controls.Add(panel1);
            Name = "SaelgerFilterForm";
            Text = "SaelgerFilterForm";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
    }
}