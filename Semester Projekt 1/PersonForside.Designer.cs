namespace Semester_Projekt_1
{
    partial class PersonForside
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
            personLayoutPanel = new TableLayoutPanel();
            mæglerLayoutPanel = new TableLayoutPanel();
            mæglerDataGrid = new DataGridView();
            mæglerMenuLayoutPanel = new TableLayoutPanel();
            mæglerSøgeFelt = new TextBox();
            mæglerFilterKnap = new Button();
            mæglerLabel = new Label();
            købereSalgLayoutPanel = new TableLayoutPanel();
            købereDataGridView = new DataGridView();
            købereMenuLayoutPanel = new TableLayoutPanel();
            købereRegistrerKnap = new Button();
            købereSøgeFelt = new TextBox();
            købereFilterKnap = new Button();
            købereLabel = new Label();
            sælgereLayoutPanel = new TableLayoutPanel();
            sælgereLabel = new Label();
            sælgereDataGridView = new DataGridView();
            sælgereMenuLayoutPanel = new TableLayoutPanel();
            sælgereRegistrerKnap = new Button();
            sælgereSøgeFelt = new TextBox();
            sælgereFilterKnap = new Button();
            personLayoutPanel.SuspendLayout();
            mæglerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mæglerDataGrid).BeginInit();
            mæglerMenuLayoutPanel.SuspendLayout();
            købereSalgLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)købereDataGridView).BeginInit();
            købereMenuLayoutPanel.SuspendLayout();
            sælgereLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sælgereDataGridView).BeginInit();
            sælgereMenuLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // personLayoutPanel
            // 
            personLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            personLayoutPanel.AutoScroll = true;
            personLayoutPanel.AutoSize = true;
            personLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            personLayoutPanel.BackColor = Color.FromArgb(255, 246, 182);
            personLayoutPanel.ColumnCount = 1;
            personLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            personLayoutPanel.Controls.Add(mæglerLayoutPanel, 0, 2);
            personLayoutPanel.Controls.Add(købereSalgLayoutPanel, 0, 1);
            personLayoutPanel.Controls.Add(sælgereLayoutPanel, 0, 0);
            personLayoutPanel.Location = new Point(0, 0);
            personLayoutPanel.Name = "personLayoutPanel";
            personLayoutPanel.RowCount = 3;
            personLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            personLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            personLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            personLayoutPanel.Size = new Size(294, 1008);
            personLayoutPanel.TabIndex = 0;
            // 
            // mæglerLayoutPanel
            // 
            mæglerLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            mæglerLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mæglerLayoutPanel.ColumnCount = 1;
            mæglerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mæglerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mæglerLayoutPanel.Controls.Add(mæglerDataGrid, 0, 2);
            mæglerLayoutPanel.Controls.Add(mæglerMenuLayoutPanel, 0, 1);
            mæglerLayoutPanel.Controls.Add(mæglerLabel, 0, 0);
            mæglerLayoutPanel.Location = new Point(3, 675);
            mæglerLayoutPanel.Margin = new Padding(3, 3, 3, 10);
            mæglerLayoutPanel.Name = "mæglerLayoutPanel";
            mæglerLayoutPanel.RowCount = 3;
            mæglerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8683376F));
            mæglerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6583071F));
            mæglerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 71.7868347F));
            mæglerLayoutPanel.Size = new Size(288, 323);
            mæglerLayoutPanel.TabIndex = 3;
            // 
            // mæglerDataGrid
            // 
            mæglerDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mæglerDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mæglerDataGrid.Location = new Point(11, 92);
            mæglerDataGrid.Margin = new Padding(10, 0, 10, 10);
            mæglerDataGrid.Name = "mæglerDataGrid";
            mæglerDataGrid.RowHeadersWidth = 62;
            mæglerDataGrid.Size = new Size(266, 220);
            mæglerDataGrid.TabIndex = 4;
            // 
            // mæglerMenuLayoutPanel
            // 
            mæglerMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mæglerMenuLayoutPanel.AutoSize = true;
            mæglerMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerMenuLayoutPanel.ColumnCount = 2;
            mæglerMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mæglerMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            mæglerMenuLayoutPanel.Controls.Add(mæglerSøgeFelt, 0, 0);
            mæglerMenuLayoutPanel.Controls.Add(mæglerFilterKnap, 1, 0);
            mæglerMenuLayoutPanel.Location = new Point(11, 58);
            mæglerMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            mæglerMenuLayoutPanel.Name = "mæglerMenuLayoutPanel";
            mæglerMenuLayoutPanel.RowCount = 1;
            mæglerMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mæglerMenuLayoutPanel.Size = new Size(266, 33);
            mæglerMenuLayoutPanel.TabIndex = 3;
            // 
            // mæglerSøgeFelt
            // 
            mæglerSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            mæglerSøgeFelt.Dock = DockStyle.Fill;
            mæglerSøgeFelt.Font = new Font("Segoe UI", 10F);
            mæglerSøgeFelt.Location = new Point(0, 0);
            mæglerSøgeFelt.Margin = new Padding(0);
            mæglerSøgeFelt.Name = "mæglerSøgeFelt";
            mæglerSøgeFelt.Size = new Size(186, 34);
            mæglerSøgeFelt.TabIndex = 0;
            mæglerSøgeFelt.Text = "Søg Navn...";
            // 
            // mæglerFilterKnap
            // 
            mæglerFilterKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mæglerFilterKnap.AutoSize = true;
            mæglerFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mæglerFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            mæglerFilterKnap.FlatStyle = FlatStyle.Popup;
            mæglerFilterKnap.Location = new Point(186, 0);
            mæglerFilterKnap.Margin = new Padding(0);
            mæglerFilterKnap.MaximumSize = new Size(0, 34);
            mæglerFilterKnap.MinimumSize = new Size(0, 34);
            mæglerFilterKnap.Name = "mæglerFilterKnap";
            mæglerFilterKnap.Size = new Size(80, 34);
            mæglerFilterKnap.TabIndex = 1;
            mæglerFilterKnap.Text = "Filtrer";
            mæglerFilterKnap.UseVisualStyleBackColor = false;
            // 
            // mæglerLabel
            // 
            mæglerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mæglerLabel.AutoSize = true;
            mæglerLabel.Font = new Font("Segoe UI", 20F);
            mæglerLabel.Location = new Point(6, 3);
            mæglerLabel.Margin = new Padding(5, 0, 0, 0);
            mæglerLabel.Name = "mæglerLabel";
            mæglerLabel.Size = new Size(182, 54);
            mæglerLabel.TabIndex = 1;
            mæglerLabel.Text = "Mæglere";
            mæglerLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // købereSalgLayoutPanel
            // 
            købereSalgLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            købereSalgLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            købereSalgLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            købereSalgLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            købereSalgLayoutPanel.ColumnCount = 1;
            købereSalgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            købereSalgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            købereSalgLayoutPanel.Controls.Add(købereDataGridView, 0, 2);
            købereSalgLayoutPanel.Controls.Add(købereMenuLayoutPanel, 0, 1);
            købereSalgLayoutPanel.Controls.Add(købereLabel, 0, 0);
            købereSalgLayoutPanel.Location = new Point(3, 339);
            købereSalgLayoutPanel.Margin = new Padding(3, 3, 3, 10);
            købereSalgLayoutPanel.Name = "købereSalgLayoutPanel";
            købereSalgLayoutPanel.RowCount = 3;
            købereSalgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8683376F));
            købereSalgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6583071F));
            købereSalgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 71.7868347F));
            købereSalgLayoutPanel.Size = new Size(288, 323);
            købereSalgLayoutPanel.TabIndex = 2;
            // 
            // købereDataGridView
            // 
            købereDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            købereDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            købereDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            købereDataGridView.Location = new Point(11, 92);
            købereDataGridView.Margin = new Padding(10, 0, 10, 10);
            købereDataGridView.Name = "købereDataGridView";
            købereDataGridView.RowHeadersWidth = 62;
            købereDataGridView.Size = new Size(266, 220);
            købereDataGridView.TabIndex = 4;
            // 
            // købereMenuLayoutPanel
            // 
            købereMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            købereMenuLayoutPanel.AutoSize = true;
            købereMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            købereMenuLayoutPanel.ColumnCount = 3;
            købereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            købereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            købereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            købereMenuLayoutPanel.Controls.Add(købereRegistrerKnap, 2, 0);
            købereMenuLayoutPanel.Controls.Add(købereSøgeFelt, 0, 0);
            købereMenuLayoutPanel.Controls.Add(købereFilterKnap, 1, 0);
            købereMenuLayoutPanel.Location = new Point(11, 58);
            købereMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            købereMenuLayoutPanel.Name = "købereMenuLayoutPanel";
            købereMenuLayoutPanel.RowCount = 1;
            købereMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            købereMenuLayoutPanel.Size = new Size(266, 33);
            købereMenuLayoutPanel.TabIndex = 3;
            // 
            // købereRegistrerKnap
            // 
            købereRegistrerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            købereRegistrerKnap.AutoSize = true;
            købereRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            købereRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            købereRegistrerKnap.FlatStyle = FlatStyle.Popup;
            købereRegistrerKnap.Location = new Point(225, 0);
            købereRegistrerKnap.Margin = new Padding(0);
            købereRegistrerKnap.MaximumSize = new Size(0, 34);
            købereRegistrerKnap.MinimumSize = new Size(0, 34);
            købereRegistrerKnap.Name = "købereRegistrerKnap";
            købereRegistrerKnap.Size = new Size(41, 34);
            købereRegistrerKnap.TabIndex = 2;
            købereRegistrerKnap.Text = "Registrer";
            købereRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // købereSøgeFelt
            // 
            købereSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            købereSøgeFelt.Dock = DockStyle.Fill;
            købereSøgeFelt.Font = new Font("Segoe UI", 10F);
            købereSøgeFelt.Location = new Point(0, 0);
            købereSøgeFelt.Margin = new Padding(0);
            købereSøgeFelt.Name = "købereSøgeFelt";
            købereSøgeFelt.Size = new Size(186, 34);
            købereSøgeFelt.TabIndex = 0;
            købereSøgeFelt.Text = "Søg Navn...";
            // 
            // købereFilterKnap
            // 
            købereFilterKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            købereFilterKnap.AutoSize = true;
            købereFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            købereFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            købereFilterKnap.FlatStyle = FlatStyle.Popup;
            købereFilterKnap.Location = new Point(186, 0);
            købereFilterKnap.Margin = new Padding(0);
            købereFilterKnap.MaximumSize = new Size(0, 34);
            købereFilterKnap.MinimumSize = new Size(0, 34);
            købereFilterKnap.Name = "købereFilterKnap";
            købereFilterKnap.Size = new Size(39, 34);
            købereFilterKnap.TabIndex = 1;
            købereFilterKnap.Text = "Filtrer";
            købereFilterKnap.UseVisualStyleBackColor = false;
            // 
            // købereLabel
            // 
            købereLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            købereLabel.AutoSize = true;
            købereLabel.Font = new Font("Segoe UI", 20F);
            købereLabel.Location = new Point(6, 3);
            købereLabel.Margin = new Padding(5, 0, 0, 0);
            købereLabel.Name = "købereLabel";
            købereLabel.Size = new Size(149, 54);
            købereLabel.TabIndex = 1;
            købereLabel.Text = "Købere";
            købereLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sælgereLayoutPanel
            // 
            sælgereLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgereLayoutPanel.AutoScroll = true;
            sælgereLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgereLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            sælgereLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            sælgereLayoutPanel.ColumnCount = 1;
            sælgereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            sælgereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            sælgereLayoutPanel.Controls.Add(sælgereLabel, 0, 0);
            sælgereLayoutPanel.Controls.Add(sælgereDataGridView, 0, 2);
            sælgereLayoutPanel.Controls.Add(sælgereMenuLayoutPanel, 0, 1);
            sælgereLayoutPanel.Location = new Point(3, 3);
            sælgereLayoutPanel.Margin = new Padding(3, 3, 3, 10);
            sælgereLayoutPanel.Name = "sælgereLayoutPanel";
            sælgereLayoutPanel.RowCount = 3;
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9245281F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.691824F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 71.06918F));
            sælgereLayoutPanel.Size = new Size(288, 323);
            sælgereLayoutPanel.TabIndex = 1;
            // 
            // sælgereLabel
            // 
            sælgereLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sælgereLabel.AutoSize = true;
            sælgereLabel.Font = new Font("Segoe UI", 20F);
            sælgereLabel.Location = new Point(3, 4);
            sælgereLabel.Margin = new Padding(2, 2, 2, 0);
            sælgereLabel.Name = "sælgereLabel";
            sælgereLabel.Size = new Size(167, 54);
            sælgereLabel.TabIndex = 0;
            sælgereLabel.Text = "Sælgere";
            sælgereLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sælgereDataGridView
            // 
            sælgereDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgereDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sælgereDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sælgereDataGridView.Location = new Point(11, 94);
            sælgereDataGridView.Margin = new Padding(10, 0, 10, 10);
            sælgereDataGridView.Name = "sælgereDataGridView";
            sælgereDataGridView.RowHeadersWidth = 62;
            sælgereDataGridView.Size = new Size(266, 218);
            sælgereDataGridView.TabIndex = 1;
            // 
            // sælgereMenuLayoutPanel
            // 
            sælgereMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            sælgereMenuLayoutPanel.AutoSize = true;
            sælgereMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgereMenuLayoutPanel.ColumnCount = 3;
            sælgereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            sælgereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            sælgereMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            sælgereMenuLayoutPanel.Controls.Add(sælgereRegistrerKnap, 2, 0);
            sælgereMenuLayoutPanel.Controls.Add(sælgereSøgeFelt, 0, 0);
            sælgereMenuLayoutPanel.Controls.Add(sælgereFilterKnap, 1, 0);
            sælgereMenuLayoutPanel.Location = new Point(11, 59);
            sælgereMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            sælgereMenuLayoutPanel.Name = "sælgereMenuLayoutPanel";
            sælgereMenuLayoutPanel.RowCount = 1;
            sælgereMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            sælgereMenuLayoutPanel.Size = new Size(266, 34);
            sælgereMenuLayoutPanel.TabIndex = 2;
            // 
            // sælgereRegistrerKnap
            // 
            sælgereRegistrerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgereRegistrerKnap.AutoSize = true;
            sælgereRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgereRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            sælgereRegistrerKnap.FlatStyle = FlatStyle.Popup;
            sælgereRegistrerKnap.Location = new Point(225, 0);
            sælgereRegistrerKnap.Margin = new Padding(0);
            sælgereRegistrerKnap.MaximumSize = new Size(0, 34);
            sælgereRegistrerKnap.MinimumSize = new Size(0, 34);
            sælgereRegistrerKnap.Name = "sælgereRegistrerKnap";
            sælgereRegistrerKnap.Size = new Size(41, 34);
            sælgereRegistrerKnap.TabIndex = 2;
            sælgereRegistrerKnap.Text = "Registrer";
            sælgereRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // sælgereSøgeFelt
            // 
            sælgereSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            sælgereSøgeFelt.Dock = DockStyle.Fill;
            sælgereSøgeFelt.Font = new Font("Segoe UI", 10F);
            sælgereSøgeFelt.Location = new Point(0, 0);
            sælgereSøgeFelt.Margin = new Padding(0);
            sælgereSøgeFelt.Name = "sælgereSøgeFelt";
            sælgereSøgeFelt.Size = new Size(186, 34);
            sælgereSøgeFelt.TabIndex = 0;
            sælgereSøgeFelt.Text = "Søg Navn...";
            // 
            // sælgereFilterKnap
            // 
            sælgereFilterKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgereFilterKnap.AutoSize = true;
            sælgereFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgereFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            sælgereFilterKnap.FlatStyle = FlatStyle.Popup;
            sælgereFilterKnap.Location = new Point(186, 0);
            sælgereFilterKnap.Margin = new Padding(0);
            sælgereFilterKnap.MaximumSize = new Size(0, 34);
            sælgereFilterKnap.MinimumSize = new Size(0, 34);
            sælgereFilterKnap.Name = "sælgereFilterKnap";
            sælgereFilterKnap.Size = new Size(39, 34);
            sælgereFilterKnap.TabIndex = 1;
            sælgereFilterKnap.Text = "Filtrer";
            sælgereFilterKnap.UseVisualStyleBackColor = false;
            // 
            // PersonForside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(personLayoutPanel);
            Name = "PersonForside";
            Size = new Size(294, 667);
            personLayoutPanel.ResumeLayout(false);
            mæglerLayoutPanel.ResumeLayout(false);
            mæglerLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mæglerDataGrid).EndInit();
            mæglerMenuLayoutPanel.ResumeLayout(false);
            mæglerMenuLayoutPanel.PerformLayout();
            købereSalgLayoutPanel.ResumeLayout(false);
            købereSalgLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)købereDataGridView).EndInit();
            købereMenuLayoutPanel.ResumeLayout(false);
            købereMenuLayoutPanel.PerformLayout();
            sælgereLayoutPanel.ResumeLayout(false);
            sælgereLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sælgereDataGridView).EndInit();
            sælgereMenuLayoutPanel.ResumeLayout(false);
            sælgereMenuLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel personLayoutPanel;
        private TableLayoutPanel sælgereLayoutPanel;
        private Label sælgereLabel;
        private DataGridView sælgereDataGridView;
        private TableLayoutPanel sælgereMenuLayoutPanel;
        private Button sælgereRegistrerKnap;
        private TextBox sælgereSøgeFelt;
        private Button sælgereFilterKnap;
        private TableLayoutPanel købereSalgLayoutPanel;
        private DataGridView købereDataGridView;
        private TableLayoutPanel købereMenuLayoutPanel;
        private Button købereRegistrerKnap;
        private TextBox købereSøgeFelt;
        private Button købereFilterKnap;
        private Label købereLabel;
        private TableLayoutPanel mæglerLayoutPanel;
        private DataGridView mæglerDataGrid;
        private TableLayoutPanel mæglerMenuLayoutPanel;
        private TextBox mæglerSøgeFelt;
        private Button mæglerFilterKnap;
        private Label mæglerLabel;
    }
}
