namespace Semester_Projekt_1
{
    partial class SaleRegistration
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
            SaleFormPanel = new Panel();
            SaleMenuPanel = new Panel();
            SaleFormExit = new Button();
            SaleFormularLabel = new Label();
            SaleDateTextBox = new TextBox();
            SalePriceTextBox = new TextBox();
            SaleBuyerCPRTextBox = new TextBox();
            CreateSaleButton = new Button();
            CancelSaleButton = new Button();
            SaleDateLabel = new Label();
            SalePriceLabel = new Label();
            SaleBuyerCPRLabel = new Label();
            SaleNameLabel = new Label();
            SaleRegistrationForm = new Panel();
            SaleFormPanel.SuspendLayout();
            SaleMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SaleFormPanel
            // 
            SaleFormPanel.BackColor = Color.FromArgb(255, 246, 218);
            SaleFormPanel.BorderStyle = BorderStyle.FixedSingle;
            SaleFormPanel.Controls.Add(SaleMenuPanel);
            SaleFormPanel.Controls.Add(SaleDateTextBox);
            SaleFormPanel.Controls.Add(SalePriceTextBox);
            SaleFormPanel.Controls.Add(SaleBuyerCPRTextBox);
            SaleFormPanel.Controls.Add(CreateSaleButton);
            SaleFormPanel.Controls.Add(CancelSaleButton);
            SaleFormPanel.Controls.Add(SaleDateLabel);
            SaleFormPanel.Controls.Add(SalePriceLabel);
            SaleFormPanel.Controls.Add(SaleBuyerCPRLabel);
            SaleFormPanel.Controls.Add(SaleNameLabel);
            SaleFormPanel.Controls.Add(SaleRegistrationForm);
            SaleFormPanel.Location = new Point(125, 54);
            SaleFormPanel.Name = "SaleFormPanel";
            SaleFormPanel.Size = new Size(551, 641);
            SaleFormPanel.TabIndex = 0;
            SaleFormPanel.Paint += SaleRegistrationForm_Paint;
            // 
            // SaleMenuPanel
            // 
            SaleMenuPanel.BorderStyle = BorderStyle.FixedSingle;
            SaleMenuPanel.Controls.Add(SaleFormExit);
            SaleMenuPanel.Controls.Add(SaleFormularLabel);
            SaleMenuPanel.Location = new Point(-1, -1);
            SaleMenuPanel.Name = "SaleMenuPanel";
            SaleMenuPanel.Size = new Size(551, 38);
            SaleMenuPanel.TabIndex = 10;
            // 
            // SaleFormExit
            // 
            SaleFormExit.BackColor = Color.FromArgb(255, 100, 100);
            SaleFormExit.FlatStyle = FlatStyle.Flat;
            SaleFormExit.Location = new Point(518, -5);
            SaleFormExit.Name = "SaleFormExit";
            SaleFormExit.Size = new Size(41, 51);
            SaleFormExit.TabIndex = 1;
            SaleFormExit.Text = "X";
            SaleFormExit.UseVisualStyleBackColor = false;
            // 
            // SaleFormularLabel
            // 
            SaleFormularLabel.AutoSize = true;
            SaleFormularLabel.Font = new Font("Segoe UI", 12F);
            SaleFormularLabel.Location = new Point(190, 0);
            SaleFormularLabel.Name = "SaleFormularLabel";
            SaleFormularLabel.Size = new Size(171, 32);
            SaleFormularLabel.TabIndex = 0;
            SaleFormularLabel.Text = "Salgs Formular";
            // 
            // SaleDateTextBox
            // 
            SaleDateTextBox.Font = new Font("Segoe UI", 18F);
            SaleDateTextBox.Location = new Point(30, 438);
            SaleDateTextBox.MinimumSize = new Size(0, 58);
            SaleDateTextBox.Name = "SaleDateTextBox";
            SaleDateTextBox.Size = new Size(495, 58);
            SaleDateTextBox.TabIndex = 9;
            // 
            // SalePriceTextBox
            // 
            SalePriceTextBox.Font = new Font("Segoe UI", 18F);
            SalePriceTextBox.Location = new Point(30, 323);
            SalePriceTextBox.MinimumSize = new Size(0, 58);
            SalePriceTextBox.Name = "SalePriceTextBox";
            SalePriceTextBox.Size = new Size(495, 58);
            SalePriceTextBox.TabIndex = 8;
            // 
            // SaleBuyerCPRTextBox
            // 
            SaleBuyerCPRTextBox.Font = new Font("Segoe UI", 18F);
            SaleBuyerCPRTextBox.Location = new Point(30, 208);
            SaleBuyerCPRTextBox.MinimumSize = new Size(0, 58);
            SaleBuyerCPRTextBox.Name = "SaleBuyerCPRTextBox";
            SaleBuyerCPRTextBox.Size = new Size(495, 58);
            SaleBuyerCPRTextBox.TabIndex = 7;
            // 
            // CreateSaleButton
            // 
            CreateSaleButton.BackColor = Color.FromArgb(45, 199, 92);
            CreateSaleButton.Font = new Font("Segoe UI", 16F);
            CreateSaleButton.Location = new Point(329, 519);
            CreateSaleButton.Name = "CreateSaleButton";
            CreateSaleButton.Size = new Size(155, 89);
            CreateSaleButton.TabIndex = 6;
            CreateSaleButton.Text = "Opret";
            CreateSaleButton.UseVisualStyleBackColor = false;
            // 
            // CancelSaleButton
            // 
            CancelSaleButton.BackColor = Color.FromArgb(255, 100, 100);
            CancelSaleButton.Font = new Font("Segoe UI", 16F);
            CancelSaleButton.Location = new Point(64, 518);
            CancelSaleButton.Name = "CancelSaleButton";
            CancelSaleButton.Size = new Size(156, 90);
            CancelSaleButton.TabIndex = 5;
            CancelSaleButton.Text = "Annuller";
            CancelSaleButton.UseVisualStyleBackColor = false;
            // 
            // SaleDateLabel
            // 
            SaleDateLabel.AutoSize = true;
            SaleDateLabel.Font = new Font("Segoe UI", 16F);
            SaleDateLabel.Location = new Point(25, 390);
            SaleDateLabel.Name = "SaleDateLabel";
            SaleDateLabel.Size = new Size(159, 45);
            SaleDateLabel.TabIndex = 4;
            SaleDateLabel.Text = "Salgsdato";
            // 
            // SalePriceLabel
            // 
            SalePriceLabel.AutoSize = true;
            SalePriceLabel.Font = new Font("Segoe UI", 16F);
            SalePriceLabel.Location = new Point(25, 275);
            SalePriceLabel.Name = "SalePriceLabel";
            SalePriceLabel.Size = new Size(274, 45);
            SalePriceLabel.TabIndex = 3;
            SalePriceLabel.Text = "Endelige salgspris";
            // 
            // SaleBuyerCPRLabel
            // 
            SaleBuyerCPRLabel.AutoSize = true;
            SaleBuyerCPRLabel.Font = new Font("Segoe UI", 16F);
            SaleBuyerCPRLabel.Location = new Point(25, 160);
            SaleBuyerCPRLabel.Name = "SaleBuyerCPRLabel";
            SaleBuyerCPRLabel.Size = new Size(324, 45);
            SaleBuyerCPRLabel.TabIndex = 2;
            SaleBuyerCPRLabel.Text = "Købers CPR-Nummer";
            // 
            // SaleNameLabel
            // 
            SaleNameLabel.AutoSize = true;
            SaleNameLabel.Font = new Font("Segoe UI", 22F);
            SaleNameLabel.Location = new Point(25, 56);
            SaleNameLabel.Name = "SaleNameLabel";
            SaleNameLabel.Size = new Size(405, 60);
            SaleNameLabel.TabIndex = 1;
            SaleNameLabel.Text = "Salg af \"Bolig navn\"";
            // 
            // SaleRegistrationForm
            // 
            SaleRegistrationForm.BorderStyle = BorderStyle.FixedSingle;
            SaleRegistrationForm.Location = new Point(-1, 144);
            SaleRegistrationForm.Name = "SaleRegistrationForm";
            SaleRegistrationForm.Size = new Size(551, 496);
            SaleRegistrationForm.TabIndex = 11;
            // 
            // SaleRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(800, 719);
            Controls.Add(SaleFormPanel);
            Name = "SaleRegistration";
            Text = "SaleRegistration";
            SaleFormPanel.ResumeLayout(false);
            SaleFormPanel.PerformLayout();
            SaleMenuPanel.ResumeLayout(false);
            SaleMenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SaleFormPanel;
        private TextBox SaleDateTextBox;
        private TextBox SalePriceTextBox;
        private TextBox SaleBuyerCPRTextBox;
        private Button CreateSaleButton;
        private Button CancelSaleButton;
        private Label SaleDateLabel;
        private Label SalePriceLabel;
        private Label SaleBuyerCPRLabel;
        private Label SaleNameLabel;
        private Label SaleFormularLabel;
        private Panel SaleMenuPanel;
        private Button SaleFormExit;
        private Panel SaleRegistrationForm;
    }
}