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
            SalePriceTextBox = new TextBox();
            SaleBuyerCPRTextBox = new TextBox();
            SaleDateLabel = new Label();
            SalePriceLabel = new Label();
            SaleBuyerCPRLabel = new Label();
            SaleNameLabel = new Label();
            SaleSellerCprLabel = new Label();
            SaleSellerCprTextbox = new TextBox();
            SaleAdresseCombobox = new ComboBox();
            SaleAdressLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            CancelSaleButton = new Button();
            CreateSaleButton = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // SalePriceTextBox
            // 
            SalePriceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalePriceTextBox.Font = new Font("Segoe UI", 18F);
            SalePriceTextBox.ForeColor = SystemColors.Desktop;
            SalePriceTextBox.Location = new Point(3, 361);
            SalePriceTextBox.Margin = new Padding(3, 3, 10, 3);
            SalePriceTextBox.Name = "SalePriceTextBox";
            SalePriceTextBox.Size = new Size(558, 55);
            SalePriceTextBox.TabIndex = 8;
            // 
            // SaleBuyerCPRTextBox
            // 
            SaleBuyerCPRTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleBuyerCPRTextBox.Font = new Font("Segoe UI", 18F);
            SaleBuyerCPRTextBox.ForeColor = SystemColors.Desktop;
            SaleBuyerCPRTextBox.Location = new Point(3, 262);
            SaleBuyerCPRTextBox.Margin = new Padding(3, 3, 10, 3);
            SaleBuyerCPRTextBox.Name = "SaleBuyerCPRTextBox";
            SaleBuyerCPRTextBox.Size = new Size(558, 55);
            SaleBuyerCPRTextBox.TabIndex = 7;
            // 
            // SaleDateLabel
            // 
            SaleDateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleDateLabel.AutoSize = true;
            SaleDateLabel.BackColor = Color.Transparent;
            SaleDateLabel.Font = new Font("Segoe UI", 14F);
            SaleDateLabel.Location = new Point(3, 419);
            SaleDateLabel.Name = "SaleDateLabel";
            SaleDateLabel.Size = new Size(565, 38);
            SaleDateLabel.TabIndex = 4;
            SaleDateLabel.Text = "Salgsdato";
            // 
            // SalePriceLabel
            // 
            SalePriceLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SalePriceLabel.AutoSize = true;
            SalePriceLabel.Font = new Font("Segoe UI", 14F);
            SalePriceLabel.Location = new Point(3, 320);
            SalePriceLabel.Name = "SalePriceLabel";
            SalePriceLabel.Size = new Size(565, 38);
            SalePriceLabel.TabIndex = 3;
            SalePriceLabel.Text = "Endelige salgspris";
            // 
            // SaleBuyerCPRLabel
            // 
            SaleBuyerCPRLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleBuyerCPRLabel.AutoSize = true;
            SaleBuyerCPRLabel.Font = new Font("Segoe UI", 14F);
            SaleBuyerCPRLabel.Location = new Point(3, 221);
            SaleBuyerCPRLabel.Name = "SaleBuyerCPRLabel";
            SaleBuyerCPRLabel.Size = new Size(565, 38);
            SaleBuyerCPRLabel.TabIndex = 2;
            SaleBuyerCPRLabel.Text = "Købers CPR-Nummer";
            // 
            // SaleNameLabel
            // 
            SaleNameLabel.Anchor = AnchorStyles.None;
            SaleNameLabel.AutoSize = true;
            SaleNameLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            SaleNameLabel.Location = new Point(148, 0);
            SaleNameLabel.Name = "SaleNameLabel";
            SaleNameLabel.Size = new Size(274, 45);
            SaleNameLabel.TabIndex = 1;
            SaleNameLabel.Text = "Salgsregistrering";
            // 
            // SaleSellerCprLabel
            // 
            SaleSellerCprLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleSellerCprLabel.AutoSize = true;
            SaleSellerCprLabel.Font = new Font("Segoe UI", 14F);
            SaleSellerCprLabel.Location = new Point(2, 45);
            SaleSellerCprLabel.Margin = new Padding(2, 0, 2, 0);
            SaleSellerCprLabel.Name = "SaleSellerCprLabel";
            SaleSellerCprLabel.Size = new Size(567, 38);
            SaleSellerCprLabel.TabIndex = 11;
            SaleSellerCprLabel.Text = "Sælgers CPR-Nummer";
            // 
            // SaleSellerCprTextbox
            // 
            SaleSellerCprTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleSellerCprTextbox.Font = new Font("Segoe UI", 18F);
            SaleSellerCprTextbox.Location = new Point(3, 86);
            SaleSellerCprTextbox.Margin = new Padding(3, 3, 10, 3);
            SaleSellerCprTextbox.Name = "SaleSellerCprTextbox";
            SaleSellerCprTextbox.Size = new Size(558, 55);
            SaleSellerCprTextbox.TabIndex = 10;
            SaleSellerCprTextbox.TextChanged += SaleSellerCprTextbox_TextChanged;
            // 
            // SaleAdresseCombobox
            // 
            SaleAdresseCombobox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleAdresseCombobox.FormattingEnabled = true;
            SaleAdresseCombobox.Location = new Point(3, 185);
            SaleAdresseCombobox.Margin = new Padding(3, 3, 10, 3);
            SaleAdresseCombobox.Name = "SaleAdresseCombobox";
            SaleAdresseCombobox.Size = new Size(558, 33);
            SaleAdresseCombobox.TabIndex = 9;
            SaleAdresseCombobox.SelectedIndexChanged += SaleAdresseCombobox_SelectedIndexChanged;
            // 
            // SaleAdressLabel
            // 
            SaleAdressLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SaleAdressLabel.AutoSize = true;
            SaleAdressLabel.Font = new Font("Segoe UI", 14F);
            SaleAdressLabel.Location = new Point(2, 144);
            SaleAdressLabel.Margin = new Padding(2, 0, 2, 0);
            SaleAdressLabel.Name = "SaleAdressLabel";
            SaleAdressLabel.Size = new Size(567, 38);
            SaleAdressLabel.TabIndex = 8;
            SaleAdressLabel.Text = "Boligens adresse";
            SaleAdressLabel.TextAlign = ContentAlignment.MiddleLeft;
            SaleAdressLabel.Click += SaleAdressLabel_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Fill;
            dateTimePicker1.Location = new Point(3, 460);
            dateTimePicker1.Margin = new Padding(3, 3, 10, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(558, 31);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += OpretSolgtBoligDateTImePicker;
            // 
            // CancelSaleButton
            // 
            CancelSaleButton.Anchor = AnchorStyles.None;
            CancelSaleButton.AutoSize = true;
            CancelSaleButton.BackColor = Color.FromArgb(255, 100, 100);
            CancelSaleButton.Font = new Font("Segoe UI", 16F);
            CancelSaleButton.Location = new Point(66, 3);
            CancelSaleButton.Name = "CancelSaleButton";
            CancelSaleButton.Size = new Size(149, 68);
            CancelSaleButton.TabIndex = 5;
            CancelSaleButton.Text = "Annuller";
            CancelSaleButton.UseVisualStyleBackColor = false;
            CancelSaleButton.Click += CancelSaleButton_Click;
            // 
            // CreateSaleButton
            // 
            CreateSaleButton.Anchor = AnchorStyles.None;
            CreateSaleButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateSaleButton.BackColor = Color.FromArgb(45, 199, 92);
            CreateSaleButton.Font = new Font("Segoe UI", 16F);
            CreateSaleButton.Location = new Point(352, 3);
            CreateSaleButton.Name = "CreateSaleButton";
            CreateSaleButton.Size = new Size(142, 68);
            CreateSaleButton.TabIndex = 6;
            CreateSaleButton.Text = "Opret";
            CreateSaleButton.UseVisualStyleBackColor = false;
            CreateSaleButton.Click += CreateSaleButton_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 246, 218);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 11);
            tableLayoutPanel1.Controls.Add(SaleDateLabel, 0, 9);
            tableLayoutPanel1.Controls.Add(SalePriceTextBox, 0, 8);
            tableLayoutPanel1.Controls.Add(SaleBuyerCPRTextBox, 0, 6);
            tableLayoutPanel1.Controls.Add(SaleSellerCprLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(SalePriceLabel, 0, 7);
            tableLayoutPanel1.Controls.Add(SaleNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(SaleBuyerCPRLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(SaleSellerCprTextbox, 0, 2);
            tableLayoutPanel1.Controls.Add(SaleAdressLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(SaleAdresseCombobox, 0, 4);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 0, 10);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(571, 574);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CancelSaleButton, 0, 0);
            tableLayoutPanel2.Controls.Add(CreateSaleButton, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 497);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(565, 74);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // SaleRegistration
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(597, 597);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaleRegistration";
            Text = "SaleRegistration";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox SalePriceTextBox;
        private TextBox SaleBuyerCPRTextBox;
        private Button CreateSaleButton;
        private Button CancelSaleButton;
        private Label SaleDateLabel;
        private Label SalePriceLabel;
        private Label SaleBuyerCPRLabel;
        private Label SaleNameLabel;
        private DateTimePicker dateTimePicker1;
        private Label SaleAdressLabel;
        private ComboBox SaleAdresseCombobox;
        private TextBox SaleSellerCprTextbox;
        private Label SaleSellerCprLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}