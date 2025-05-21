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
            SalePriceTextBox = new TextBox();
            SaleBuyerCPRTextBox = new TextBox();
            SaleDateLabel = new Label();
            SalePriceLabel = new Label();
            SaleBuyerCPRLabel = new Label();
            SaleNameLabel = new Label();
            SaleRegistrationForm = new Panel();
            SaleSellerCprLabel = new Label();
            SaleSellerCprTextbox = new TextBox();
            SaleAdresseCombobox = new ComboBox();
            SaleAdressLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            CancelSaleButton = new Button();
            CreateSaleButton = new Button();
            SaleDateTextBox = new TextBox();
            SaleFormPanel.SuspendLayout();
            SaleRegistrationForm.SuspendLayout();
            SuspendLayout();
            // 
            // SaleFormPanel
            // 
            SaleFormPanel.BackColor = Color.FromArgb(255, 246, 218);
            SaleFormPanel.BorderStyle = BorderStyle.FixedSingle;
            SaleFormPanel.Controls.Add(SalePriceTextBox);
            SaleFormPanel.Controls.Add(SaleBuyerCPRTextBox);
            SaleFormPanel.Controls.Add(SaleDateLabel);
            SaleFormPanel.Controls.Add(SalePriceLabel);
            SaleFormPanel.Controls.Add(SaleBuyerCPRLabel);
            SaleFormPanel.Controls.Add(SaleNameLabel);
            SaleFormPanel.Controls.Add(SaleRegistrationForm);
            SaleFormPanel.Controls.Add(SaleDateTextBox);
            SaleFormPanel.Location = new Point(212, 88);
            SaleFormPanel.Margin = new Padding(5);
            SaleFormPanel.Name = "SaleFormPanel";
            SaleFormPanel.Size = new Size(935, 1128);
            SaleFormPanel.TabIndex = 0;
            SaleFormPanel.Paint += SaleRegistrationForm_Paint;
            // 
            // SalePriceTextBox
            // 
            SalePriceTextBox.Font = new Font("Segoe UI", 18F);
            SalePriceTextBox.ForeColor = SystemColors.Desktop;
            SalePriceTextBox.Location = new Point(51, 655);
            SalePriceTextBox.Margin = new Padding(5);
            SalePriceTextBox.MinimumSize = new Size(4, 58);
            SalePriceTextBox.Name = "SalePriceTextBox";
            SalePriceTextBox.Size = new Size(839, 87);
            SalePriceTextBox.TabIndex = 8;
            // 
            // SaleBuyerCPRTextBox
            // 
            SaleBuyerCPRTextBox.Font = new Font("Segoe UI", 18F);
            SaleBuyerCPRTextBox.ForeColor = SystemColors.Desktop;
            SaleBuyerCPRTextBox.Location = new Point(51, 474);
            SaleBuyerCPRTextBox.Margin = new Padding(5);
            SaleBuyerCPRTextBox.MinimumSize = new Size(4, 58);
            SaleBuyerCPRTextBox.Name = "SaleBuyerCPRTextBox";
            SaleBuyerCPRTextBox.Size = new Size(839, 87);
            SaleBuyerCPRTextBox.TabIndex = 7;
            // 
            // SaleDateLabel
            // 
            SaleDateLabel.AutoSize = true;
            SaleDateLabel.BackColor = Color.Transparent;
            SaleDateLabel.Font = new Font("Segoe UI", 16F);
            SaleDateLabel.Location = new Point(42, 754);
            SaleDateLabel.Margin = new Padding(5, 0, 5, 0);
            SaleDateLabel.Name = "SaleDateLabel";
            SaleDateLabel.Size = new Size(263, 72);
            SaleDateLabel.TabIndex = 4;
            SaleDateLabel.Text = "Salgsdato";
            // 
            // SalePriceLabel
            // 
            SalePriceLabel.AutoSize = true;
            SalePriceLabel.Font = new Font("Segoe UI", 16F);
            SalePriceLabel.Location = new Point(42, 577);
            SalePriceLabel.Margin = new Padding(5, 0, 5, 0);
            SalePriceLabel.Name = "SalePriceLabel";
            SalePriceLabel.Size = new Size(454, 72);
            SalePriceLabel.TabIndex = 3;
            SalePriceLabel.Text = "Endelige salgspris";
            // 
            // SaleBuyerCPRLabel
            // 
            SaleBuyerCPRLabel.AutoSize = true;
            SaleBuyerCPRLabel.Font = new Font("Segoe UI", 16F);
            SaleBuyerCPRLabel.Location = new Point(42, 405);
            SaleBuyerCPRLabel.Margin = new Padding(5, 0, 5, 0);
            SaleBuyerCPRLabel.Name = "SaleBuyerCPRLabel";
            SaleBuyerCPRLabel.Size = new Size(539, 72);
            SaleBuyerCPRLabel.TabIndex = 2;
            SaleBuyerCPRLabel.Text = "Købers CPR-Nummer";
            // 
            // SaleNameLabel
            // 
            SaleNameLabel.AutoSize = true;
            SaleNameLabel.Font = new Font("Segoe UI", 16F);
            SaleNameLabel.Location = new Point(256, 26);
            SaleNameLabel.Margin = new Padding(5, 0, 5, 0);
            SaleNameLabel.Name = "SaleNameLabel";
            SaleNameLabel.Size = new Size(429, 72);
            SaleNameLabel.TabIndex = 1;
            SaleNameLabel.Text = "Salgsregistrering";
            // 
            // SaleRegistrationForm
            // 
            SaleRegistrationForm.BorderStyle = BorderStyle.FixedSingle;
            SaleRegistrationForm.Controls.Add(SaleSellerCprLabel);
            SaleRegistrationForm.Controls.Add(SaleSellerCprTextbox);
            SaleRegistrationForm.Controls.Add(SaleAdresseCombobox);
            SaleRegistrationForm.Controls.Add(SaleAdressLabel);
            SaleRegistrationForm.Controls.Add(dateTimePicker1);
            SaleRegistrationForm.Controls.Add(CancelSaleButton);
            SaleRegistrationForm.Controls.Add(CreateSaleButton);
            SaleRegistrationForm.Location = new Point(-2, 103);
            SaleRegistrationForm.Margin = new Padding(5);
            SaleRegistrationForm.Name = "SaleRegistrationForm";
            SaleRegistrationForm.Size = new Size(935, 1023);
            SaleRegistrationForm.TabIndex = 11;
            // 
            // SaleSellerCprLabel
            // 
            SaleSellerCprLabel.AutoSize = true;
            SaleSellerCprLabel.Font = new Font("Segoe UI", 16F);
            SaleSellerCprLabel.Location = new Point(46, -1);
            SaleSellerCprLabel.Name = "SaleSellerCprLabel";
            SaleSellerCprLabel.Size = new Size(563, 72);
            SaleSellerCprLabel.TabIndex = 11;
            SaleSellerCprLabel.Text = "Sælgers CPR-Nummer";
            // 
            // SaleSellerCprTextbox
            // 
            SaleSellerCprTextbox.Font = new Font("Segoe UI", 18F);
            SaleSellerCprTextbox.Location = new Point(56, 72);
            SaleSellerCprTextbox.MinimumSize = new Size(0, 87);
            SaleSellerCprTextbox.Name = "SaleSellerCprTextbox";
            SaleSellerCprTextbox.Size = new Size(839, 87);
            SaleSellerCprTextbox.TabIndex = 10;
            SaleSellerCprTextbox.TextChanged += SaleSellerCprTextbox_TextChanged;
            // 
            // SaleAdresseCombobox
            // 
            SaleAdresseCombobox.FormattingEnabled = true;
            SaleAdresseCombobox.Location = new Point(52, 238);
            SaleAdresseCombobox.Name = "SaleAdresseCombobox";
            SaleAdresseCombobox.Size = new Size(839, 49);
            SaleAdresseCombobox.TabIndex = 9;
            SaleAdresseCombobox.SelectedIndexChanged += SaleAdresseCombobox_SelectedIndexChanged;
            // 
            // SaleAdressLabel
            // 
            SaleAdressLabel.AutoSize = true;
            SaleAdressLabel.Font = new Font("Segoe UI", 16F);
            SaleAdressLabel.Location = new Point(38, 164);
            SaleAdressLabel.Name = "SaleAdressLabel";
            SaleAdressLabel.Size = new Size(428, 72);
            SaleAdressLabel.TabIndex = 8;
            SaleAdressLabel.Text = "Boligens adresse";
            SaleAdressLabel.Click += SaleAdressLabel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(52, 728);
            dateTimePicker1.MinimumSize = new Size(0, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(839, 87);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += OpretSolgtBoligDateTImePicker;
            // 
            // CancelSaleButton
            // 
            CancelSaleButton.BackColor = Color.FromArgb(255, 100, 100);
            CancelSaleButton.Font = new Font("Segoe UI", 16F);
            CancelSaleButton.Location = new Point(43, 854);
            CancelSaleButton.Margin = new Padding(5);
            CancelSaleButton.Name = "CancelSaleButton";
            CancelSaleButton.Size = new Size(242, 112);
            CancelSaleButton.TabIndex = 5;
            CancelSaleButton.Text = "Annuller";
            CancelSaleButton.UseVisualStyleBackColor = false;
            CancelSaleButton.Click += CancelSaleButton_Click;
            // 
            // CreateSaleButton
            // 
            CreateSaleButton.BackColor = Color.FromArgb(45, 199, 92);
            CreateSaleButton.Font = new Font("Segoe UI", 16F);
            CreateSaleButton.Location = new Point(649, 854);
            CreateSaleButton.Margin = new Padding(5);
            CreateSaleButton.Name = "CreateSaleButton";
            CreateSaleButton.Size = new Size(242, 112);
            CreateSaleButton.TabIndex = 6;
            CreateSaleButton.Text = "Opret";
            CreateSaleButton.UseVisualStyleBackColor = false;
            CreateSaleButton.Click += CreateSaleButton_Click;
            // 
            // SaleDateTextBox
            // 
            SaleDateTextBox.Font = new Font("Segoe UI", 18F);
            SaleDateTextBox.Location = new Point(51, 718);
            SaleDateTextBox.Margin = new Padding(5);
            SaleDateTextBox.MinimumSize = new Size(4, 58);
            SaleDateTextBox.Name = "SaleDateTextBox";
            SaleDateTextBox.Size = new Size(839, 87);
            SaleDateTextBox.TabIndex = 9;
            // 
            // SaleRegistration
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(1360, 1293);
            Controls.Add(SaleFormPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5);
            MaximizeBox = false;
            Name = "SaleRegistration";
            Text = "SaleRegistration";
            SaleFormPanel.ResumeLayout(false);
            SaleFormPanel.PerformLayout();
            SaleRegistrationForm.ResumeLayout(false);
            SaleRegistrationForm.PerformLayout();
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
        private Panel SaleRegistrationForm;
        private DateTimePicker dateTimePicker1;
        private Label SaleAdressLabel;
        private ComboBox SaleAdresseCombobox;
        private TextBox SaleSellerCprTextbox;
        private Label SaleSellerCprLabel;
    }
}