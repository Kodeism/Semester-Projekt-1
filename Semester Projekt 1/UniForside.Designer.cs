namespace Semester_Projekt_1
{
    partial class UniForside
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
            uniLayoutPanel = new TableLayoutPanel();
            uniMenuLayoutPanel = new TableLayoutPanel();
            uniRegistrerKnap = new Button();
            uniSøgeFelt = new TextBox();
            uniFilterKnap = new Button();
            uniLabel = new Label();
            uniDataGridView = new DataGridView();
            uniLayoutPanel.SuspendLayout();
            uniMenuLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)uniDataGridView).BeginInit();
            SuspendLayout();
            // 
            // uniLayoutPanel
            // 
            uniLayoutPanel.AutoSize = true;
            uniLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uniLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            uniLayoutPanel.ColumnCount = 1;
            uniLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uniLayoutPanel.Controls.Add(uniMenuLayoutPanel, 0, 1);
            uniLayoutPanel.Controls.Add(uniLabel, 0, 0);
            uniLayoutPanel.Controls.Add(uniDataGridView, 0, 2);
            uniLayoutPanel.Dock = DockStyle.Fill;
            uniLayoutPanel.Location = new Point(0, 0);
            uniLayoutPanel.Margin = new Padding(10);
            uniLayoutPanel.Name = "uniLayoutPanel";
            uniLayoutPanel.RowCount = 3;
            uniLayoutPanel.RowStyles.Add(new RowStyle());
            uniLayoutPanel.RowStyles.Add(new RowStyle());
            uniLayoutPanel.RowStyles.Add(new RowStyle());
            uniLayoutPanel.Size = new Size(689, 663);
            uniLayoutPanel.TabIndex = 1;
            // 
            // uniMenuLayoutPanel
            // 
            uniMenuLayoutPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uniMenuLayoutPanel.AutoSize = true;
            uniMenuLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uniMenuLayoutPanel.ColumnCount = 3;
            uniMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.02041F));
            uniMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.32653F));
            uniMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.32653F));
            uniMenuLayoutPanel.Controls.Add(uniRegistrerKnap, 2, 0);
            uniMenuLayoutPanel.Controls.Add(uniSøgeFelt, 0, 0);
            uniMenuLayoutPanel.Controls.Add(uniFilterKnap, 1, 0);
            uniMenuLayoutPanel.Location = new Point(10, 55);
            uniMenuLayoutPanel.Margin = new Padding(10, 0, 10, 0);
            uniMenuLayoutPanel.Name = "uniMenuLayoutPanel";
            uniMenuLayoutPanel.RowCount = 1;
            uniMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uniMenuLayoutPanel.Size = new Size(669, 34);
            uniMenuLayoutPanel.TabIndex = 3;
            // 
            // uniRegistrerKnap
            // 
            uniRegistrerKnap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uniRegistrerKnap.AutoSize = true;
            uniRegistrerKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uniRegistrerKnap.BackColor = Color.FromArgb(211, 222, 255);
            uniRegistrerKnap.FlatStyle = FlatStyle.Popup;
            uniRegistrerKnap.Location = new Point(537, 0);
            uniRegistrerKnap.Margin = new Padding(0);
            uniRegistrerKnap.MaximumSize = new Size(0, 34);
            uniRegistrerKnap.MinimumSize = new Size(0, 34);
            uniRegistrerKnap.Name = "uniRegistrerKnap";
            uniRegistrerKnap.Size = new Size(132, 34);
            uniRegistrerKnap.TabIndex = 2;
            uniRegistrerKnap.Text = "Registrer";
            uniRegistrerKnap.UseVisualStyleBackColor = false;
            // 
            // uniSøgeFelt
            // 
            uniSøgeFelt.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uniSøgeFelt.BorderStyle = BorderStyle.FixedSingle;
            uniSøgeFelt.Font = new Font("Segoe UI", 10F);
            uniSøgeFelt.Location = new Point(0, 0);
            uniSøgeFelt.Margin = new Padding(0);
            uniSøgeFelt.Name = "uniSøgeFelt";
            uniSøgeFelt.Size = new Size(407, 34);
            uniSøgeFelt.TabIndex = 0;
            uniSøgeFelt.Text = "Søg Adresse...";
            // 
            // uniFilterKnap
            // 
            uniFilterKnap.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uniFilterKnap.AutoSize = true;
            uniFilterKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uniFilterKnap.BackColor = Color.FromArgb(255, 202, 202);
            uniFilterKnap.FlatStyle = FlatStyle.Popup;
            uniFilterKnap.Location = new Point(407, 0);
            uniFilterKnap.Margin = new Padding(0);
            uniFilterKnap.MaximumSize = new Size(0, 34);
            uniFilterKnap.MinimumSize = new Size(0, 34);
            uniFilterKnap.Name = "uniFilterKnap";
            uniFilterKnap.Size = new Size(130, 34);
            uniFilterKnap.TabIndex = 1;
            uniFilterKnap.Text = "Filtrer";
            uniFilterKnap.UseVisualStyleBackColor = false;
            uniFilterKnap.Click += uniFilterKnap_Click;
            // 
            // uniLabel
            // 
            uniLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uniLabel.Font = new Font("Segoe UI", 20F);
            uniLabel.Location = new Point(10, 0);
            uniLabel.Margin = new Padding(10, 0, 10, 0);
            uniLabel.Name = "uniLabel";
            uniLabel.Size = new Size(669, 55);
            uniLabel.TabIndex = 1;
            uniLabel.Text = "Alle Salg";
            uniLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uniDataGridView
            // 
            uniDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            uniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uniDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            uniDataGridView.Location = new Point(10, 89);
            uniDataGridView.Margin = new Padding(10, 0, 10, 5);
            uniDataGridView.Name = "uniDataGridView";
            uniDataGridView.RowHeadersWidth = 62;
            uniDataGridView.Size = new Size(669, 571);
            uniDataGridView.TabIndex = 2;
            // 
            // UniForside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(uniLayoutPanel);
            Name = "UniForside";
            Size = new Size(689, 663);
            uniLayoutPanel.ResumeLayout(false);
            uniLayoutPanel.PerformLayout();
            uniMenuLayoutPanel.ResumeLayout(false);
            uniMenuLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)uniDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel uniLayoutPanel;
        private TableLayoutPanel uniMenuLayoutPanel;
        private Button uniRegistrerKnap;
        private TextBox uniSøgeFelt;
        private Button uniFilterKnap;
        private Label uniLabel;
        private DataGridView uniDataGridView;
    }
}
