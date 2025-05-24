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
            SaleFormPanel.Location = new Point(125, 54);
            SaleFormPanel.Name = "SaleFormPanel";
            SaleFormPanel.Size = new Size(551, 689);
            SaleFormPanel.TabIndex = 0;
            SaleFormPanel.Paint += SaleRegistrationForm_Paint;
            // 
            // SalePriceTextBox
            // 
            SalePriceTextBox.Font = new Font("Segoe UI", 18F);
            SalePriceTextBox.ForeColor = SystemColors.Desktop;
            SalePriceTextBox.Location = new Point(30, 399);
            SalePriceTextBox.MinimumSize = new Size(4, 58);
            SalePriceTextBox.Name = "SalePriceTextBox";
            SalePriceTextBox.Size = new Size(495, 55);
            SalePriceTextBox.TabIndex = 8;
            // 
            // SaleBuyerCPRTextBox
            // 
            SaleBuyerCPRTextBox.Font = new Font("Segoe UI", 18F);
            SaleBuyerCPRTextBox.ForeColor = SystemColors.Desktop;
            SaleBuyerCPRTextBox.Location = new Point(30, 289);
            SaleBuyerCPRTextBox.MinimumSize = new Size(4, 58);
            SaleBuyerCPRTextBox.Name = "SaleBuyerCPRTextBox";
            SaleBuyerCPRTextBox.Size = new Size(495, 55);
            SaleBuyerCPRTextBox.TabIndex = 7;
            // 
            // SaleDateLabel
            // 
            SaleDateLabel.AutoSize = true;
            SaleDateLabel.BackColor = Color.Transparent;
            SaleDateLabel.Font = new Font("Segoe UI", 16F);
            SaleDateLabel.Location = new Point(25, 460);
            SaleDateLabel.Name = "SaleDateLabel";
            SaleDateLabel.Size = new Size(159, 45);
            SaleDateLabel.TabIndex = 4;
            SaleDateLabel.Text = "Salgsdato";
            // 
            // SalePriceLabel
            // 
            SalePriceLabel.AutoSize = true;
            SalePriceLabel.Font = new Font("Segoe UI", 16F);
            SalePriceLabel.Location = new Point(25, 352);
            SalePriceLabel.Name = "SalePriceLabel";
            SalePriceLabel.Size = new Size(274, 45);
            SalePriceLabel.TabIndex = 3;
            SalePriceLabel.Text = "Endelige salgspris";
            // 
            // SaleBuyerCPRLabel
            // 
            SaleBuyerCPRLabel.AutoSize = true;
            SaleBuyerCPRLabel.Font = new Font("Segoe UI", 16F);
            SaleBuyerCPRLabel.Location = new Point(25, 247);
            SaleBuyerCPRLabel.Name = "SaleBuyerCPRLabel";
            SaleBuyerCPRLabel.Size = new Size(324, 45);
            SaleBuyerCPRLabel.TabIndex = 2;
            SaleBuyerCPRLabel.Text = "Købers CPR-Nummer";
            // 
            // SaleNameLabel
            // 
            SaleNameLabel.AutoSize = true;
            SaleNameLabel.Font = new Font("Segoe UI", 16F);
            SaleNameLabel.Location = new Point(151, 16);
            SaleNameLabel.Name = "SaleNameLabel";
            SaleNameLabel.Size = new Size(258, 45);
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
            SaleRegistrationForm.Location = new Point(-1, 64);
            SaleRegistrationForm.Name = "SaleRegistrationForm";
            SaleRegistrationForm.Size = new Size(551, 624);
            SaleRegistrationForm.TabIndex = 11;
            // 
            // SaleSellerCprLabel
            // 
            SaleSellerCprLabel.AutoSize = true;
            SaleSellerCprLabel.Font = new Font("Segoe UI", 16F);
            SaleSellerCprLabel.Location = new Point(27, -1);
            SaleSellerCprLabel.Margin = new Padding(2, 0, 2, 0);
            SaleSellerCprLabel.Name = "SaleSellerCprLabel";
            SaleSellerCprLabel.Size = new Size(338, 45);
            SaleSellerCprLabel.TabIndex = 11;
            SaleSellerCprLabel.Text = "Sælgers CPR-Nummer";
            // 
            // SaleSellerCprTextbox
            // 
            SaleSellerCprTextbox.Font = new Font("Segoe UI", 18F);
            SaleSellerCprTextbox.Location = new Point(33, 44);
            SaleSellerCprTextbox.Margin = new Padding(2, 2, 2, 2);
            SaleSellerCprTextbox.MinimumSize = new Size(4, 87);
            SaleSellerCprTextbox.Name = "SaleSellerCprTextbox";
            SaleSellerCprTextbox.Size = new Size(495, 55);
            SaleSellerCprTextbox.TabIndex = 10;
            SaleSellerCprTextbox.TextChanged += SaleSellerCprTextbox_TextChanged;
            // 
            // SaleAdresseCombobox
            // 
            SaleAdresseCombobox.FormattingEnabled = true;
            SaleAdresseCombobox.Location = new Point(31, 145);
            SaleAdresseCombobox.Margin = new Padding(2, 2, 2, 2);
            SaleAdresseCombobox.Name = "SaleAdresseCombobox";
            SaleAdresseCombobox.Size = new Size(495, 33);
            SaleAdresseCombobox.TabIndex = 9;
            SaleAdresseCombobox.SelectedIndexChanged += SaleAdresseCombobox_SelectedIndexChanged;
            // 
            // SaleAdressLabel
            // 
            SaleAdressLabel.AutoSize = true;
            SaleAdressLabel.Font = new Font("Segoe UI", 16F);
            SaleAdressLabel.Location = new Point(22, 100);
            SaleAdressLabel.Margin = new Padding(2, 0, 2, 0);
            SaleAdressLabel.Name = "SaleAdressLabel";
            SaleAdressLabel.Size = new Size(258, 45);
            SaleAdressLabel.TabIndex = 8;
            SaleAdressLabel.Text = "Boligens adresse";
            SaleAdressLabel.Click += SaleAdressLabel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 444);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.MinimumSize = new Size(4, 87);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(495, 87);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += OpretSolgtBoligDateTImePicker;
            // 
            // CancelSaleButton
            // 
            CancelSaleButton.BackColor = Color.FromArgb(255, 100, 100);
            CancelSaleButton.Font = new Font("Segoe UI", 16F);
            CancelSaleButton.Location = new Point(25, 521);
            CancelSaleButton.Name = "CancelSaleButton";
            CancelSaleButton.Size = new Size(142, 68);
            CancelSaleButton.TabIndex = 5;
            CancelSaleButton.Text = "Annuller";
            CancelSaleButton.UseVisualStyleBackColor = false;
            CancelSaleButton.Click += CancelSaleButton_Click;
            // 
            // CreateSaleButton
            // 
            CreateSaleButton.BackColor = Color.FromArgb(45, 199, 92);
            CreateSaleButton.Font = new Font("Segoe UI", 16F);
            CreateSaleButton.Location = new Point(382, 521);
            CreateSaleButton.Name = "CreateSaleButton";
            CreateSaleButton.Size = new Size(142, 68);
            CreateSaleButton.TabIndex = 6;
            CreateSaleButton.Text = "Opret";
            CreateSaleButton.UseVisualStyleBackColor = false;
            CreateSaleButton.Click += CreateSaleButton_Click;
            // 
            // SaleDateTextBox
            // 
            SaleDateTextBox.Font = new Font("Segoe UI", 18F);
            SaleDateTextBox.Location = new Point(30, 438);
            SaleDateTextBox.MinimumSize = new Size(4, 58);
            SaleDateTextBox.Name = "SaleDateTextBox";
            SaleDateTextBox.Size = new Size(495, 55);
            SaleDateTextBox.TabIndex = 9;
            // 
            // SaleRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(800, 801);
            Controls.Add(SaleFormPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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