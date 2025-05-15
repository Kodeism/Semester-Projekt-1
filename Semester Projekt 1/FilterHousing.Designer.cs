namespace Semester_Projekt_1
{
    partial class FilterHousing
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
            FilterFormPanel = new Panel();
            FilterFormLabel = new Label();
            FilterEnergyLabelComboBox = new ComboBox();
            FilterHousingTypeComboBox = new ComboBox();
            FilterRoomCountMaxComboBox = new ComboBox();
            FilterRoomCountMinComboBox = new ComboBox();
            FilterHousingAreaLabel = new Label();
            FilterRoomCountLabel = new Label();
            FilterBuiltDateLabel = new Label();
            FilterPlotAreaLabel = new Label();
            FilterEnergyLabelLabel = new Label();
            FilterHousingTypeLabel = new Label();
            FilterPriceLabel = new Label();
            FilterRealtorLabel = new Label();
            FilterSellerLabel = new Label();
            FilterBuyerLabel = new Label();
            FilterCityLabel = new Label();
            FilterAddressLabel = new Label();
            FilterFormButton = new Button();
            FilterPlotAreaMaxTextBox = new TextBox();
            FilterPlotAreaMinTextBox = new TextBox();
            FilterHousingAreaMaxTextBox = new TextBox();
            FilterHousingAreaMinTextBox = new TextBox();
            FilterPriceMaxTextBox = new TextBox();
            FilterBuyerTextBox = new TextBox();
            FilterRealtorTextBox = new TextBox();
            FilterBuiltDateTextBox = new TextBox();
            FilterCityTextBox = new TextBox();
            FilterSellerTextBox = new TextBox();
            FilterPriceMinTextbox = new TextBox();
            FilterAddressTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            FilterFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // FilterFormPanel
            // 
            FilterFormPanel.BackColor = Color.FromArgb(255, 246, 218);
            FilterFormPanel.BorderStyle = BorderStyle.FixedSingle;
            FilterFormPanel.Controls.Add(FilterFormLabel);
            FilterFormPanel.Controls.Add(FilterEnergyLabelComboBox);
            FilterFormPanel.Controls.Add(FilterHousingTypeComboBox);
            FilterFormPanel.Controls.Add(FilterRoomCountMaxComboBox);
            FilterFormPanel.Controls.Add(FilterRoomCountMinComboBox);
            FilterFormPanel.Controls.Add(FilterHousingAreaLabel);
            FilterFormPanel.Controls.Add(FilterRoomCountLabel);
            FilterFormPanel.Controls.Add(FilterBuiltDateLabel);
            FilterFormPanel.Controls.Add(FilterPlotAreaLabel);
            FilterFormPanel.Controls.Add(FilterEnergyLabelLabel);
            FilterFormPanel.Controls.Add(FilterHousingTypeLabel);
            FilterFormPanel.Controls.Add(FilterPriceLabel);
            FilterFormPanel.Controls.Add(FilterRealtorLabel);
            FilterFormPanel.Controls.Add(FilterSellerLabel);
            FilterFormPanel.Controls.Add(FilterBuyerLabel);
            FilterFormPanel.Controls.Add(FilterCityLabel);
            FilterFormPanel.Controls.Add(FilterAddressLabel);
            FilterFormPanel.Controls.Add(FilterFormButton);
            FilterFormPanel.Controls.Add(FilterPlotAreaMaxTextBox);
            FilterFormPanel.Controls.Add(FilterPlotAreaMinTextBox);
            FilterFormPanel.Controls.Add(FilterHousingAreaMaxTextBox);
            FilterFormPanel.Controls.Add(FilterHousingAreaMinTextBox);
            FilterFormPanel.Controls.Add(FilterPriceMaxTextBox);
            FilterFormPanel.Controls.Add(FilterBuyerTextBox);
            FilterFormPanel.Controls.Add(FilterRealtorTextBox);
            FilterFormPanel.Controls.Add(FilterBuiltDateTextBox);
            FilterFormPanel.Controls.Add(FilterCityTextBox);
            FilterFormPanel.Controls.Add(FilterSellerTextBox);
            FilterFormPanel.Controls.Add(FilterPriceMinTextbox);
            FilterFormPanel.Controls.Add(FilterAddressTextBox);
            FilterFormPanel.Location = new Point(50, 26);
            FilterFormPanel.Name = "FilterFormPanel";
            FilterFormPanel.Size = new Size(725, 753);
            FilterFormPanel.TabIndex = 0;
            // 
            // FilterFormLabel
            // 
            FilterFormLabel.AutoSize = true;
            FilterFormLabel.Font = new Font("Segoe UI", 20F);
            FilterFormLabel.Location = new Point(236, 12);
            FilterFormLabel.Name = "FilterFormLabel";
            FilterFormLabel.Size = new Size(258, 54);
            FilterFormLabel.TabIndex = 44;
            FilterFormLabel.Text = "Filter af bolig";
            // 
            // FilterEnergyLabelComboBox
            // 
            FilterEnergyLabelComboBox.FormattingEnabled = true;
            FilterEnergyLabelComboBox.Items.AddRange(new object[] { "A2020", "A2015", "A", "B", "C", "D", "E", "F", "G" });
            FilterEnergyLabelComboBox.Location = new Point(68, 486);
            FilterEnergyLabelComboBox.Name = "FilterEnergyLabelComboBox";
            FilterEnergyLabelComboBox.Size = new Size(253, 33);
            FilterEnergyLabelComboBox.TabIndex = 43;
            // 
            // FilterHousingTypeComboBox
            // 
            FilterHousingTypeComboBox.FormattingEnabled = true;
            FilterHousingTypeComboBox.Items.AddRange(new object[] { "Villa", "Lejlighed", "Rækkehus", "Andelsbolig", "Ejerlejlighed", "Sommerhus", "Ungdomsbolig", "Ældrebolig", "Kolonihavehus" });
            FilterHousingTypeComboBox.Location = new Point(68, 395);
            FilterHousingTypeComboBox.Name = "FilterHousingTypeComboBox";
            FilterHousingTypeComboBox.Size = new Size(253, 33);
            FilterHousingTypeComboBox.TabIndex = 42;
            // 
            // FilterRoomCountMaxComboBox
            // 
            FilterRoomCountMaxComboBox.FormattingEnabled = true;
            FilterRoomCountMaxComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9+" });
            FilterRoomCountMaxComboBox.Location = new Point(529, 577);
            FilterRoomCountMaxComboBox.Name = "FilterRoomCountMaxComboBox";
            FilterRoomCountMaxComboBox.Size = new Size(126, 33);
            FilterRoomCountMaxComboBox.TabIndex = 41;
            // 
            // FilterRoomCountMinComboBox
            // 
            FilterRoomCountMinComboBox.FormattingEnabled = true;
            FilterRoomCountMinComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9+" });
            FilterRoomCountMinComboBox.Location = new Point(402, 577);
            FilterRoomCountMinComboBox.Name = "FilterRoomCountMinComboBox";
            FilterRoomCountMinComboBox.Size = new Size(126, 33);
            FilterRoomCountMinComboBox.TabIndex = 40;
            // 
            // FilterHousingAreaLabel
            // 
            FilterHousingAreaLabel.AutoSize = true;
            FilterHousingAreaLabel.Font = new Font("Segoe UI", 10F);
            FilterHousingAreaLabel.Location = new Point(402, 367);
            FilterHousingAreaLabel.Name = "FilterHousingAreaLabel";
            FilterHousingAreaLabel.Size = new Size(107, 28);
            FilterHousingAreaLabel.TabIndex = 39;
            FilterHousingAreaLabel.Text = "Bolig Areal";
            // 
            // FilterRoomCountLabel
            // 
            FilterRoomCountLabel.AutoSize = true;
            FilterRoomCountLabel.Font = new Font("Segoe UI", 10F);
            FilterRoomCountLabel.Location = new Point(402, 549);
            FilterRoomCountLabel.Name = "FilterRoomCountLabel";
            FilterRoomCountLabel.Size = new Size(103, 28);
            FilterRoomCountLabel.TabIndex = 38;
            FilterRoomCountLabel.Text = "Antal Rum";
            // 
            // FilterBuiltDateLabel
            // 
            FilterBuiltDateLabel.AutoSize = true;
            FilterBuiltDateLabel.Font = new Font("Segoe UI", 10F);
            FilterBuiltDateLabel.Location = new Point(68, 549);
            FilterBuiltDateLabel.Name = "FilterBuiltDateLabel";
            FilterBuiltDateLabel.Size = new Size(115, 28);
            FilterBuiltDateLabel.TabIndex = 37;
            FilterBuiltDateLabel.Text = "Bygge Dato";
            // 
            // FilterPlotAreaLabel
            // 
            FilterPlotAreaLabel.AutoSize = true;
            FilterPlotAreaLabel.Font = new Font("Segoe UI", 10F);
            FilterPlotAreaLabel.Location = new Point(402, 458);
            FilterPlotAreaLabel.Name = "FilterPlotAreaLabel";
            FilterPlotAreaLabel.Size = new Size(117, 28);
            FilterPlotAreaLabel.TabIndex = 35;
            FilterPlotAreaLabel.Text = "Grund Areal";
            // 
            // FilterEnergyLabelLabel
            // 
            FilterEnergyLabelLabel.AutoSize = true;
            FilterEnergyLabelLabel.Font = new Font("Segoe UI", 10F);
            FilterEnergyLabelLabel.Location = new Point(68, 458);
            FilterEnergyLabelLabel.Name = "FilterEnergyLabelLabel";
            FilterEnergyLabelLabel.Size = new Size(128, 28);
            FilterEnergyLabelLabel.TabIndex = 34;
            FilterEnergyLabelLabel.Text = "Energimærke";
            // 
            // FilterHousingTypeLabel
            // 
            FilterHousingTypeLabel.AutoSize = true;
            FilterHousingTypeLabel.Font = new Font("Segoe UI", 10F);
            FilterHousingTypeLabel.Location = new Point(68, 367);
            FilterHousingTypeLabel.Name = "FilterHousingTypeLabel";
            FilterHousingTypeLabel.Size = new Size(103, 28);
            FilterHousingTypeLabel.TabIndex = 31;
            FilterHousingTypeLabel.Text = "Bolig Type";
            // 
            // FilterPriceLabel
            // 
            FilterPriceLabel.AutoSize = true;
            FilterPriceLabel.Font = new Font("Segoe UI", 10F);
            FilterPriceLabel.Location = new Point(402, 276);
            FilterPriceLabel.Name = "FilterPriceLabel";
            FilterPriceLabel.Size = new Size(43, 28);
            FilterPriceLabel.TabIndex = 29;
            FilterPriceLabel.Text = "Pris";
            // 
            // FilterRealtorLabel
            // 
            FilterRealtorLabel.AutoSize = true;
            FilterRealtorLabel.Font = new Font("Segoe UI", 10F);
            FilterRealtorLabel.Location = new Point(68, 276);
            FilterRealtorLabel.Name = "FilterRealtorLabel";
            FilterRealtorLabel.Size = new Size(165, 28);
            FilterRealtorLabel.TabIndex = 28;
            FilterRealtorLabel.Text = "Ejendomsmægler";
            // 
            // FilterSellerLabel
            // 
            FilterSellerLabel.AutoSize = true;
            FilterSellerLabel.Font = new Font("Segoe UI", 10F);
            FilterSellerLabel.Location = new Point(402, 185);
            FilterSellerLabel.Name = "FilterSellerLabel";
            FilterSellerLabel.Size = new Size(74, 28);
            FilterSellerLabel.TabIndex = 27;
            FilterSellerLabel.Text = "Sælger";
            // 
            // FilterBuyerLabel
            // 
            FilterBuyerLabel.AutoSize = true;
            FilterBuyerLabel.Font = new Font("Segoe UI", 10F);
            FilterBuyerLabel.Location = new Point(68, 185);
            FilterBuyerLabel.Name = "FilterBuyerLabel";
            FilterBuyerLabel.Size = new Size(65, 28);
            FilterBuyerLabel.TabIndex = 26;
            FilterBuyerLabel.Text = "Køber";
            // 
            // FilterCityLabel
            // 
            FilterCityLabel.AutoSize = true;
            FilterCityLabel.Font = new Font("Segoe UI", 10F);
            FilterCityLabel.Location = new Point(402, 94);
            FilterCityLabel.Name = "FilterCityLabel";
            FilterCityLabel.Size = new Size(33, 28);
            FilterCityLabel.TabIndex = 25;
            FilterCityLabel.Text = "By";
            // 
            // FilterAddressLabel
            // 
            FilterAddressLabel.AutoSize = true;
            FilterAddressLabel.Font = new Font("Segoe UI", 10F);
            FilterAddressLabel.Location = new Point(68, 94);
            FilterAddressLabel.Name = "FilterAddressLabel";
            FilterAddressLabel.Size = new Size(80, 28);
            FilterAddressLabel.TabIndex = 24;
            FilterAddressLabel.Text = "Adresse";
            // 
            // FilterFormButton
            // 
            FilterFormButton.BackColor = Color.FromArgb(208, 227, 255);
            FilterFormButton.Font = new Font("Segoe UI", 18F);
            FilterFormButton.Location = new Point(68, 667);
            FilterFormButton.Name = "FilterFormButton";
            FilterFormButton.Size = new Size(587, 56);
            FilterFormButton.TabIndex = 23;
            FilterFormButton.Text = "Anvend filter";
            FilterFormButton.UseVisualStyleBackColor = false;
            FilterFormButton.Click += FilterFormButton_Click;
            // 
            // FilterPlotAreaMaxTextBox
            // 
            FilterPlotAreaMaxTextBox.Location = new Point(529, 486);
            FilterPlotAreaMaxTextBox.MinimumSize = new Size(0, 45);
            FilterPlotAreaMaxTextBox.Name = "FilterPlotAreaMaxTextBox";
            FilterPlotAreaMaxTextBox.Size = new Size(126, 45);
            FilterPlotAreaMaxTextBox.TabIndex = 20;
            // 
            // FilterPlotAreaMinTextBox
            // 
            FilterPlotAreaMinTextBox.Location = new Point(402, 486);
            FilterPlotAreaMinTextBox.MinimumSize = new Size(0, 45);
            FilterPlotAreaMinTextBox.Name = "FilterPlotAreaMinTextBox";
            FilterPlotAreaMinTextBox.Size = new Size(126, 45);
            FilterPlotAreaMinTextBox.TabIndex = 19;
            // 
            // FilterHousingAreaMaxTextBox
            // 
            FilterHousingAreaMaxTextBox.Location = new Point(529, 395);
            FilterHousingAreaMaxTextBox.MinimumSize = new Size(0, 45);
            FilterHousingAreaMaxTextBox.Name = "FilterHousingAreaMaxTextBox";
            FilterHousingAreaMaxTextBox.Size = new Size(126, 45);
            FilterHousingAreaMaxTextBox.TabIndex = 18;
            // 
            // FilterHousingAreaMinTextBox
            // 
            FilterHousingAreaMinTextBox.Location = new Point(402, 395);
            FilterHousingAreaMinTextBox.MinimumSize = new Size(0, 45);
            FilterHousingAreaMinTextBox.Name = "FilterHousingAreaMinTextBox";
            FilterHousingAreaMinTextBox.Size = new Size(126, 45);
            FilterHousingAreaMinTextBox.TabIndex = 17;
            // 
            // FilterPriceMaxTextBox
            // 
            FilterPriceMaxTextBox.Location = new Point(529, 304);
            FilterPriceMaxTextBox.MinimumSize = new Size(0, 45);
            FilterPriceMaxTextBox.Name = "FilterPriceMaxTextBox";
            FilterPriceMaxTextBox.Size = new Size(126, 45);
            FilterPriceMaxTextBox.TabIndex = 16;
            // 
            // FilterBuyerTextBox
            // 
            FilterBuyerTextBox.Location = new Point(68, 213);
            FilterBuyerTextBox.MinimumSize = new Size(0, 45);
            FilterBuyerTextBox.Name = "FilterBuyerTextBox";
            FilterBuyerTextBox.Size = new Size(253, 45);
            FilterBuyerTextBox.TabIndex = 15;
            // 
            // FilterRealtorTextBox
            // 
            FilterRealtorTextBox.Location = new Point(68, 304);
            FilterRealtorTextBox.MinimumSize = new Size(0, 45);
            FilterRealtorTextBox.Name = "FilterRealtorTextBox";
            FilterRealtorTextBox.Size = new Size(253, 45);
            FilterRealtorTextBox.TabIndex = 14;
            // 
            // FilterBuiltDateTextBox
            // 
            FilterBuiltDateTextBox.Location = new Point(68, 577);
            FilterBuiltDateTextBox.MinimumSize = new Size(0, 45);
            FilterBuiltDateTextBox.Name = "FilterBuiltDateTextBox";
            FilterBuiltDateTextBox.Size = new Size(253, 45);
            FilterBuiltDateTextBox.TabIndex = 11;
            // 
            // FilterCityTextBox
            // 
            FilterCityTextBox.Location = new Point(402, 122);
            FilterCityTextBox.MinimumSize = new Size(0, 45);
            FilterCityTextBox.Name = "FilterCityTextBox";
            FilterCityTextBox.Size = new Size(253, 45);
            FilterCityTextBox.TabIndex = 10;
            // 
            // FilterSellerTextBox
            // 
            FilterSellerTextBox.Location = new Point(402, 213);
            FilterSellerTextBox.MinimumSize = new Size(0, 45);
            FilterSellerTextBox.Name = "FilterSellerTextBox";
            FilterSellerTextBox.Size = new Size(253, 45);
            FilterSellerTextBox.TabIndex = 9;
            // 
            // FilterPriceMinTextbox
            // 
            FilterPriceMinTextbox.Location = new Point(402, 304);
            FilterPriceMinTextbox.MinimumSize = new Size(0, 45);
            FilterPriceMinTextbox.Name = "FilterPriceMinTextbox";
            FilterPriceMinTextbox.Size = new Size(126, 45);
            FilterPriceMinTextbox.TabIndex = 8;
            // 
            // FilterAddressTextBox
            // 
            FilterAddressTextBox.Location = new Point(68, 122);
            FilterAddressTextBox.MinimumSize = new Size(0, 45);
            FilterAddressTextBox.Name = "FilterAddressTextBox";
            FilterAddressTextBox.Size = new Size(253, 45);
            FilterAddressTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(853, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 40;
            dataGridView1.Size = new Size(570, 644);
            dataGridView1.TabIndex = 1;
            // 
            // FilterHousing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(1507, 814);
            Controls.Add(dataGridView1);
            Controls.Add(FilterFormPanel);
            Name = "FilterHousing";
            Text = "Filter";
            FilterFormPanel.ResumeLayout(false);
            FilterFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel FilterFormPanel;
        private TextBox FilterBuyerTextBox;
        private TextBox FilterRealtorTextBox;
        private TextBox FilterBuiltDateTextBox;
        private TextBox FilterCityTextBox;
        private TextBox FilterSellerTextBox;
        private TextBox FilterAddressTextBox;
        private Button FilterFormButton;
        private Label FilterRoomCountLabel;
        private Label FilterBuiltDateLabel;
        private Label FilterPlotAreaLabel;
        private Label FilterEnergyLabelLabel;
        private Label FilterHousingTypeLabel;
        private Label FilterPriceLabel;
        private Label FilterRealtorLabel;
        private Label FilterSellerLabel;
        private Label FilterBuyerLabel;
        private Label FilterCityLabel;
        private Label FilterAddressLabel;
        private Label FilterHousingAreaLabel;
        private TextBox FilterPlotAreaMaxTextBox;
        private TextBox FilterPlotAreaMinTextBox;
        private TextBox FilterHousingAreaMaxTextBox;
        private TextBox FilterHousingAreaMinTextBox;
        private TextBox FilterPriceMaxTextBox;
        private TextBox FilterPriceMinTextbox;
        private ComboBox FilterEnergyLabelComboBox;
        private ComboBox FilterHousingTypeComboBox;
        private ComboBox FilterRoomCountMaxComboBox;
        private ComboBox FilterRoomCountMinComboBox;
        private Label FilterFormLabel;
        private DataGridView dataGridView1;
    }
}