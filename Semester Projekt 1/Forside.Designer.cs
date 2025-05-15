namespace Semester_Projekt_1
{
    partial class Forside
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
            statsBackgroundPanel = new Panel();
            statBoxesLayoutPanel = new TableLayoutPanel();
            salgLayoutPanel = new TableLayoutPanel();
            antalArealSalgLabel = new Label();
            salgLabel = new Label();
            arealSalgLabel = new Label();
            antalSalgLabel = new Label();
            sælgereLayoutPanel = new TableLayoutPanel();
            antalSalgsklarLabel = new Label();
            sælgereLabel = new Label();
            salgsklarLabel = new Label();
            sælgereAntalLabel = new Label();
            købereLayoutPanel = new TableLayoutPanel();
            søgereAntalLabel = new Label();
            købereLabel = new Label();
            købereAntalLabel = new Label();
            købereSøgereLabel = new Label();
            boligerLayoutPanel = new TableLayoutPanel();
            usolgteBoligerLabel = new Label();
            boligLabel = new Label();
            antalUsolgteBoligerLabel = new Label();
            boligAntalLabel = new Label();
            graphsLayoutPanel = new TableLayoutPanel();
            køberBoligTypePlot = new ScottPlot.WinForms.FormsPlot();
            boligerBoligTypePlot = new ScottPlot.WinForms.FormsPlot();
            salgsPrisBoligTypeÅr = new ScottPlot.WinForms.FormsPlot();
            boligSalgÅrPlot = new ScottPlot.WinForms.FormsPlot();
            statsBackgroundPanel.SuspendLayout();
            statBoxesLayoutPanel.SuspendLayout();
            salgLayoutPanel.SuspendLayout();
            sælgereLayoutPanel.SuspendLayout();
            købereLayoutPanel.SuspendLayout();
            boligerLayoutPanel.SuspendLayout();
            graphsLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statsBackgroundPanel
            // 
            statsBackgroundPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            statsBackgroundPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statsBackgroundPanel.BackColor = Color.FromArgb(255, 246, 218);
            statsBackgroundPanel.Controls.Add(statBoxesLayoutPanel);
            statsBackgroundPanel.Location = new Point(0, 0);
            statsBackgroundPanel.Name = "statsBackgroundPanel";
            statsBackgroundPanel.Size = new Size(985, 147);
            statsBackgroundPanel.TabIndex = 0;
            // 
            // statBoxesLayoutPanel
            // 
            statBoxesLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            statBoxesLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statBoxesLayoutPanel.ColumnCount = 4;
            statBoxesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statBoxesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statBoxesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statBoxesLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            statBoxesLayoutPanel.Controls.Add(salgLayoutPanel, 3, 0);
            statBoxesLayoutPanel.Controls.Add(sælgereLayoutPanel, 2, 0);
            statBoxesLayoutPanel.Controls.Add(købereLayoutPanel, 1, 0);
            statBoxesLayoutPanel.Controls.Add(boligerLayoutPanel, 0, 0);
            statBoxesLayoutPanel.Location = new Point(47, 19);
            statBoxesLayoutPanel.Name = "statBoxesLayoutPanel";
            statBoxesLayoutPanel.RowCount = 1;
            statBoxesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statBoxesLayoutPanel.Size = new Size(890, 109);
            statBoxesLayoutPanel.TabIndex = 0;
            // 
            // salgLayoutPanel
            // 
            salgLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salgLayoutPanel.BackColor = Color.FromArgb(176, 176, 176);
            salgLayoutPanel.ColumnCount = 2;
            salgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3535919F));
            salgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6464081F));
            salgLayoutPanel.Controls.Add(antalArealSalgLabel, 1, 1);
            salgLayoutPanel.Controls.Add(salgLabel, 0, 0);
            salgLayoutPanel.Controls.Add(arealSalgLabel, 0, 1);
            salgLayoutPanel.Controls.Add(antalSalgLabel, 1, 0);
            salgLayoutPanel.Location = new Point(669, 3);
            salgLayoutPanel.Name = "salgLayoutPanel";
            salgLayoutPanel.RowCount = 2;
            salgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            salgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            salgLayoutPanel.Size = new Size(218, 103);
            salgLayoutPanel.TabIndex = 7;
            // 
            // antalArealSalgLabel
            // 
            antalArealSalgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            antalArealSalgLabel.AutoSize = true;
            antalArealSalgLabel.Font = new Font("Segoe UI", 9F);
            antalArealSalgLabel.Location = new Point(152, 78);
            antalArealSalgLabel.Name = "antalArealSalgLabel";
            antalArealSalgLabel.Size = new Size(63, 25);
            antalArealSalgLabel.TabIndex = 6;
            antalArealSalgLabel.Text = "[Antal]";
            antalArealSalgLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // salgLabel
            // 
            salgLabel.AutoSize = true;
            salgLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            salgLabel.Location = new Point(3, 0);
            salgLabel.Name = "salgLabel";
            salgLabel.Size = new Size(73, 38);
            salgLabel.TabIndex = 6;
            salgLabel.Text = "Salg";
            // 
            // arealSalgLabel
            // 
            arealSalgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            arealSalgLabel.AutoSize = true;
            arealSalgLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            arealSalgLabel.Location = new Point(3, 73);
            arealSalgLabel.Name = "arealSalgLabel";
            arealSalgLabel.Size = new Size(67, 30);
            arealSalgLabel.TabIndex = 5;
            arealSalgLabel.Text = "Areal";
            arealSalgLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // antalSalgLabel
            // 
            antalSalgLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            antalSalgLabel.AutoSize = true;
            antalSalgLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
            antalSalgLabel.Location = new Point(131, 0);
            antalSalgLabel.Name = "antalSalgLabel";
            antalSalgLabel.Size = new Size(84, 51);
            antalSalgLabel.TabIndex = 6;
            antalSalgLabel.Text = "[Antal]";
            antalSalgLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // sælgereLayoutPanel
            // 
            sælgereLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgereLayoutPanel.BackColor = Color.FromArgb(160, 246, 164);
            sælgereLayoutPanel.ColumnCount = 2;
            sælgereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3535919F));
            sælgereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6464081F));
            sælgereLayoutPanel.Controls.Add(antalSalgsklarLabel, 1, 1);
            sælgereLayoutPanel.Controls.Add(sælgereLabel, 0, 0);
            sælgereLayoutPanel.Controls.Add(salgsklarLabel, 0, 1);
            sælgereLayoutPanel.Controls.Add(sælgereAntalLabel, 1, 0);
            sælgereLayoutPanel.Location = new Point(447, 3);
            sælgereLayoutPanel.Name = "sælgereLayoutPanel";
            sælgereLayoutPanel.RowCount = 2;
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sælgereLayoutPanel.Size = new Size(216, 103);
            sælgereLayoutPanel.TabIndex = 6;
            // 
            // antalSalgsklarLabel
            // 
            antalSalgsklarLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            antalSalgsklarLabel.AutoSize = true;
            antalSalgsklarLabel.Font = new Font("Segoe UI", 9F);
            antalSalgsklarLabel.Location = new Point(150, 78);
            antalSalgsklarLabel.Name = "antalSalgsklarLabel";
            antalSalgsklarLabel.Size = new Size(63, 25);
            antalSalgsklarLabel.TabIndex = 5;
            antalSalgsklarLabel.Text = "[Antal]";
            antalSalgsklarLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // sælgereLabel
            // 
            sælgereLabel.AutoSize = true;
            sælgereLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sælgereLabel.Location = new Point(3, 0);
            sælgereLabel.Name = "sælgereLabel";
            sælgereLabel.Size = new Size(107, 51);
            sælgereLabel.TabIndex = 5;
            sælgereLabel.Text = "Sælgere";
            // 
            // salgsklarLabel
            // 
            salgsklarLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            salgsklarLabel.AutoSize = true;
            salgsklarLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            salgsklarLabel.Location = new Point(3, 73);
            salgsklarLabel.Name = "salgsklarLabel";
            salgsklarLabel.Size = new Size(106, 30);
            salgsklarLabel.TabIndex = 4;
            salgsklarLabel.Text = "Salgsklar";
            salgsklarLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // sælgereAntalLabel
            // 
            sælgereAntalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sælgereAntalLabel.AutoSize = true;
            sælgereAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
            sælgereAntalLabel.Location = new Point(129, 0);
            sælgereAntalLabel.Name = "sælgereAntalLabel";
            sælgereAntalLabel.Size = new Size(84, 51);
            sælgereAntalLabel.TabIndex = 5;
            sælgereAntalLabel.Text = "[Antal]";
            sælgereAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // købereLayoutPanel
            // 
            købereLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            købereLayoutPanel.BackColor = Color.FromArgb(164, 236, 142);
            købereLayoutPanel.ColumnCount = 2;
            købereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3535919F));
            købereLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6464081F));
            købereLayoutPanel.Controls.Add(søgereAntalLabel, 1, 1);
            købereLayoutPanel.Controls.Add(købereLabel, 0, 0);
            købereLayoutPanel.Controls.Add(købereAntalLabel, 1, 0);
            købereLayoutPanel.Controls.Add(købereSøgereLabel, 0, 1);
            købereLayoutPanel.Location = new Point(225, 3);
            købereLayoutPanel.Name = "købereLayoutPanel";
            købereLayoutPanel.RowCount = 2;
            købereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            købereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            købereLayoutPanel.Size = new Size(216, 103);
            købereLayoutPanel.TabIndex = 5;
            // 
            // søgereAntalLabel
            // 
            søgereAntalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            søgereAntalLabel.AutoSize = true;
            søgereAntalLabel.BackColor = Color.FromArgb(164, 236, 142);
            søgereAntalLabel.Font = new Font("Segoe UI", 9F);
            søgereAntalLabel.Location = new Point(150, 78);
            søgereAntalLabel.Name = "søgereAntalLabel";
            søgereAntalLabel.Size = new Size(63, 25);
            søgereAntalLabel.TabIndex = 4;
            søgereAntalLabel.Text = "[Antal]";
            søgereAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // købereLabel
            // 
            købereLabel.AutoSize = true;
            købereLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            købereLabel.Location = new Point(3, 0);
            købereLabel.Name = "købereLabel";
            købereLabel.Size = new Size(110, 38);
            købereLabel.TabIndex = 4;
            købereLabel.Text = "Købere";
            // 
            // købereAntalLabel
            // 
            købereAntalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            købereAntalLabel.AutoSize = true;
            købereAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
            købereAntalLabel.Location = new Point(129, 0);
            købereAntalLabel.Name = "købereAntalLabel";
            købereAntalLabel.Size = new Size(84, 51);
            købereAntalLabel.TabIndex = 4;
            købereAntalLabel.Text = "[Antal]";
            købereAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // købereSøgereLabel
            // 
            købereSøgereLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            købereSøgereLabel.AutoSize = true;
            købereSøgereLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            købereSøgereLabel.Location = new Point(3, 73);
            købereSøgereLabel.Name = "købereSøgereLabel";
            købereSøgereLabel.Size = new Size(103, 30);
            købereSøgereLabel.TabIndex = 4;
            købereSøgereLabel.Text = "Købsklar";
            købereSøgereLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // boligerLayoutPanel
            // 
            boligerLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligerLayoutPanel.BackColor = Color.FromArgb(253, 187, 131);
            boligerLayoutPanel.ColumnCount = 2;
            boligerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3535919F));
            boligerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6464081F));
            boligerLayoutPanel.Controls.Add(usolgteBoligerLabel, 0, 1);
            boligerLayoutPanel.Controls.Add(boligLabel, 0, 0);
            boligerLayoutPanel.Controls.Add(antalUsolgteBoligerLabel, 1, 1);
            boligerLayoutPanel.Controls.Add(boligAntalLabel, 1, 0);
            boligerLayoutPanel.Location = new Point(3, 3);
            boligerLayoutPanel.Name = "boligerLayoutPanel";
            boligerLayoutPanel.RowCount = 2;
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            boligerLayoutPanel.Size = new Size(216, 103);
            boligerLayoutPanel.TabIndex = 1;
            // 
            // usolgteBoligerLabel
            // 
            usolgteBoligerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            usolgteBoligerLabel.AutoSize = true;
            usolgteBoligerLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            usolgteBoligerLabel.Location = new Point(3, 73);
            usolgteBoligerLabel.Name = "usolgteBoligerLabel";
            usolgteBoligerLabel.Size = new Size(93, 30);
            usolgteBoligerLabel.TabIndex = 2;
            usolgteBoligerLabel.Text = "Usolgte";
            usolgteBoligerLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // boligLabel
            // 
            boligLabel.AutoSize = true;
            boligLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            boligLabel.Location = new Point(3, 0);
            boligLabel.Name = "boligLabel";
            boligLabel.Size = new Size(111, 38);
            boligLabel.TabIndex = 0;
            boligLabel.Text = "Boliger";
            // 
            // antalUsolgteBoligerLabel
            // 
            antalUsolgteBoligerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            antalUsolgteBoligerLabel.AutoSize = true;
            antalUsolgteBoligerLabel.Font = new Font("Segoe UI", 9F);
            antalUsolgteBoligerLabel.Location = new Point(150, 78);
            antalUsolgteBoligerLabel.Name = "antalUsolgteBoligerLabel";
            antalUsolgteBoligerLabel.Size = new Size(63, 25);
            antalUsolgteBoligerLabel.TabIndex = 3;
            antalUsolgteBoligerLabel.Text = "[Antal]";
            antalUsolgteBoligerLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // boligAntalLabel
            // 
            boligAntalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boligAntalLabel.AutoSize = true;
            boligAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline);
            boligAntalLabel.Location = new Point(129, 0);
            boligAntalLabel.Name = "boligAntalLabel";
            boligAntalLabel.Size = new Size(84, 51);
            boligAntalLabel.TabIndex = 1;
            boligAntalLabel.Text = "[Antal]";
            boligAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // graphsLayoutPanel
            // 
            graphsLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            graphsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            graphsLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            graphsLayoutPanel.ColumnCount = 2;
            graphsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            graphsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            graphsLayoutPanel.Controls.Add(køberBoligTypePlot, 0, 0);
            graphsLayoutPanel.Controls.Add(boligerBoligTypePlot, 1, 0);
            graphsLayoutPanel.Controls.Add(salgsPrisBoligTypeÅr, 0, 1);
            graphsLayoutPanel.Controls.Add(boligSalgÅrPlot, 1, 1);
            graphsLayoutPanel.Location = new Point(0, 153);
            graphsLayoutPanel.Name = "graphsLayoutPanel";
            graphsLayoutPanel.RowCount = 2;
            graphsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            graphsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            graphsLayoutPanel.Size = new Size(985, 589);
            graphsLayoutPanel.TabIndex = 0;
            // 
            // køberBoligTypePlot
            // 
            køberBoligTypePlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            køberBoligTypePlot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            køberBoligTypePlot.BackgroundImageLayout = ImageLayout.None;
            køberBoligTypePlot.DisplayScale = 1.5F;
            køberBoligTypePlot.Location = new Point(3, 3);
            køberBoligTypePlot.Name = "køberBoligTypePlot";
            køberBoligTypePlot.Size = new Size(486, 386);
            køberBoligTypePlot.TabIndex = 0;
            // 
            // boligerBoligTypePlot
            // 
            boligerBoligTypePlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligerBoligTypePlot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boligerBoligTypePlot.DisplayScale = 1.5F;
            boligerBoligTypePlot.Location = new Point(495, 3);
            boligerBoligTypePlot.Name = "boligerBoligTypePlot";
            boligerBoligTypePlot.Size = new Size(487, 386);
            boligerBoligTypePlot.TabIndex = 2;
            // 
            // salgsPrisBoligTypeÅr
            // 
            salgsPrisBoligTypeÅr.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgsPrisBoligTypeÅr.DisplayScale = 1.5F;
            salgsPrisBoligTypeÅr.Dock = DockStyle.Fill;
            salgsPrisBoligTypeÅr.Location = new Point(3, 395);
            salgsPrisBoligTypeÅr.Name = "salgsPrisBoligTypeÅr";
            salgsPrisBoligTypeÅr.Size = new Size(486, 191);
            salgsPrisBoligTypeÅr.TabIndex = 3;
            // 
            // boligSalgÅrPlot
            // 
            boligSalgÅrPlot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boligSalgÅrPlot.DisplayScale = 1.5F;
            boligSalgÅrPlot.Dock = DockStyle.Fill;
            boligSalgÅrPlot.Location = new Point(495, 395);
            boligSalgÅrPlot.Name = "boligSalgÅrPlot";
            boligSalgÅrPlot.Size = new Size(487, 191);
            boligSalgÅrPlot.TabIndex = 4;
            // 
            // Forside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(985, 860);
            Controls.Add(graphsLayoutPanel);
            Controls.Add(statsBackgroundPanel);
            Name = "Forside";
            Load += Forside_Load;
            Resize += Forside_Resize;
            statsBackgroundPanel.ResumeLayout(false);
            statBoxesLayoutPanel.ResumeLayout(false);
            salgLayoutPanel.ResumeLayout(false);
            salgLayoutPanel.PerformLayout();
            sælgereLayoutPanel.ResumeLayout(false);
            sælgereLayoutPanel.PerformLayout();
            købereLayoutPanel.ResumeLayout(false);
            købereLayoutPanel.PerformLayout();
            boligerLayoutPanel.ResumeLayout(false);
            boligerLayoutPanel.PerformLayout();
            graphsLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel statsBackgroundPanel;
        private TableLayoutPanel statBoxesLayoutPanel;
        private Label købereLabel;
        private Label købereSøgereLabel;
        private Label købereAntalLabel;
        private Label sælgereLabel;
        private Label søgereAntalLabel;
        private Label salgsklarLabel;
        private Label sælgereAntalLabel;
        private Label antalSalgsklarLabel;
        private Label salgLabel;
        private Label arealSalgLabel;
        private Label antalSalgLabel;
        private Label antalArealSalgLabel;
        private TableLayoutPanel boligerLayoutPanel;
        private Label usolgteBoligerLabel;
        private Label boligLabel;
        private Label antalUsolgteBoligerLabel;
        private Label boligAntalLabel;
        private TableLayoutPanel købereLayoutPanel;
        private TableLayoutPanel sælgereLayoutPanel;
        private TableLayoutPanel salgLayoutPanel;
        private TableLayoutPanel graphsLayoutPanel;
        private ScottPlot.WinForms.FormsPlot køberBoligTypePlot;
        private ScottPlot.WinForms.FormsPlot boligerBoligTypePlot;
        private ScottPlot.WinForms.FormsPlot salgsPrisBoligTypeÅr;
        private ScottPlot.WinForms.FormsPlot boligSalgÅrPlot;
    }
}