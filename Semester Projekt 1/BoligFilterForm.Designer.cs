namespace Semester_Projekt_1
{
    partial class BoligFilterForm
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
            FilterBuiltDateMax = new Label();
            FilterBuiltDateMin = new Label();
            FilterBuiltDateTimePickerMax = new DateTimePicker();
            FilterBuiltDateTimePickerMin = new DateTimePicker();
            FilterStatusComboBox = new ComboBox();
            label1 = new Label();
            FilterPostNummerLabel = new Label();
            FilterHousingTypeComboBox = new ComboBox();
            FilterHousingTypeLabel = new Label();
            FilterPostnummerTextBox = new TextBox();
            FilterEnergyLabelComboBox = new ComboBox();
            FilterFormLabel = new Label();
            FilterEnergyLabelLabel = new Label();
            FilterHousingAreaLabel = new Label();
            FilterRoomCountLabel = new Label();
            FilterBuiltDateLabel = new Label();
            FilterRoomCountMaxComboBox = new ComboBox();
            FilterPlotAreaLabel = new Label();
            FilterRoomCountMinComboBox = new ComboBox();
            FilterPriceLabel = new Label();
            FilterRealtorLabel = new Label();
            FilterSellerLabel = new Label();
            FilterCityLabel = new Label();
            FilterAddressLabel = new Label();
            FilterFormButton = new Button();
            FilterPlotAreaMaxTextBox = new TextBox();
            FilterPlotAreaMinTextBox = new TextBox();
            FilterHousingAreaMaxTextBox = new TextBox();
            FilterHousingAreaMinTextBox = new TextBox();
            FilterPriceMaxTextBox = new TextBox();
            FilterRealtorTextBox = new TextBox();
            FilterCityTextBox = new TextBox();
            FilterSellerTextBox = new TextBox();
            FilterPriceMinTextbox = new TextBox();
            FilterAddressTextBox = new TextBox();
            FilterFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FilterFormPanel
            // 
            FilterFormPanel.BackColor = Color.FromArgb(255, 246, 218);
            FilterFormPanel.BorderStyle = BorderStyle.FixedSingle;
            FilterFormPanel.Controls.Add(FilterBuiltDateMax);
            FilterFormPanel.Controls.Add(FilterBuiltDateMin);
            FilterFormPanel.Controls.Add(FilterBuiltDateTimePickerMax);
            FilterFormPanel.Controls.Add(FilterBuiltDateTimePickerMin);
            FilterFormPanel.Controls.Add(FilterStatusComboBox);
            FilterFormPanel.Controls.Add(label1);
            FilterFormPanel.Controls.Add(FilterPostNummerLabel);
            FilterFormPanel.Controls.Add(FilterHousingTypeComboBox);
            FilterFormPanel.Controls.Add(FilterHousingTypeLabel);
            FilterFormPanel.Controls.Add(FilterPostnummerTextBox);
            FilterFormPanel.Controls.Add(FilterEnergyLabelComboBox);
            FilterFormPanel.Controls.Add(FilterFormLabel);
            FilterFormPanel.Controls.Add(FilterEnergyLabelLabel);
            FilterFormPanel.Controls.Add(FilterHousingAreaLabel);
            FilterFormPanel.Controls.Add(FilterRoomCountLabel);
            FilterFormPanel.Controls.Add(FilterBuiltDateLabel);
            FilterFormPanel.Controls.Add(FilterRoomCountMaxComboBox);
            FilterFormPanel.Controls.Add(FilterPlotAreaLabel);
            FilterFormPanel.Controls.Add(FilterRoomCountMinComboBox);
            FilterFormPanel.Controls.Add(FilterPriceLabel);
            FilterFormPanel.Controls.Add(FilterRealtorLabel);
            FilterFormPanel.Controls.Add(FilterSellerLabel);
            FilterFormPanel.Controls.Add(FilterCityLabel);
            FilterFormPanel.Controls.Add(FilterAddressLabel);
            FilterFormPanel.Controls.Add(FilterFormButton);
            FilterFormPanel.Controls.Add(FilterPlotAreaMaxTextBox);
            FilterFormPanel.Controls.Add(FilterPlotAreaMinTextBox);
            FilterFormPanel.Controls.Add(FilterHousingAreaMaxTextBox);
            FilterFormPanel.Controls.Add(FilterHousingAreaMinTextBox);
            FilterFormPanel.Controls.Add(FilterPriceMaxTextBox);
            FilterFormPanel.Controls.Add(FilterRealtorTextBox);
            FilterFormPanel.Controls.Add(FilterCityTextBox);
            FilterFormPanel.Controls.Add(FilterSellerTextBox);
            FilterFormPanel.Controls.Add(FilterPriceMinTextbox);
            FilterFormPanel.Controls.Add(FilterAddressTextBox);
            FilterFormPanel.Location = new Point(46, 32);
            FilterFormPanel.Name = "FilterFormPanel";
            FilterFormPanel.Size = new Size(733, 790);
            FilterFormPanel.TabIndex = 0;
            // 
            // FilterBuiltDateMax
            // 
            FilterBuiltDateMax.AutoSize = true;
            FilterBuiltDateMax.Location = new Point(627, 504);
            FilterBuiltDateMax.Name = "FilterBuiltDateMax";
            FilterBuiltDateMax.Size = new Size(29, 25);
            FilterBuiltDateMax.TabIndex = 53;
            FilterBuiltDateMax.Text = "Til";
            // 
            // FilterBuiltDateMin
            // 
            FilterBuiltDateMin.AutoSize = true;
            FilterBuiltDateMin.Location = new Point(379, 504);
            FilterBuiltDateMin.Name = "FilterBuiltDateMin";
            FilterBuiltDateMin.Size = new Size(36, 25);
            FilterBuiltDateMin.TabIndex = 52;
            FilterBuiltDateMin.Text = "Fra";
            // 
            // FilterBuiltDateTimePickerMax
            // 
            FilterBuiltDateTimePickerMax.Format = DateTimePickerFormat.Short;
            FilterBuiltDateTimePickerMax.Location = new Point(519, 473);
            FilterBuiltDateTimePickerMax.Name = "FilterBuiltDateTimePickerMax";
            FilterBuiltDateTimePickerMax.Size = new Size(138, 31);
            FilterBuiltDateTimePickerMax.TabIndex = 51;
            // 
            // FilterBuiltDateTimePickerMin
            // 
            FilterBuiltDateTimePickerMin.Format = DateTimePickerFormat.Short;
            FilterBuiltDateTimePickerMin.Location = new Point(379, 473);
            FilterBuiltDateTimePickerMin.Name = "FilterBuiltDateTimePickerMin";
            FilterBuiltDateTimePickerMin.Size = new Size(140, 31);
            FilterBuiltDateTimePickerMin.TabIndex = 50;
            FilterBuiltDateTimePickerMin.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // FilterStatusComboBox
            // 
            FilterStatusComboBox.Font = new Font("Segoe UI", 13F);
            FilterStatusComboBox.FormattingEnabled = true;
            FilterStatusComboBox.Items.AddRange(new object[] { "Til Salg", "Solgt" });
            FilterStatusComboBox.Location = new Point(381, 605);
            FilterStatusComboBox.Name = "FilterStatusComboBox";
            FilterStatusComboBox.Size = new Size(274, 44);
            FilterStatusComboBox.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(379, 575);
            label1.Name = "label1";
            label1.Size = new Size(65, 28);
            label1.TabIndex = 48;
            label1.Text = "Status";
            // 
            // FilterPostNummerLabel
            // 
            FilterPostNummerLabel.AutoSize = true;
            FilterPostNummerLabel.Font = new Font("Segoe UI", 10F);
            FilterPostNummerLabel.Location = new Point(594, 82);
            FilterPostNummerLabel.Name = "FilterPostNummerLabel";
            FilterPostNummerLabel.Size = new Size(122, 28);
            FilterPostNummerLabel.TabIndex = 46;
            FilterPostNummerLabel.Text = "Postnummer";
            // 
            // FilterHousingTypeComboBox
            // 
            FilterHousingTypeComboBox.Font = new Font("Segoe UI", 13F);
            FilterHousingTypeComboBox.FormattingEnabled = true;
            FilterHousingTypeComboBox.Items.AddRange(new object[] { "Villa", "Lejlighed", "Rækkehus", "Andelsbolig", "Ejerlejlighed", "Sommerhus", "Ungdomsbolig", "Ældrebolig", "Kolonihavehus" });
            FilterHousingTypeComboBox.Location = new Point(381, 202);
            FilterHousingTypeComboBox.Name = "FilterHousingTypeComboBox";
            FilterHousingTypeComboBox.Size = new Size(274, 44);
            FilterHousingTypeComboBox.TabIndex = 42;
            // 
            // FilterHousingTypeLabel
            // 
            FilterHousingTypeLabel.AutoSize = true;
            FilterHousingTypeLabel.Font = new Font("Segoe UI", 10F);
            FilterHousingTypeLabel.Location = new Point(381, 170);
            FilterHousingTypeLabel.Name = "FilterHousingTypeLabel";
            FilterHousingTypeLabel.Size = new Size(103, 28);
            FilterHousingTypeLabel.TabIndex = 31;
            FilterHousingTypeLabel.Text = "Bolig Type";
            // 
            // FilterPostnummerTextBox
            // 
            FilterPostnummerTextBox.Location = new Point(594, 112);
            FilterPostnummerTextBox.MinimumSize = new Size(4, 45);
            FilterPostnummerTextBox.Name = "FilterPostnummerTextBox";
            FilterPostnummerTextBox.Size = new Size(61, 45);
            FilterPostnummerTextBox.TabIndex = 45;
            // 
            // FilterEnergyLabelComboBox
            // 
            FilterEnergyLabelComboBox.Font = new Font("Segoe UI", 13F);
            FilterEnergyLabelComboBox.FormattingEnabled = true;
            FilterEnergyLabelComboBox.Items.AddRange(new object[] { "A2020", "A2015", "A", "B", "C", "D", "E", "F", "G" });
            FilterEnergyLabelComboBox.Location = new Point(381, 292);
            FilterEnergyLabelComboBox.Name = "FilterEnergyLabelComboBox";
            FilterEnergyLabelComboBox.Size = new Size(274, 44);
            FilterEnergyLabelComboBox.TabIndex = 43;
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
            // FilterEnergyLabelLabel
            // 
            FilterEnergyLabelLabel.AutoSize = true;
            FilterEnergyLabelLabel.Font = new Font("Segoe UI", 10F);
            FilterEnergyLabelLabel.Location = new Point(381, 260);
            FilterEnergyLabelLabel.Name = "FilterEnergyLabelLabel";
            FilterEnergyLabelLabel.Size = new Size(128, 28);
            FilterEnergyLabelLabel.TabIndex = 34;
            FilterEnergyLabelLabel.Text = "Energimærke";
            // 
            // FilterHousingAreaLabel
            // 
            FilterHousingAreaLabel.AutoSize = true;
            FilterHousingAreaLabel.Font = new Font("Segoe UI", 10F);
            FilterHousingAreaLabel.Location = new Point(73, 262);
            FilterHousingAreaLabel.Name = "FilterHousingAreaLabel";
            FilterHousingAreaLabel.Size = new Size(107, 28);
            FilterHousingAreaLabel.TabIndex = 39;
            FilterHousingAreaLabel.Text = "Bolig Areal";
            // 
            // FilterRoomCountLabel
            // 
            FilterRoomCountLabel.AutoSize = true;
            FilterRoomCountLabel.Font = new Font("Segoe UI", 10F);
            FilterRoomCountLabel.Location = new Point(381, 342);
            FilterRoomCountLabel.Name = "FilterRoomCountLabel";
            FilterRoomCountLabel.Size = new Size(103, 28);
            FilterRoomCountLabel.TabIndex = 38;
            FilterRoomCountLabel.Text = "Antal Rum";
            // 
            // FilterBuiltDateLabel
            // 
            FilterBuiltDateLabel.AutoSize = true;
            FilterBuiltDateLabel.Font = new Font("Segoe UI", 10F);
            FilterBuiltDateLabel.Location = new Point(379, 442);
            FilterBuiltDateLabel.Name = "FilterBuiltDateLabel";
            FilterBuiltDateLabel.Size = new Size(115, 28);
            FilterBuiltDateLabel.TabIndex = 37;
            FilterBuiltDateLabel.Text = "Bygge Dato";
            // 
            // FilterRoomCountMaxComboBox
            // 
            FilterRoomCountMaxComboBox.Font = new Font("Segoe UI", 13F);
            FilterRoomCountMaxComboBox.FormattingEnabled = true;
            FilterRoomCountMaxComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9+" });
            FilterRoomCountMaxComboBox.Location = new Point(519, 373);
            FilterRoomCountMaxComboBox.Name = "FilterRoomCountMaxComboBox";
            FilterRoomCountMaxComboBox.Size = new Size(137, 44);
            FilterRoomCountMaxComboBox.TabIndex = 41;
            // 
            // FilterPlotAreaLabel
            // 
            FilterPlotAreaLabel.AutoSize = true;
            FilterPlotAreaLabel.Font = new Font("Segoe UI", 10F);
            FilterPlotAreaLabel.Location = new Point(73, 352);
            FilterPlotAreaLabel.Name = "FilterPlotAreaLabel";
            FilterPlotAreaLabel.Size = new Size(117, 28);
            FilterPlotAreaLabel.TabIndex = 35;
            FilterPlotAreaLabel.Text = "Grund Areal";
            // 
            // FilterRoomCountMinComboBox
            // 
            FilterRoomCountMinComboBox.Font = new Font("Segoe UI", 13F);
            FilterRoomCountMinComboBox.FormattingEnabled = true;
            FilterRoomCountMinComboBox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9+" });
            FilterRoomCountMinComboBox.Location = new Point(381, 373);
            FilterRoomCountMinComboBox.Name = "FilterRoomCountMinComboBox";
            FilterRoomCountMinComboBox.Size = new Size(138, 44);
            FilterRoomCountMinComboBox.TabIndex = 40;
            // 
            // FilterPriceLabel
            // 
            FilterPriceLabel.AutoSize = true;
            FilterPriceLabel.Font = new Font("Segoe UI", 10F);
            FilterPriceLabel.Location = new Point(73, 172);
            FilterPriceLabel.Name = "FilterPriceLabel";
            FilterPriceLabel.Size = new Size(43, 28);
            FilterPriceLabel.TabIndex = 29;
            FilterPriceLabel.Text = "Pris";
            // 
            // FilterRealtorLabel
            // 
            FilterRealtorLabel.AutoSize = true;
            FilterRealtorLabel.Font = new Font("Segoe UI", 10F);
            FilterRealtorLabel.Location = new Point(73, 575);
            FilterRealtorLabel.Name = "FilterRealtorLabel";
            FilterRealtorLabel.Size = new Size(165, 28);
            FilterRealtorLabel.TabIndex = 28;
            FilterRealtorLabel.Text = "Ejendomsmægler";
            // 
            // FilterSellerLabel
            // 
            FilterSellerLabel.AutoSize = true;
            FilterSellerLabel.Font = new Font("Segoe UI", 10F);
            FilterSellerLabel.Location = new Point(73, 442);
            FilterSellerLabel.Name = "FilterSellerLabel";
            FilterSellerLabel.Size = new Size(74, 28);
            FilterSellerLabel.TabIndex = 27;
            FilterSellerLabel.Text = "Sælger";
            // 
            // FilterCityLabel
            // 
            FilterCityLabel.AutoSize = true;
            FilterCityLabel.Font = new Font("Segoe UI", 10F);
            FilterCityLabel.Location = new Point(381, 82);
            FilterCityLabel.Name = "FilterCityLabel";
            FilterCityLabel.Size = new Size(33, 28);
            FilterCityLabel.TabIndex = 25;
            FilterCityLabel.Text = "By";
            // 
            // FilterAddressLabel
            // 
            FilterAddressLabel.AutoSize = true;
            FilterAddressLabel.Font = new Font("Segoe UI", 10F);
            FilterAddressLabel.Location = new Point(73, 82);
            FilterAddressLabel.Name = "FilterAddressLabel";
            FilterAddressLabel.Size = new Size(80, 28);
            FilterAddressLabel.TabIndex = 24;
            FilterAddressLabel.Text = "Adresse";
            // 
            // FilterFormButton
            // 
            FilterFormButton.BackColor = Color.FromArgb(208, 227, 255);
            FilterFormButton.Font = new Font("Segoe UI", 18F);
            FilterFormButton.Location = new Point(68, 693);
            FilterFormButton.Name = "FilterFormButton";
            FilterFormButton.Size = new Size(587, 57);
            FilterFormButton.TabIndex = 23;
            FilterFormButton.Text = "Anvend filter";
            FilterFormButton.UseVisualStyleBackColor = false;
            FilterFormButton.Click += FilterFormButton_Click;
            // 
            // FilterPlotAreaMaxTextBox
            // 
            FilterPlotAreaMaxTextBox.Location = new Point(209, 382);
            FilterPlotAreaMaxTextBox.MinimumSize = new Size(4, 45);
            FilterPlotAreaMaxTextBox.Name = "FilterPlotAreaMaxTextBox";
            FilterPlotAreaMaxTextBox.Size = new Size(138, 45);
            FilterPlotAreaMaxTextBox.TabIndex = 20;
            // 
            // FilterPlotAreaMinTextBox
            // 
            FilterPlotAreaMinTextBox.Location = new Point(73, 382);
            FilterPlotAreaMinTextBox.MinimumSize = new Size(4, 45);
            FilterPlotAreaMinTextBox.Name = "FilterPlotAreaMinTextBox";
            FilterPlotAreaMinTextBox.Size = new Size(135, 45);
            FilterPlotAreaMinTextBox.TabIndex = 19;
            // 
            // FilterHousingAreaMaxTextBox
            // 
            FilterHousingAreaMaxTextBox.Location = new Point(209, 292);
            FilterHousingAreaMaxTextBox.MinimumSize = new Size(4, 45);
            FilterHousingAreaMaxTextBox.Name = "FilterHousingAreaMaxTextBox";
            FilterHousingAreaMaxTextBox.Size = new Size(138, 45);
            FilterHousingAreaMaxTextBox.TabIndex = 18;
            // 
            // FilterHousingAreaMinTextBox
            // 
            FilterHousingAreaMinTextBox.Location = new Point(73, 292);
            FilterHousingAreaMinTextBox.MinimumSize = new Size(4, 45);
            FilterHousingAreaMinTextBox.Name = "FilterHousingAreaMinTextBox";
            FilterHousingAreaMinTextBox.Size = new Size(135, 45);
            FilterHousingAreaMinTextBox.TabIndex = 17;
            // 
            // FilterPriceMaxTextBox
            // 
            FilterPriceMaxTextBox.Location = new Point(209, 202);
            FilterPriceMaxTextBox.MinimumSize = new Size(4, 45);
            FilterPriceMaxTextBox.Name = "FilterPriceMaxTextBox";
            FilterPriceMaxTextBox.Size = new Size(138, 45);
            FilterPriceMaxTextBox.TabIndex = 16;
            // 
            // FilterRealtorTextBox
            // 
            FilterRealtorTextBox.Location = new Point(73, 605);
            FilterRealtorTextBox.MinimumSize = new Size(4, 45);
            FilterRealtorTextBox.Name = "FilterRealtorTextBox";
            FilterRealtorTextBox.Size = new Size(274, 45);
            FilterRealtorTextBox.TabIndex = 14;
            // 
            // FilterCityTextBox
            // 
            FilterCityTextBox.Location = new Point(381, 112);
            FilterCityTextBox.MinimumSize = new Size(4, 45);
            FilterCityTextBox.Name = "FilterCityTextBox";
            FilterCityTextBox.Size = new Size(213, 45);
            FilterCityTextBox.TabIndex = 10;
            // 
            // FilterSellerTextBox
            // 
            FilterSellerTextBox.Location = new Point(73, 472);
            FilterSellerTextBox.MinimumSize = new Size(4, 45);
            FilterSellerTextBox.Name = "FilterSellerTextBox";
            FilterSellerTextBox.Size = new Size(274, 45);
            FilterSellerTextBox.TabIndex = 9;
            // 
            // FilterPriceMinTextbox
            // 
            FilterPriceMinTextbox.Location = new Point(73, 202);
            FilterPriceMinTextbox.MinimumSize = new Size(4, 45);
            FilterPriceMinTextbox.Name = "FilterPriceMinTextbox";
            FilterPriceMinTextbox.Size = new Size(135, 45);
            FilterPriceMinTextbox.TabIndex = 8;
            // 
            // FilterAddressTextBox
            // 
            FilterAddressTextBox.Location = new Point(73, 112);
            FilterAddressTextBox.MinimumSize = new Size(4, 45);
            FilterAddressTextBox.Name = "FilterAddressTextBox";
            FilterAddressTextBox.Size = new Size(274, 45);
            FilterAddressTextBox.TabIndex = 0;
            // 
            // BoligFilterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(826, 852);
            Controls.Add(FilterFormPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BoligFilterForm";
            Text = "Filter";
            FilterFormPanel.ResumeLayout(false);
            FilterFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel FilterFormPanel;
        private TextBox FilterRealtorTextBox;
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
        private Label FilterPostNummerLabel;
        private TextBox FilterPostnummerTextBox;
        private Label label1;
        private ComboBox FilterStatusComboBox;
        private DateTimePicker FilterBuiltDateTimePickerMax;
        private DateTimePicker FilterBuiltDateTimePickerMin;
        private Label FilterBuiltDateMax;
        private Label FilterBuiltDateMin;
    }
}