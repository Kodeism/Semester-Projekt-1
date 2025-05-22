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
            annullerButton.Location = new Point(12, 120);
            annullerButton.Name = "annullerButton";
            annullerButton.Size = new Size(75, 23);
            annullerButton.TabIndex = 0;
            annullerButton.Text = "Annuller";
            annullerButton.UseVisualStyleBackColor = true;
            annullerButton.Click += annullerButton_Click;
            // 
            // sletButton
            // 
            sletButton.Location = new Point(160, 120);
            sletButton.Name = "sletButton";
            sletButton.Size = new Size(75, 23);
            sletButton.TabIndex = 1;
            sletButton.Text = "Slet";
            sletButton.UseVisualStyleBackColor = true;
            sletButton.Click += sletButton_Click;
            // 
            // boligIDLabel
            // 
            boligIDLabel.AutoSize = true;
            boligIDLabel.Location = new Point(12, 9);
            boligIDLabel.Name = "boligIDLabel";
            boligIDLabel.Size = new Size(57, 15);
            boligIDLabel.TabIndex = 2;
            boligIDLabel.Text = "Indtast ID";
            // 
            // boligIDTextBox
            // 
            boligIDTextBox.Location = new Point(12, 27);
            boligIDTextBox.Name = "boligIDTextBox";
            boligIDTextBox.Size = new Size(100, 23);
            boligIDTextBox.TabIndex = 3;
            // 
            // DeleteBolig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(251, 165);
            Controls.Add(boligIDTextBox);
            Controls.Add(boligIDLabel);
            Controls.Add(sletButton);
            Controls.Add(annullerButton);
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