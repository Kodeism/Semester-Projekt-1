namespace Semester_Projekt_1
{
    partial class SletBolig
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
            idTextbox = new TextBox();
            idLabel = new Label();
            annullerButton = new Button();
            sletButton = new Button();
            SuspendLayout();
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(27, 43);
            idTextbox.Name = "idTextbox";
            idTextbox.Size = new Size(100, 23);
            idTextbox.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(28, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(84, 15);
            idLabel.TabIndex = 1;
            idLabel.Text = "Indtast BoligID";
            // 
            // annullerButton
            // 
            annullerButton.Location = new Point(51, 183);
            annullerButton.Name = "annullerButton";
            annullerButton.Size = new Size(75, 23);
            annullerButton.TabIndex = 2;
            annullerButton.Text = "Annuller";
            annullerButton.UseVisualStyleBackColor = true;
            annullerButton.Click += button1_Click;
            // 
            // sletButton
            // 
            sletButton.Location = new Point(268, 189);
            sletButton.Name = "sletButton";
            sletButton.Size = new Size(75, 23);
            sletButton.TabIndex = 3;
            sletButton.Text = "Slet";
            sletButton.UseVisualStyleBackColor = true;
            sletButton.Click += button2_Click;
            // 
            // SletBolig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(372, 230);
            Controls.Add(sletButton);
            Controls.Add(annullerButton);
            Controls.Add(idLabel);
            Controls.Add(idTextbox);
            Name = "SletBolig";
            Text = "SletBolig";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTextbox;
        private Label idLabel;
        private Button annullerButton;
        private Button sletButton;
    }
}