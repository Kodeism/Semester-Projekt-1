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
            mineFilterKnap = new Button();
            mineSøgeFelt = new TextBox();
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
            bigLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            bigLayoutPanel.Controls.Add(alleLayoutPanel, 0, 1);
            bigLayoutPanel.Controls.Add(mineLayoutPanel, 0, 0);
            bigLayoutPanel.Location = new Point(0, 0);
            bigLayoutPanel.Margin = new Padding(0);
            bigLayoutPanel.Name = "bigLayoutPanel";
            bigLayoutPanel.RowCount = 2;
            bigLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bigLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bigLayoutPanel.Size = new Size(482, 416);
            bigLayoutPanel.TabIndex = 0;
            // 
            // alleLayoutPanel
            // 
            alleLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleLayoutPanel.AutoSize = true;
            alleLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            alleLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            alleLayoutPanel.ColumnCount = 1;
            alleLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            alleLayoutPanel.Controls.Add(alleDataGridView, 0, 2);
            alleLayoutPanel.Controls.Add(alleMenuLayoutPanel, 0, 1);
            alleLayoutPanel.Controls.Add(alleLabel, 0, 0);
            alleLayoutPanel.Location = new Point(2, 210);
            alleLayoutPanel.Margin = new Padding(2, 2, 2, 1);
            alleLayoutPanel.Name = "alleLayoutPanel";
            alleLayoutPanel.RowCount = 3;
            alleLayoutPanel.RowStyles.Add(new RowStyle());
            alleLayoutPanel.RowStyles.Add(new RowStyle());
            alleLayoutPanel.RowStyles.Add(new RowStyle());
            alleLayoutPanel.Size = new Size(478, 205);
            alleLayoutPanel.TabIndex = 1;
            // 
            // alleDataGridView
            // 
            alleDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alleDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alleDataGridView.Location = new Point(8, 65);
            alleDataGridView.Margin = new Padding(7, 0, 7, 6);
            alleDataGridView.Name = "alleDataGridView";
            alleDataGridView.RowHeadersWidth = 62;
            alleDataGridView.Size = new Size(462, 133);
            alleDataGridView.TabIndex = 4;
            // 
            // alleMenuLayoutPanel
            // 
            alleMenuLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleMenuLayoutPanel.AutoSize = true;
            alleMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleMenuLayoutPanel.ColumnCount = 3;
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            alleMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            alleMenuLayoutPanel.Controls.Add(alleRegistrerKnap, 2, 0);
            alleMenuLayoutPanel.Controls.Add(alleSøgeFelt, 0, 0);
            alleMenuLayoutPanel.Controls.Add(alleFilterKnap, 1, 0);
            alleMenuLayoutPanel.Location = new Point(8, 39);
            alleMenuLayoutPanel.Margin = new Padding(7, 0, 7, 0);
            alleMenuLayoutPanel.Name = "alleMenuLayoutPanel";
            alleMenuLayoutPanel.RowCount = 1;
            alleMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            alleMenuLayoutPanel.Size = new Size(462, 25);
            alleMenuLayoutPanel.TabIndex = 3;
            // 
            // alleRegistrerKnap
            // 
            alleRegistrerKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleRegistrerKnap.AutoSize = true;
            alleRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            alleRegistrerKnap.FlatStyle = FlatStyle.Popup;
            alleRegistrerKnap.Location = new Point(392, 0);
            alleRegistrerKnap.Margin = new Padding(0);
            alleRegistrerKnap.Name = "alleRegistrerKnap";
            alleRegistrerKnap.Size = new Size(70, 25);
            alleRegistrerKnap.TabIndex = 2;
            alleRegistrerKnap.Text = "Registrer";
            alleRegistrerKnap.UseVisualStyleBackColor = false;
            alleRegistrerKnap.Click += alleRegistrerKnap_Click;
            // 
            // alleSøgeFelt
            // 
            alleSøgeFelt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            alleSøgeFelt.Font = new Font("Segoe UI", 10F);
            alleSøgeFelt.Location = new Point(0, 0);
            alleSøgeFelt.Margin = new Padding(0);
            alleSøgeFelt.Name = "alleSøgeFelt";
            alleSøgeFelt.Size = new Size(323, 25);
            alleSøgeFelt.TabIndex = 0;
            alleSøgeFelt.Text = "Søg Adresse...";
            // 
            // alleFilterKnap
            // 
            alleFilterKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleFilterKnap.AutoSize = true;
            alleFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            alleFilterKnap.FlatStyle = FlatStyle.Popup;
            alleFilterKnap.Location = new Point(323, 0);
            alleFilterKnap.Margin = new Padding(0);
            alleFilterKnap.Name = "alleFilterKnap";
            alleFilterKnap.Size = new Size(69, 25);
            alleFilterKnap.TabIndex = 1;
            alleFilterKnap.Text = "Filtrer";
            alleFilterKnap.UseVisualStyleBackColor = false;
            // 
            // alleLabel
            // 
            alleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            alleLabel.AutoSize = true;
            alleLabel.Font = new Font("Segoe UI", 20F);
            alleLabel.Location = new Point(1, 1);
            alleLabel.Margin = new Padding(0);
            alleLabel.Name = "alleLabel";
            alleLabel.Size = new Size(476, 37);
            alleLabel.TabIndex = 1;
            alleLabel.Text = "Alle Salg";
            alleLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mineLayoutPanel
            // 
            mineLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineLayoutPanel.AutoSize = true;
            mineLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            mineLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            mineLayoutPanel.ColumnCount = 1;
            mineLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mineLayoutPanel.Controls.Add(mineLabel, 0, 0);
            mineLayoutPanel.Controls.Add(mineDataGridView, 0, 2);
            mineLayoutPanel.Controls.Add(mineMenuLayoutPanel, 0, 1);
            mineLayoutPanel.Location = new Point(2, 2);
            mineLayoutPanel.Margin = new Padding(2, 2, 2, 6);
            mineLayoutPanel.Name = "mineLayoutPanel";
            mineLayoutPanel.RowCount = 3;
            mineLayoutPanel.RowStyles.Add(new RowStyle());
            mineLayoutPanel.RowStyles.Add(new RowStyle());
            mineLayoutPanel.RowStyles.Add(new RowStyle());
            mineLayoutPanel.Size = new Size(478, 200);
            mineLayoutPanel.TabIndex = 0;
            // 
            // mineLabel
            // 
            mineLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineLabel.AutoSize = true;
            mineLabel.Font = new Font("Segoe UI", 20F);
            mineLabel.Location = new Point(1, 1);
            mineLabel.Margin = new Padding(0);
            mineLabel.Name = "mineLabel";
            mineLabel.Size = new Size(476, 37);
            mineLabel.TabIndex = 0;
            mineLabel.Text = "Mine Salg";
            mineLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // mineDataGridView
            // 
            mineDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mineDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            mineDataGridView.Location = new Point(8, 65);
            mineDataGridView.Margin = new Padding(7, 0, 7, 6);
            mineDataGridView.Name = "mineDataGridView";
            mineDataGridView.RowHeadersWidth = 62;
            mineDataGridView.Size = new Size(462, 128);
            mineDataGridView.TabIndex = 1;
            // 
            // mineMenuLayoutPanel
            // 
            mineMenuLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineMenuLayoutPanel.AutoSize = true;
            mineMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineMenuLayoutPanel.ColumnCount = 3;
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mineMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            mineMenuLayoutPanel.Controls.Add(mineRegistrerKnap, 2, 0);
            mineMenuLayoutPanel.Controls.Add(mineFilterKnap, 1, 0);
            mineMenuLayoutPanel.Controls.Add(mineSøgeFelt, 0, 0);
            mineMenuLayoutPanel.Location = new Point(8, 39);
            mineMenuLayoutPanel.Margin = new Padding(7, 0, 7, 0);
            mineMenuLayoutPanel.Name = "mineMenuLayoutPanel";
            mineMenuLayoutPanel.RowCount = 1;
            mineMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mineMenuLayoutPanel.Size = new Size(462, 25);
            mineMenuLayoutPanel.TabIndex = 2;
            // 
            // mineRegistrerKnap
            // 
            mineRegistrerKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineRegistrerKnap.AutoSize = true;
            mineRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            mineRegistrerKnap.FlatStyle = FlatStyle.Popup;
            mineRegistrerKnap.Location = new Point(392, 0);
            mineRegistrerKnap.Margin = new Padding(0);
            mineRegistrerKnap.Name = "mineRegistrerKnap";
            mineRegistrerKnap.Size = new Size(70, 25);
            mineRegistrerKnap.TabIndex = 2;
            mineRegistrerKnap.Text = "Registrer";
            mineRegistrerKnap.UseVisualStyleBackColor = false;
            mineRegistrerKnap.Click += mineRegistrerKnap_Click;
            // 
            // mineFilterKnap
            // 
            mineFilterKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineFilterKnap.AutoSize = true;
            mineFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            mineFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            mineFilterKnap.FlatStyle = FlatStyle.Popup;
            mineFilterKnap.Location = new Point(323, 0);
            mineFilterKnap.Margin = new Padding(0);
            mineFilterKnap.Name = "mineFilterKnap";
            mineFilterKnap.Size = new Size(69, 25);
            mineFilterKnap.TabIndex = 1;
            mineFilterKnap.Text = "Filtrer";
            mineFilterKnap.UseVisualStyleBackColor = false;
            // 
            // mineSøgeFelt
            // 
            mineSøgeFelt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mineSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            mineSøgeFelt.Font = new Font("Segoe UI", 10F);
            mineSøgeFelt.Location = new Point(0, 0);
            mineSøgeFelt.Margin = new Padding(0);
            mineSøgeFelt.Name = "mineSøgeFelt";
            mineSøgeFelt.Size = new Size(323, 25);
            mineSøgeFelt.TabIndex = 0;
            mineSøgeFelt.Text = "Søg Adresse...";
            // 
            // duoForside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            Controls.Add(bigLayoutPanel);
            Margin = new Padding(2);
            Name = "duoForside";
            Size = new Size(482, 416);
            bigLayoutPanel.ResumeLayout(false);
            bigLayoutPanel.PerformLayout();
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
