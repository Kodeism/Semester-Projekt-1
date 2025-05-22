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
            sælgerIDLabel.Location = new Point(17, 15);
            sælgerIDLabel.Margin = new Padding(4, 0, 4, 0);
            sælgerIDLabel.Name = "sælgerIDLabel";
            sælgerIDLabel.Size = new Size(30, 25);
            sælgerIDLabel.TabIndex = 0;
            sælgerIDLabel.Text = "ID";
            // 
            // annullerButton
            // 
            annullerButton.Location = new Point(17, 175);
            annullerButton.Margin = new Padding(4, 5, 4, 5);
            annullerButton.Name = "annullerButton";
            annullerButton.Size = new Size(107, 38);
            annullerButton.TabIndex = 1;
            annullerButton.Text = "Annuller";
            annullerButton.UseVisualStyleBackColor = true;
            annullerButton.Click += annullerButton_Click;
            // 
            // sletsælgerButton
            // 
            sletsælgerButton.Location = new Point(223, 175);
            sletsælgerButton.Margin = new Padding(4, 5, 4, 5);
            sletsælgerButton.Name = "sletsælgerButton";
            sletsælgerButton.Size = new Size(107, 38);
            sletsælgerButton.TabIndex = 2;
            sletsælgerButton.Text = "Slet";
            sletsælgerButton.UseVisualStyleBackColor = true;
            sletsælgerButton.Click += sletsælgerButton_Click;
            // 
            // sælgerIDTextBox
            // 
            sælgerIDTextBox.Location = new Point(17, 45);
            sælgerIDTextBox.Margin = new Padding(4, 5, 4, 5);
            sælgerIDTextBox.Name = "sælgerIDTextBox";
            sælgerIDTextBox.ReadOnly = true;
            sælgerIDTextBox.Size = new Size(141, 31);
            sælgerIDTextBox.TabIndex = 3;
            // 
            // DeleteSælger
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(350, 255);
            Controls.Add(sælgerIDTextBox);
            Controls.Add(sletsælgerButton);
            Controls.Add(annullerButton);
            Controls.Add(sælgerIDLabel);
            Margin = new Padding(4, 5, 4, 5);
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