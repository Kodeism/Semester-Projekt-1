namespace Semester_Projekt_1
{
    partial class salgSide
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            salgLayoutPanel = new TableLayoutPanel();
            salgMenuLayoutPanel = new TableLayoutPanel();
            eksporterDataKnap = new Button();
            salgRegistrerKnap = new Button();
            salgSøgeFelt = new TextBox();
            salgFilterKnap = new Button();
            salgLabel = new Label();
            salgDataGridView = new DataGridView();
            salgLayoutPanel.SuspendLayout();
            salgMenuLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)salgDataGridView).BeginInit();
            SuspendLayout();
            // 
            // salgLayoutPanel
            // 
            salgLayoutPanel.AutoSize = true;
            salgLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgLayoutPanel.ColumnCount = 1;
            salgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            salgLayoutPanel.Controls.Add(salgMenuLayoutPanel, 0, 1);
            salgLayoutPanel.Controls.Add(salgLabel, 0, 0);
            salgLayoutPanel.Controls.Add(salgDataGridView, 0, 2);
            salgLayoutPanel.Dock = DockStyle.Fill;
            salgLayoutPanel.Location = new Point(0, 0);
            salgLayoutPanel.Margin = new Padding(10);
            salgLayoutPanel.Name = "salgLayoutPanel";
            salgLayoutPanel.RowCount = 3;
            salgLayoutPanel.RowStyles.Add(new RowStyle());
            salgLayoutPanel.RowStyles.Add(new RowStyle());
            salgLayoutPanel.RowStyles.Add(new RowStyle());
            salgLayoutPanel.Size = new Size(689, 663);
            salgLayoutPanel.TabIndex = 0;
            // 
            // salgMenuLayoutPanel
            // 
            salgMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salgMenuLayoutPanel.AutoSize = true;
            salgMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgMenuLayoutPanel.ColumnCount = 4;
            salgMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.02041F));
            salgMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.32653F));
            salgMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.32653F));
            salgMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.32653F));
            salgMenuLayoutPanel.Controls.Add(eksporterDataKnap, 3, 0);
            salgMenuLayoutPanel.Controls.Add(salgRegistrerKnap, 2, 0);
            salgMenuLayoutPanel.Controls.Add(salgSøgeFelt, 0, 0);
            salgMenuLayoutPanel.Controls.Add(salgFilterKnap, 1, 0);
            salgMenuLayoutPanel.Location = new Point(10, 55);
            salgMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            salgMenuLayoutPanel.Name = "salgMenuLayoutPanel";
            salgMenuLayoutPanel.RowCount = 1;
            salgMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            salgMenuLayoutPanel.Size = new Size(669, 34);
            salgMenuLayoutPanel.TabIndex = 3;
            // 
            // eksporterDataKnap
            // 
            eksporterDataKnap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            eksporterDataKnap.AutoSize = true;
            eksporterDataKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            eksporterDataKnap.BackColor = Color.FromArgb(45, 199, 92);
            eksporterDataKnap.FlatStyle = FlatStyle.Popup;
            eksporterDataKnap.Location = new Point(559, 0);
            eksporterDataKnap.Margin = new Padding(0);
            eksporterDataKnap.MaximumSize = new Size(0, 34);
            eksporterDataKnap.MinimumSize = new Size(0, 34);
            eksporterDataKnap.Name = "eksporterDataKnap";
            eksporterDataKnap.Size = new Size(110, 34);
            eksporterDataKnap.TabIndex = 3;
            eksporterDataKnap.Text = "Eksporter";
            eksporterDataKnap.UseVisualStyleBackColor = false;
            // 
            // salgRegistrerKnap
            // 
            salgRegistrerKnap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salgRegistrerKnap.AutoSize = true;
            salgRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            salgRegistrerKnap.FlatStyle = FlatStyle.Popup;
            salgRegistrerKnap.Location = new Point(450, 0);
            salgRegistrerKnap.Margin = new Padding(0);
            salgRegistrerKnap.MaximumSize = new Size(0, 34);
            salgRegistrerKnap.MinimumSize = new Size(0, 34);
            salgRegistrerKnap.Name = "salgRegistrerKnap";
            salgRegistrerKnap.Size = new Size(109, 34);
            salgRegistrerKnap.TabIndex = 2;
            salgRegistrerKnap.Text = "Registrer";
            salgRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // salgSøgeFelt
            // 
            salgSøgeFelt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salgSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            salgSøgeFelt.Font = new Font("Segoe UI", 10F);
            salgSøgeFelt.Location = new Point(0, 0);
            salgSøgeFelt.Margin = new Padding(0);
            salgSøgeFelt.Name = "salgSøgeFelt";
            salgSøgeFelt.Size = new Size(341, 34);
            salgSøgeFelt.TabIndex = 0;
            salgSøgeFelt.Text = "Søg Adresse...";
            // 
            // salgFilterKnap
            // 
            salgFilterKnap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            salgFilterKnap.AutoSize = true;
            salgFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            salgFilterKnap.FlatStyle = FlatStyle.Popup;
            salgFilterKnap.Location = new Point(341, 0);
            salgFilterKnap.Margin = new Padding(0);
            salgFilterKnap.MaximumSize = new Size(0, 34);
            salgFilterKnap.MinimumSize = new Size(0, 34);
            salgFilterKnap.Name = "salgFilterKnap";
            salgFilterKnap.Size = new Size(109, 34);
            salgFilterKnap.TabIndex = 1;
            salgFilterKnap.Text = "Filtrer";
            salgFilterKnap.UseVisualStyleBackColor = false;
            // 
            // salgLabel
            // 
            salgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salgLabel.Font = new Font("Segoe UI", 20F);
            salgLabel.Location = new Point(10, 0);
            salgLabel.Margin = new Padding(10, 0, 10, 0);
            salgLabel.Name = "salgLabel";
            salgLabel.Size = new Size(669, 55);
            salgLabel.TabIndex = 1;
            salgLabel.Text = "Alle Salg";
            salgLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // salgDataGridView
            // 
            salgDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salgDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            salgDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            salgDataGridView.Location = new Point(10, 89);
            salgDataGridView.Margin = new Padding(10, 0, 10, 5);
            salgDataGridView.Name = "salgDataGridView";
            salgDataGridView.RowHeadersWidth = 62;
            salgDataGridView.Size = new Size(669, 571);
            salgDataGridView.TabIndex = 2;
            // 
            // salgSide
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 218);
            Controls.Add(salgLayoutPanel);
            Name = "salgSide";
            Size = new Size(689, 663);
            salgLayoutPanel.ResumeLayout(false);
            salgLayoutPanel.PerformLayout();
            salgMenuLayoutPanel.ResumeLayout(false);
            salgMenuLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)salgDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel salgLayoutPanel;
        private Label salgLabel;
        private DataGridView salgDataGridView;
        private TableLayoutPanel salgMenuLayoutPanel;
        private Button salgRegistrerKnap;
        private TextBox salgSøgeFelt;
        private Button salgFilterKnap;
        private Button eksporterDataKnap;
    }
}
