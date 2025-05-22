namespace Semester_Projekt_1
{
    partial class DeleteBolig
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
            annullerButton = new Button();
            sletButton = new Button();
            boligIDLabel = new Label();
            boligIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // annullerButton
            // 
            annullerButton.Location = new Point(17, 200);
            annullerButton.Margin = new Padding(4, 5, 4, 5);
            annullerButton.Name = "annullerButton";
            annullerButton.Size = new Size(107, 38);
            annullerButton.TabIndex = 0;
            annullerButton.Text = "Annuller";
            annullerButton.UseVisualStyleBackColor = true;
            annullerButton.Click += annullerButton_Click;
            // 
            // sletButton
            // 
            sletButton.Location = new Point(229, 200);
            sletButton.Margin = new Padding(4, 5, 4, 5);
            sletButton.Name = "sletButton";
            sletButton.Size = new Size(107, 38);
            sletButton.TabIndex = 1;
            sletButton.Text = "Slet";
            sletButton.UseVisualStyleBackColor = true;
            sletButton.Click += sletButton_Click;
            // 
            // boligIDLabel
            // 
            boligIDLabel.AutoSize = true;
            boligIDLabel.Location = new Point(17, 15);
            boligIDLabel.Margin = new Padding(4, 0, 4, 0);
            boligIDLabel.Name = "boligIDLabel";
            boligIDLabel.Size = new Size(30, 25);
            boligIDLabel.TabIndex = 2;
            boligIDLabel.Text = "ID";
            // 
            // boligIDTextBox
            // 
            boligIDTextBox.Location = new Point(17, 45);
            boligIDTextBox.Margin = new Padding(4, 5, 4, 5);
            boligIDTextBox.Name = "boligIDTextBox";
            boligIDTextBox.ReadOnly = true;
            boligIDTextBox.Size = new Size(141, 31);
            boligIDTextBox.TabIndex = 3;
            // 
            // DeleteBolig
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(359, 275);
            Controls.Add(boligIDTextBox);
            Controls.Add(boligIDLabel);
            Controls.Add(sletButton);
            Controls.Add(annullerButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DeleteBolig";
            Text = "DeleteBolig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button annullerButton;
        private Button sletButton;
        private Label boligIDLabel;
        private TextBox boligIDTextBox;
    }
}