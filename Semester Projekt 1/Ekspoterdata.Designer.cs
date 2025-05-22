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
            label3 = new Label();
            dataFlowPanel = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            boligStatus = new ComboBox();
            label2 = new Label();
            selectDataComboBox = new ComboBox();
            boligByNavn = new TextBox();
            label4 = new Label();
            eksporterDataKnap = new Button();
            sortByComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            dataFlowPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 246, 218);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(dataFlowPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(eksporterDataKnap, 0, 3);
            tableLayoutPanel1.Controls.Add(sortByComboBox, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(148, 144);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 61);
            label3.Name = "label3";
            label3.Size = new Size(142, 21);
            label3.TabIndex = 4;
            label3.Text = "Sorter Efter:";
            // 
            // dataFlowPanel
            // 
            dataFlowPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            dataFlowPanel.Controls.Add(tableLayoutPanel2);
            dataFlowPanel.Location = new Point(3, 3);
            dataFlowPanel.Name = "dataFlowPanel";
            dataFlowPanel.Size = new Size(142, 55);
            dataFlowPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(boligStatus, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(selectDataComboBox, 0, 1);
            tableLayoutPanel2.Controls.Add(boligByNavn, 0, 5);
            tableLayoutPanel2.Controls.Add(label4, 0, 4);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(136, 150);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 21);
            label1.TabIndex = 3;
            label1.Text = "Data:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boligStatus
            // 
            boligStatus.FormattingEnabled = true;
            boligStatus.Location = new Point(3, 74);
            boligStatus.Name = "boligStatus";
            boligStatus.Size = new Size(130, 23);
            boligStatus.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 50);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 4;
            label2.Text = "Bolig Status:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // selectDataComboBox
            // 
            selectDataComboBox.FormattingEnabled = true;
            selectDataComboBox.Items.AddRange(new object[] { "Køber", "Sælger", "Salg", "Boliger", "Ejendomsmæglere" });
            selectDataComboBox.Location = new Point(3, 24);
            selectDataComboBox.Name = "selectDataComboBox";
            selectDataComboBox.Size = new Size(130, 23);
            selectDataComboBox.TabIndex = 1;
            selectDataComboBox.SelectedValueChanged += selectDataComboBox_SelectedValueChanged;
            // 
            // boligByNavn
            // 
            boligByNavn.Location = new Point(3, 124);
            boligByNavn.Name = "boligByNavn";
            boligByNavn.Size = new Size(130, 23);
            boligByNavn.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 6;
            label4.Text = "By Navn:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // eksporterDataKnap
            // 
            eksporterDataKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            eksporterDataKnap.AutoSize = true;
            eksporterDataKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eksporterDataKnap.BackColor = Color.FromArgb(45, 199, 92);
            eksporterDataKnap.FlatStyle = FlatStyle.Flat;
            eksporterDataKnap.Location = new Point(3, 114);
            eksporterDataKnap.Name = "eksporterDataKnap";
            eksporterDataKnap.Size = new Size(142, 27);
            eksporterDataKnap.TabIndex = 2;
            eksporterDataKnap.Text = "Eksporter Data";
            eksporterDataKnap.UseVisualStyleBackColor = false;
            eksporterDataKnap.Click += eksporterDataKnap_Click;
            // 
            // sortByComboBox
            // 
            sortByComboBox.Enabled = false;
            sortByComboBox.FormattingEnabled = true;
            sortByComboBox.Location = new Point(3, 85);
            sortByComboBox.Name = "sortByComboBox";
            sortByComboBox.Size = new Size(142, 23);
            sortByComboBox.TabIndex = 1;
            // 
            // Ekspoterdata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(173, 304);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Ekspoterdata";
            Text = "Ekspoterdata";
            Load += Ekspoterdata_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            dataFlowPanel.ResumeLayout(false);
            dataFlowPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel dataFlowPanel;
        private ComboBox sortByComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button eksporterDataKnap;
        private ComboBox boligStatus;
        private ComboBox selectDataComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox boligByNavn;
        private Label label4;
    }
}