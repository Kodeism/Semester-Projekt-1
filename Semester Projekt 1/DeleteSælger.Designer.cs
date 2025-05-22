namespace Semester_Projekt_1
{
    partial class DeleteSælger
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
            sælgerIDLabel = new Label();
            annullerButton = new Button();
            sletsælgerButton = new Button();
            sælgerIDTextBox = new TextBox();
            SuspendLayout();
            // 
            // sælgerIDLabel
            // 
            sælgerIDLabel.AutoSize = true;
            sælgerIDLabel.Location = new Point(12, 9);
            sælgerIDLabel.Name = "sælgerIDLabel";
            sælgerIDLabel.Size = new Size(57, 15);
            sælgerIDLabel.TabIndex = 0;
            sælgerIDLabel.Text = "Indtast ID";
            // 
            // annullerButton
            // 
            annullerButton.Location = new Point(12, 105);
            annullerButton.Name = "annullerButton";
            annullerButton.Size = new Size(75, 23);
            annullerButton.TabIndex = 1;
            annullerButton.Text = "Annuller";
            annullerButton.UseVisualStyleBackColor = true;
            annullerButton.Click += annullerButton_Click;
            // 
            // sletsælgerButton
            // 
            sletsælgerButton.Location = new Point(156, 105);
            sletsælgerButton.Name = "sletsælgerButton";
            sletsælgerButton.Size = new Size(75, 23);
            sletsælgerButton.TabIndex = 2;
            sletsælgerButton.Text = "Slet";
            sletsælgerButton.UseVisualStyleBackColor = true;
            sletsælgerButton.Click += sletsælgerButton_Click;
            // 
            // sælgerIDTextBox
            // 
            sælgerIDTextBox.Location = new Point(12, 27);
            sælgerIDTextBox.Name = "sælgerIDTextBox";
            sælgerIDTextBox.Size = new Size(100, 23);
            sælgerIDTextBox.TabIndex = 3;
            // 
            // DeleteSælger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(245, 153);
            Controls.Add(sælgerIDTextBox);
            Controls.Add(sletsælgerButton);
            Controls.Add(annullerButton);
            Controls.Add(sælgerIDLabel);
            Name = "DeleteSælger";
            Text = "DeleteSælger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label sælgerIDLabel;
        private Button annullerButton;
        private Button sletsælgerButton;
        private TextBox sælgerIDTextBox;
    }
}