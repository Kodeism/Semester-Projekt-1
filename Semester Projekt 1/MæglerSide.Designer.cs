namespace Semester_Projekt_1
{
    partial class MæglerSide
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
            mæglerLayoutPanel = new TableLayoutPanel();
            mæglerMenuLayoutPanel = new TableLayoutPanel();
            mæglerSøgeFelt = new TextBox();
            mæglerFilterKnap = new Button();
            mæglerLabel = new Label();
            mæglerDataGridView = new DataGridView();
            mæglerLayoutPanel.SuspendLayout();
            mæglerMenuLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mæglerDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mæglerLayoutPanel
            // 
            mæglerLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            mæglerLayoutPanel.ColumnCount = 1;
            mæglerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mæglerLayoutPanel.Controls.Add(mæglerMenuLayoutPanel, 0, 1);
            mæglerLayoutPanel.Controls.Add(mæglerLabel, 0, 0);
            mæglerLayoutPanel.Controls.Add(mæglerDataGridView, 0, 2);
            mæglerLayoutPanel.Dock = DockStyle.Fill;
            mæglerLayoutPanel.Location = new Point(0, 0);
            mæglerLayoutPanel.Margin = new Padding(0);
            mæglerLayoutPanel.Name = "mæglerLayoutPanel";
            mæglerLayoutPanel.RowCount = 3;
            mæglerLayoutPanel.RowStyles.Add(new RowStyle());
            mæglerLayoutPanel.RowStyles.Add(new RowStyle());
            mæglerLayoutPanel.RowStyles.Add(new RowStyle());
            mæglerLayoutPanel.Size = new Size(689, 663);
            mæglerLayoutPanel.TabIndex = 1;
            // 
            // mæglerMenuLayoutPanel
            // 
            mæglerMenuLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerMenuLayoutPanel.AutoSize = true;
            mæglerMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerMenuLayoutPanel.ColumnCount = 2;
            mæglerMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            mæglerMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            mæglerMenuLayoutPanel.Controls.Add(mæglerSøgeFelt, 0, 0);
            mæglerMenuLayoutPanel.Controls.Add(mæglerFilterKnap, 1, 0);
            mæglerMenuLayoutPanel.Location = new Point(10, 54);
            mæglerMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            mæglerMenuLayoutPanel.Name = "mæglerMenuLayoutPanel";
            mæglerMenuLayoutPanel.RowCount = 1;
            mæglerMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mæglerMenuLayoutPanel.Size = new Size(669, 35);
            mæglerMenuLayoutPanel.TabIndex = 3;
            // 
            // mæglerSøgeFelt
            // 
            mæglerSøgeFelt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            mæglerSøgeFelt.Font = new Font("Segoe UI", 10F);
            mæglerSøgeFelt.Location = new Point(0, 0);
            mæglerSøgeFelt.Margin = new Padding(0);
            mæglerSøgeFelt.Name = "mæglerSøgeFelt";
            mæglerSøgeFelt.Size = new Size(501, 34);
            mæglerSøgeFelt.TabIndex = 0;
            // 
            // mæglerFilterKnap
            // 
            mæglerFilterKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerFilterKnap.AutoSize = true;
            mæglerFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            mæglerFilterKnap.FlatStyle = FlatStyle.Popup;
            mæglerFilterKnap.Location = new Point(501, 0);
            mæglerFilterKnap.Margin = new Padding(0);
            mæglerFilterKnap.Name = "mæglerFilterKnap";
            mæglerFilterKnap.Size = new Size(168, 35);
            mæglerFilterKnap.TabIndex = 1;
            mæglerFilterKnap.Text = "Filtrer";
            mæglerFilterKnap.UseVisualStyleBackColor = false;
            // 
            // mæglerLabel
            // 
            mæglerLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerLabel.AutoSize = true;
            mæglerLabel.Font = new Font("Segoe UI", 20F);
            mæglerLabel.Location = new Point(0, 0);
            mæglerLabel.Margin = new Padding(0);
            mæglerLabel.Name = "mæglerLabel";
            mæglerLabel.Size = new Size(689, 54);
            mæglerLabel.TabIndex = 1;
            mæglerLabel.Text = "Mæglere";
            mæglerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // mæglerDataGridView
            // 
            mæglerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mæglerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mæglerDataGridView.Location = new Point(10, 89);
            mæglerDataGridView.Margin = new Padding(10, 0, 10, 5);
            mæglerDataGridView.Name = "mæglerDataGridView";
            mæglerDataGridView.ReadOnly = true;
            mæglerDataGridView.RowHeadersWidth = 62;
            mæglerDataGridView.Size = new Size(669, 572);
            mæglerDataGridView.TabIndex = 2;
            // 
            // MæglerSide
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(mæglerLayoutPanel);
            Name = "MæglerSide";
            Size = new Size(689, 663);
            mæglerLayoutPanel.ResumeLayout(false);
            mæglerLayoutPanel.PerformLayout();
            mæglerMenuLayoutPanel.ResumeLayout(false);
            mæglerMenuLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mæglerDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mæglerLayoutPanel;
        private TableLayoutPanel mæglerMenuLayoutPanel;
        private Button eksporterDataKnap;
        private Button salgRegistrerKnap;
        private TextBox mæglerSøgeFelt;
        private Button mæglerFilterKnap;
        private Label mæglerLabel;
        private DataGridView mæglerDataGridView;
    }
}
