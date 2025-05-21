namespace Semester_Projekt_1
{
    partial class Ekspoterdata
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            selectDataComboBox = new ComboBox();
            checkIncludeData = new CheckedListBox();
            sortByComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(sortByComboBox, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(141, 384);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(selectDataComboBox);
            flowLayoutPanel1.Controls.Add(checkIncludeData);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(135, 349);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // selectDataComboBox
            // 
            selectDataComboBox.FormattingEnabled = true;
            selectDataComboBox.Items.AddRange(new object[] { "Køber", "Sælger", "Salg", "Boliger", "Ejendomsmæglere" });
            selectDataComboBox.Location = new Point(3, 3);
            selectDataComboBox.Name = "selectDataComboBox";
            selectDataComboBox.Size = new Size(130, 23);
            selectDataComboBox.TabIndex = 1;
            selectDataComboBox.SelectedValueChanged += selectDataComboBox_SelectedValueChanged;
            // 
            // checkIncludeData
            // 
            checkIncludeData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkIncludeData.FormattingEnabled = true;
            checkIncludeData.Items.AddRange(new object[] { "Pris", "Adresse", "Postnummer", "ByNavn", "BoligType", "BoligAreal", "Værelser", "ByggeDato", "GrundStørrelse", "EnergiMærke", "EjendomsmæglerID", "SælgerID", "Status" });
            checkIncludeData.Location = new Point(3, 32);
            checkIncludeData.Name = "checkIncludeData";
            checkIncludeData.Size = new Size(130, 238);
            checkIncludeData.TabIndex = 1;
            // 
            // sortByComboBox
            // 
            sortByComboBox.Enabled = false;
            sortByComboBox.FormattingEnabled = true;
            sortByComboBox.Location = new Point(3, 358);
            sortByComboBox.Name = "sortByComboBox";
            sortByComboBox.Size = new Size(135, 23);
            sortByComboBox.TabIndex = 1;
            // 
            // Ekspoterdata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Ekspoterdata";
            Text = "Ekspoterdata";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckedListBox checkIncludeData;
        private ComboBox selectDataComboBox;
        private ComboBox sortByComboBox;
    }
}