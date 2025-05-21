namespace Semester_Projekt_1
{
    partial class SletSælger
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
            sletButton = new Button();
            anullerButton = new Button();
            idTextbox = new TextBox();
            indtastIDLabel = new Label();
            SuspendLayout();
            // 
            // sletButton
            // 
            sletButton.Location = new Point(154, 107);
            sletButton.Name = "sletButton";
            sletButton.Size = new Size(75, 23);
            sletButton.TabIndex = 0;
            sletButton.Text = "Slet";
            sletButton.UseVisualStyleBackColor = true;
            sletButton.Click += sletButton_Click;
            // 
            // anullerButton
            // 
            anullerButton.Location = new Point(12, 107);
            anullerButton.Name = "anullerButton";
            anullerButton.Size = new Size(75, 23);
            anullerButton.TabIndex = 1;
            anullerButton.Text = "Annuller";
            anullerButton.UseVisualStyleBackColor = true;
            anullerButton.Click += anullerButton_Click;
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(12, 38);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(100, 23);
            idTextbox.TabIndex = 2;
            // 
            // indtastIDLabel
            // 
            indtastIDLabel.AutoSize = true;
            indtastIDLabel.Location = new Point(12, 20);
            indtastIDLabel.Name = "indtastIDLabel";
            indtastIDLabel.Size = new Size(57, 15);
            indtastIDLabel.TabIndex = 3;
            indtastIDLabel.Text = "Indtast ID";
            // 
            // SletSælger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(244, 152);
            Controls.Add(indtastIDLabel);
            Controls.Add(idTextbox);
            Controls.Add(anullerButton);
            Controls.Add(sletButton);
            Name = "SletSælger";
            Text = "Slet Sælger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sletButton;
        private Button anullerButton;
        private TextBox idTextbox;
        private Label indtastIDLabel;
    }
}