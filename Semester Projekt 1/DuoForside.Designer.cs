namespace Semester_Projekt_1
{
    partial class duoForside
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
            bigLayoutPanel = new TableLayoutPanel();
            alleLayoutPanel = new TableLayoutPanel();
            alleDataGridView = new DataGridView();
            alleMenuLayoutPanel = new TableLayoutPanel();
            alleRegistrerKnap = new Button();
            alleSøgeFelt = new TextBox();
            alleFilterKnap = new Button();
            alleLabel = new Label();
            mineLayoutPanel = new TableLayoutPanel();
            mineLabel = new Label();
            mineDataGridView = new DataGridView();
            mineMenuLayoutPanel = new TableLayoutPanel();
            mineRegistrerKnap = new Button();
            mineSøgeFelt = new TextBox();
            mineFilterKnap = new Button();
            bigLayoutPanel.SuspendLayout();
            alleLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)alleDataGridView).BeginInit();
            alleMenuLayoutPanel.SuspendLayout();
            mineLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mineDataGridView).BeginInit();
            mineMenuLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bigLayoutPanel
            // 
            bigLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bigLayoutPanel.AutoSize = true;
            bigLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            bigLayoutPanel.BackColor = Color.FromArgb(255, 246, 182);
            bigLayoutPanel.ColumnCount = 1;
            bigLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            bigLayoutPanel.Controls.Add(alleLayoutPanel, 0, 1);
            bigLayoutPanel.Controls.Add(mineLayoutPanel, 0, 0);
            bigLayoutPanel.Location = new Point(0, 0);
            bigLayoutPanel.Margin = new Padding(0);
            bigLayoutPanel.Name = "bigLayoutPanel";
            bigLayoutPanel.RowCount = 2;
            bigLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bigLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bigLayoutPanel.Size = new Size(689, 664);
            bigLayoutPanel.TabIndex = 0;
            // 
            // alleLayoutPanel
            // 
            alleLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            alleLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            alleLayoutPanel.ColumnCount = 1;
            alleLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            alleLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            alleLayoutPanel.Controls.Add(alleDataGridView, 0, 2);
            alleLayoutPanel.Controls.Add(alleMenuLayoutPanel, 0, 1);
            alleLayoutPanel.Controls.Add(alleLabel, 0, 0);
            alleLayoutPanel.Location = new Point(3, 335);
            alleLayoutPanel.Margin = new Padding(3, 3, 3, 2);
            alleLayoutPanel.Name = "alleLayoutPanel";
            alleLayoutPanel.RowCount = 3;
            alleLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.8683376F));
            alleLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6583071F));
            alleLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 71.7868347F));
            alleLayoutPanel.Size = new Size(683, 327);
            alleLayoutPanel.TabIndex = 1;
            // 
            // alleDataGridView
            // 
            alleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alleDataGridView.Location = new Point(11, 94);
            alleDataGridView.Margin = new Padding(10, 0, 10, 10);
            alleDataGridView.Name = "alleDataGridView";
            alleDataGridView.RowHeadersWidth = 62;
            alleDataGridView.Size = new Size(661, 222);
            alleDataGridView.TabIndex = 4;
            // 
            // alleMenuLayoutPanel
            // 
            alleMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            alleMenuLayoutPanel.AutoSize = true;
            alleMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleMenuLayoutPanel.ColumnCount = 3;
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            alleMenuLayoutPanel.Controls.Add(alleRegistrerKnap, 2, 0);
            alleMenuLayoutPanel.Controls.Add(alleSøgeFelt, 0, 0);
            alleMenuLayoutPanel.Controls.Add(alleFilterKnap, 1, 0);
            alleMenuLayoutPanel.Location = new Point(11, 59);
            alleMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            alleMenuLayoutPanel.Name = "alleMenuLayoutPanel";
            alleMenuLayoutPanel.RowCount = 1;
            alleMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            alleMenuLayoutPanel.Size = new Size(661, 34);
            alleMenuLayoutPanel.TabIndex = 3;
            // 
            // alleRegistrerKnap
            // 
            alleRegistrerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleRegistrerKnap.AutoSize = true;
            alleRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            alleRegistrerKnap.FlatStyle = FlatStyle.Popup;
            alleRegistrerKnap.Location = new Point(561, 0);
            alleRegistrerKnap.Margin = new Padding(0);
            alleRegistrerKnap.MaximumSize = new Size(0, 34);
            alleRegistrerKnap.MinimumSize = new Size(0, 34);
            alleRegistrerKnap.Name = "alleRegistrerKnap";
            alleRegistrerKnap.Size = new Size(100, 34);
            alleRegistrerKnap.TabIndex = 2;
            alleRegistrerKnap.Text = "Registrer";
            alleRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // alleSøgeFelt
            // 
            alleSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            alleSøgeFelt.Dock = DockStyle.Fill;
            alleSøgeFelt.Font = new Font("Segoe UI", 10F);
            alleSøgeFelt.Location = new Point(0, 0);
            alleSøgeFelt.Margin = new Padding(0);
            alleSøgeFelt.Name = "alleSøgeFelt";
            alleSøgeFelt.Size = new Size(462, 34);
            alleSøgeFelt.TabIndex = 0;
            alleSøgeFelt.Text = "Søg Adresse...";
            // 
            // alleFilterKnap
            // 
            alleFilterKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleFilterKnap.AutoSize = true;
            alleFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            alleFilterKnap.FlatStyle = FlatStyle.Popup;
            alleFilterKnap.Location = new Point(462, 0);
            alleFilterKnap.Margin = new Padding(0);
            alleFilterKnap.MaximumSize = new Size(0, 34);
            alleFilterKnap.MinimumSize = new Size(0, 34);
            alleFilterKnap.Name = "alleFilterKnap";
            alleFilterKnap.Size = new Size(99, 34);
            alleFilterKnap.TabIndex = 1;
            alleFilterKnap.Text = "Filtrer";
            alleFilterKnap.UseVisualStyleBackColor = false;
            // 
            // alleLabel
            // 
            alleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            alleLabel.AutoSize = true;
            alleLabel.Font = new Font("Segoe UI", 20F);
            alleLabel.Location = new Point(6, 4);
            alleLabel.Margin = new Padding(5, 0, 0, 0);
            alleLabel.Name = "alleLabel";
            alleLabel.Size = new Size(176, 54);
            alleLabel.TabIndex = 1;
            alleLabel.Text = "Alle Salg";
            alleLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mineLayoutPanel
            // 
            mineLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            mineLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mineLayoutPanel.ColumnCount = 1;
            mineLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mineLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            mineLayoutPanel.Controls.Add(mineLabel, 0, 0);
            mineLayoutPanel.Controls.Add(mineDataGridView, 0, 2);
            mineLayoutPanel.Controls.Add(mineMenuLayoutPanel, 0, 1);
            mineLayoutPanel.Location = new Point(3, 3);
            mineLayoutPanel.Margin = new Padding(3, 3, 3, 10);
            mineLayoutPanel.Name = "mineLayoutPanel";
            mineLayoutPanel.RowCount = 3;
            mineLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 17.9245281F));
            mineLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10.691824F));
            mineLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 71.06918F));
            mineLayoutPanel.Size = new Size(683, 319);
            mineLayoutPanel.TabIndex = 0;
            // 
            // mineLabel
            // 
            mineLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            mineLabel.AutoSize = true;
            mineLabel.Font = new Font("Segoe UI", 20F);
            mineLabel.Location = new Point(3, 3);
            mineLabel.Margin = new Padding(2, 2, 2, 0);
            mineLabel.Name = "mineLabel";
            mineLabel.Size = new Size(199, 54);
            mineLabel.TabIndex = 0;
            mineLabel.Text = "Mine Salg";
            mineLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mineDataGridView
            // 
            mineDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mineDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mineDataGridView.Location = new Point(11, 92);
            mineDataGridView.Margin = new Padding(10, 0, 10, 10);
            mineDataGridView.Name = "mineDataGridView";
            mineDataGridView.RowHeadersWidth = 62;
            mineDataGridView.Size = new Size(661, 216);
            mineDataGridView.TabIndex = 1;
            // 
            // mineMenuLayoutPanel
            // 
            mineMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mineMenuLayoutPanel.AutoSize = true;
            mineMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineMenuLayoutPanel.ColumnCount = 3;
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mineMenuLayoutPanel.Controls.Add(mineRegistrerKnap, 2, 0);
            mineMenuLayoutPanel.Controls.Add(mineSøgeFelt, 0, 0);
            mineMenuLayoutPanel.Controls.Add(mineFilterKnap, 1, 0);
            mineMenuLayoutPanel.Location = new Point(11, 58);
            mineMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            mineMenuLayoutPanel.Name = "mineMenuLayoutPanel";
            mineMenuLayoutPanel.RowCount = 1;
            mineMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mineMenuLayoutPanel.Size = new Size(661, 33);
            mineMenuLayoutPanel.TabIndex = 2;
            // 
            // mineRegistrerKnap
            // 
            mineRegistrerKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineRegistrerKnap.AutoSize = true;
            mineRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            mineRegistrerKnap.FlatStyle = FlatStyle.Popup;
            mineRegistrerKnap.Location = new Point(561, 0);
            mineRegistrerKnap.Margin = new Padding(0);
            mineRegistrerKnap.MaximumSize = new Size(0, 34);
            mineRegistrerKnap.MinimumSize = new Size(0, 34);
            mineRegistrerKnap.Name = "mineRegistrerKnap";
            mineRegistrerKnap.Size = new Size(100, 34);
            mineRegistrerKnap.TabIndex = 2;
            mineRegistrerKnap.Text = "Registrer";
            mineRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // mineSøgeFelt
            // 
            mineSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            mineSøgeFelt.Dock = DockStyle.Fill;
            mineSøgeFelt.Font = new Font("Segoe UI", 10F);
            mineSøgeFelt.Location = new Point(0, 0);
            mineSøgeFelt.Margin = new Padding(0);
            mineSøgeFelt.Name = "mineSøgeFelt";
            mineSøgeFelt.Size = new Size(462, 34);
            mineSøgeFelt.TabIndex = 0;
            mineSøgeFelt.Text = "Søg Adresse...";
            // 
            // mineFilterKnap
            // 
            mineFilterKnap.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineFilterKnap.AutoSize = true;
            mineFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            mineFilterKnap.FlatStyle = FlatStyle.Popup;
            mineFilterKnap.Location = new Point(462, 0);
            mineFilterKnap.Margin = new Padding(0);
            mineFilterKnap.MaximumSize = new Size(0, 34);
            mineFilterKnap.MinimumSize = new Size(0, 34);
            mineFilterKnap.Name = "mineFilterKnap";
            mineFilterKnap.Size = new Size(99, 34);
            mineFilterKnap.TabIndex = 1;
            mineFilterKnap.Text = "Filtrer";
            mineFilterKnap.UseVisualStyleBackColor = false;
            // 
            // duoForside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            Controls.Add(bigLayoutPanel);
            Name = "duoForside";
            Size = new Size(689, 663);
            bigLayoutPanel.ResumeLayout(false);
            alleLayoutPanel.ResumeLayout(false);
            alleLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)alleDataGridView).EndInit();
            alleMenuLayoutPanel.ResumeLayout(false);
            alleMenuLayoutPanel.PerformLayout();
            mineLayoutPanel.ResumeLayout(false);
            mineLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mineDataGridView).EndInit();
            mineMenuLayoutPanel.ResumeLayout(false);
            mineMenuLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel bigLayoutPanel;
        private TableLayoutPanel mineLayoutPanel;
        private TableLayoutPanel alleLayoutPanel;
        private Label mineLabel;
        private DataGridView mineDataGridView;
        private TableLayoutPanel mineMenuLayoutPanel;
        private TextBox mineSøgeFelt;
        private Button mineRegistrerKnap;
        private Button mineFilterKnap;
        private Label alleLabel;
        private DataGridView alleDataGridView;
        private TableLayoutPanel alleMenuLayoutPanel;
        private Button alleRegistrerKnap;
        private TextBox alleSøgeFelt;
        private Button alleFilterKnap;
    }
}
