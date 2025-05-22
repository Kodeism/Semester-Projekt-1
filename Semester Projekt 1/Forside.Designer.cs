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
            sumPengeSalgLabel = new Label();
            salgLabel = new Label();
            sumSalgLabel = new Label();
            antalSalgLabel = new Label();
            sælgereLayoutPanel = new TableLayoutPanel();
            boligtypeUdbudtLabel = new Label();
            sælgereLabel = new Label();
            udbudtBoligtypeLabel = new Label();
            sælgereAntalLabel = new Label();
            købereLayoutPanel = new TableLayoutPanel();
            boligtypeEftersøgtLabel = new Label();
            købereLabel = new Label();
            købereAntalLabel = new Label();
            eftersøgtBoligTypeLabel = new Label();
            boligerLayoutPanel = new TableLayoutPanel();
            usolgteBoligerLabel = new Label();
            boligLabel = new Label();
            antalUsolgteBoligerLabel = new Label();
            boligAntalLabel = new Label();
            nyeLayoutPanel = new TableLayoutPanel();
            graphsLayoutPanel = new TableLayoutPanel();
            boligerBoligTypePlot = new ScottPlot.WinForms.FormsPlot();
            køberBoligTypePlot = new ScottPlot.WinForms.FormsPlot();
            nyeKøbere = new DataGridView();
            nyeBoligerLabel = new Label();
            nyeKøberLabel = new Label();
            nyeBoliger = new DataGridView();
            statsBackgroundPanel.SuspendLayout();
            statBoxesLayoutPanel.SuspendLayout();
            salgLayoutPanel.SuspendLayout();
            sælgereLayoutPanel.SuspendLayout();
            købereLayoutPanel.SuspendLayout();
            boligerLayoutPanel.SuspendLayout();
            nyeLayoutPanel.SuspendLayout();
            graphsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nyeKøbere).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nyeBoliger).BeginInit();
            SuspendLayout();
            // 
            // statsBackgroundPanel
            // 
            statsBackgroundPanel.AutoScroll = true;
            statsBackgroundPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            statsBackgroundPanel.BackColor = Color.FromArgb(255, 246, 218);
            statsBackgroundPanel.Controls.Add(statBoxesLayoutPanel);
            statsBackgroundPanel.Dock = DockStyle.Fill;
            statsBackgroundPanel.Location = new Point(3, 3);
            statsBackgroundPanel.Margin = new Padding(2);
            statsBackgroundPanel.Name = "statsBackgroundPanel";
            statsBackgroundPanel.Size = new Size(1246, 147);
            statsBackgroundPanel.TabIndex = 0;
            // 
            // statBoxesLayoutPanel
            // 
            statBoxesLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            statBoxesLayoutPanel.Location = new Point(46, 11);
            statBoxesLayoutPanel.Margin = new Padding(2);
            statBoxesLayoutPanel.Name = "statBoxesLayoutPanel";
            statBoxesLayoutPanel.RowCount = 1;
            statBoxesLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statBoxesLayoutPanel.Size = new Size(1114, 108);
            statBoxesLayoutPanel.TabIndex = 0;
            // 
            // salgLayoutPanel
            // 
            salgLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            salgLayoutPanel.BackColor = Color.FromArgb(176, 176, 176);
            salgLayoutPanel.ColumnCount = 2;
            salgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.3535919F));
            salgLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.6464081F));
            salgLayoutPanel.Controls.Add(sumPengeSalgLabel, 1, 1);
            salgLayoutPanel.Controls.Add(salgLabel, 0, 0);
            salgLayoutPanel.Controls.Add(sumSalgLabel, 0, 1);
            salgLayoutPanel.Controls.Add(antalSalgLabel, 1, 0);
            salgLayoutPanel.Location = new Point(587, 2);
            salgLayoutPanel.Margin = new Padding(2);
            salgLayoutPanel.Name = "salgLayoutPanel";
            salgLayoutPanel.RowCount = 2;
            salgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            salgLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            salgLayoutPanel.Size = new Size(274, 102);
            salgLayoutPanel.TabIndex = 7;
            // 
            // sumPengeSalgLabel
            // 
            sumPengeSalgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sumPengeSalgLabel.AutoSize = true;
            sumPengeSalgLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            sumPengeSalgLabel.Location = new Point(207, 77);
            sumPengeSalgLabel.Name = "sumPengeSalgLabel";
            sumPengeSalgLabel.Size = new Size(64, 25);
            sumPengeSalgLabel.TabIndex = 6;
            sumPengeSalgLabel.Text = "[Antal]";
            sumPengeSalgLabel.TextAlign = ContentAlignment.BottomRight;
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
            // sumSalgLabel
            // 
            sumSalgLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sumSalgLabel.AutoSize = true;
            sumSalgLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            sumSalgLabel.Location = new Point(3, 72);
            sumSalgLabel.Name = "sumSalgLabel";
            sumSalgLabel.Size = new Size(58, 30);
            sumSalgLabel.TabIndex = 5;
            sumSalgLabel.Text = "Sum";
            sumSalgLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // antalSalgLabel
            // 
            antalSalgLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            antalSalgLabel.AutoSize = true;
            antalSalgLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic | FontStyle.Underline);
            antalSalgLabel.Location = new Point(193, 0);
            antalSalgLabel.Name = "antalSalgLabel";
            antalSalgLabel.Size = new Size(78, 51);
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
            sælgereLayoutPanel.Controls.Add(boligtypeUdbudtLabel, 1, 1);
            sælgereLayoutPanel.Controls.Add(sælgereLabel, 0, 0);
            sælgereLayoutPanel.Controls.Add(udbudtBoligtypeLabel, 0, 1);
            sælgereLayoutPanel.Controls.Add(sælgereAntalLabel, 1, 0);
            sælgereLayoutPanel.Location = new Point(392, 2);
            sælgereLayoutPanel.Margin = new Padding(2);
            sælgereLayoutPanel.Name = "sælgereLayoutPanel";
            sælgereLayoutPanel.RowCount = 2;
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            sælgereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            sælgereLayoutPanel.Size = new Size(272, 102);
            sælgereLayoutPanel.TabIndex = 6;
            // 
            // boligtypeUdbudtLabel
            // 
            boligtypeUdbudtLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boligtypeUdbudtLabel.AutoSize = true;
            boligtypeUdbudtLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            boligtypeUdbudtLabel.Location = new Point(173, 77);
            boligtypeUdbudtLabel.Name = "boligtypeUdbudtLabel";
            boligtypeUdbudtLabel.Size = new Size(96, 25);
            boligtypeUdbudtLabel.TabIndex = 5;
            boligtypeUdbudtLabel.Text = "[Boligtype]";
            boligtypeUdbudtLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // sælgereLabel
            // 
            sælgereLabel.AutoSize = true;
            sælgereLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            sælgereLabel.Location = new Point(3, 0);
            sælgereLabel.Name = "sælgereLabel";
            sælgereLabel.Size = new Size(122, 38);
            sælgereLabel.TabIndex = 5;
            sælgereLabel.Text = "Sælgere";
            // 
            // udbudtBoligtypeLabel
            // 
            udbudtBoligtypeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            udbudtBoligtypeLabel.AutoSize = true;
            udbudtBoligtypeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            udbudtBoligtypeLabel.Location = new Point(3, 51);
            udbudtBoligtypeLabel.Name = "udbudtBoligtypeLabel";
            udbudtBoligtypeLabel.Size = new Size(99, 51);
            udbudtBoligtypeLabel.TabIndex = 4;
            udbudtBoligtypeLabel.Text = "Udbudt Type ";
            udbudtBoligtypeLabel.TextAlign = ContentAlignment.BottomLeft;
            // 
            // sælgereAntalLabel
            // 
            sælgereAntalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            sælgereAntalLabel.AutoSize = true;
            sælgereAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic | FontStyle.Underline);
            sælgereAntalLabel.Location = new Point(191, 0);
            sælgereAntalLabel.Name = "sælgereAntalLabel";
            sælgereAntalLabel.Size = new Size(78, 51);
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
            købereLayoutPanel.Controls.Add(boligtypeEftersøgtLabel, 1, 1);
            købereLayoutPanel.Controls.Add(købereLabel, 0, 0);
            købereLayoutPanel.Controls.Add(købereAntalLabel, 1, 0);
            købereLayoutPanel.Controls.Add(eftersøgtBoligTypeLabel, 0, 1);
            købereLayoutPanel.Location = new Point(197, 2);
            købereLayoutPanel.Margin = new Padding(2);
            købereLayoutPanel.Name = "købereLayoutPanel";
            købereLayoutPanel.RowCount = 2;
            købereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            købereLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            købereLayoutPanel.Size = new Size(272, 102);
            købereLayoutPanel.TabIndex = 5;
            // 
            // boligtypeEftersøgtLabel
            // 
            boligtypeEftersøgtLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            boligtypeEftersøgtLabel.AutoSize = true;
            boligtypeEftersøgtLabel.BackColor = Color.FromArgb(164, 236, 142);
            boligtypeEftersøgtLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            boligtypeEftersøgtLabel.Location = new Point(173, 77);
            boligtypeEftersøgtLabel.Name = "boligtypeEftersøgtLabel";
            boligtypeEftersøgtLabel.Size = new Size(96, 25);
            boligtypeEftersøgtLabel.TabIndex = 4;
            boligtypeEftersøgtLabel.Text = "[Boligtype]";
            boligtypeEftersøgtLabel.TextAlign = ContentAlignment.BottomRight;
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
            købereAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic | FontStyle.Underline);
            købereAntalLabel.Location = new Point(191, 0);
            købereAntalLabel.Name = "købereAntalLabel";
            købereAntalLabel.Size = new Size(78, 51);
            købereAntalLabel.TabIndex = 4;
            købereAntalLabel.Text = "[Antal]";
            købereAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // eftersøgtBoligTypeLabel
            // 
            eftersøgtBoligTypeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            eftersøgtBoligTypeLabel.AutoSize = true;
            eftersøgtBoligTypeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            eftersøgtBoligTypeLabel.Location = new Point(3, 51);
            eftersøgtBoligTypeLabel.Name = "eftersøgtBoligTypeLabel";
            eftersøgtBoligTypeLabel.Size = new Size(115, 51);
            eftersøgtBoligTypeLabel.TabIndex = 4;
            eftersøgtBoligTypeLabel.Text = "Eftersøgt Type";
            eftersøgtBoligTypeLabel.TextAlign = ContentAlignment.BottomLeft;
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
            boligerLayoutPanel.Location = new Point(2, 2);
            boligerLayoutPanel.Margin = new Padding(2);
            boligerLayoutPanel.Name = "boligerLayoutPanel";
            boligerLayoutPanel.RowCount = 2;
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            boligerLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            boligerLayoutPanel.Size = new Size(272, 102);
            boligerLayoutPanel.TabIndex = 1;
            boligerLayoutPanel.Click += boligerLayoutPanel_Click;
            // 
            // usolgteBoligerLabel
            // 
            usolgteBoligerLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            usolgteBoligerLabel.AutoSize = true;
            usolgteBoligerLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            usolgteBoligerLabel.Location = new Point(3, 72);
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
            antalUsolgteBoligerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline);
            antalUsolgteBoligerLabel.Location = new Point(205, 77);
            antalUsolgteBoligerLabel.Name = "antalUsolgteBoligerLabel";
            antalUsolgteBoligerLabel.Size = new Size(64, 25);
            antalUsolgteBoligerLabel.TabIndex = 3;
            antalUsolgteBoligerLabel.Text = "[Antal]";
            antalUsolgteBoligerLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // boligAntalLabel
            // 
            boligAntalLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            boligAntalLabel.AutoSize = true;
            boligAntalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Italic | FontStyle.Underline);
            boligAntalLabel.Location = new Point(191, 0);
            boligAntalLabel.Name = "boligAntalLabel";
            boligAntalLabel.Size = new Size(78, 51);
            boligAntalLabel.TabIndex = 1;
            boligAntalLabel.Text = "[Antal]";
            boligAntalLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // nyeLayoutPanel
            // 
            nyeLayoutPanel.AutoScroll = true;
            nyeLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            nyeLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            nyeLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            nyeLayoutPanel.ColumnCount = 1;
            nyeLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            nyeLayoutPanel.Controls.Add(statsBackgroundPanel, 0, 0);
            nyeLayoutPanel.Controls.Add(graphsLayoutPanel, 0, 5);
            nyeLayoutPanel.Controls.Add(nyeKøbere, 0, 4);
            nyeLayoutPanel.Controls.Add(nyeBoligerLabel, 0, 1);
            nyeLayoutPanel.Controls.Add(nyeKøberLabel, 0, 3);
            nyeLayoutPanel.Controls.Add(nyeBoliger, 0, 2);
            nyeLayoutPanel.Dock = DockStyle.Fill;
            nyeLayoutPanel.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            nyeLayoutPanel.Location = new Point(0, 0);
            nyeLayoutPanel.Margin = new Padding(2);
            nyeLayoutPanel.Name = "nyeLayoutPanel";
            nyeLayoutPanel.RowCount = 6;
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.RowStyles.Add(new RowStyle());
            nyeLayoutPanel.Size = new Size(802, 636);
            nyeLayoutPanel.TabIndex = 0;
            // 
            // graphsLayoutPanel
            // 
            graphsLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            graphsLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            graphsLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            graphsLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            graphsLayoutPanel.ColumnCount = 2;
            graphsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.3196335F));
            graphsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.6803665F));
            graphsLayoutPanel.Controls.Add(boligerBoligTypePlot, 1, 0);
            graphsLayoutPanel.Controls.Add(køberBoligTypePlot, 0, 0);
            graphsLayoutPanel.Location = new Point(3, 398);
            graphsLayoutPanel.Margin = new Padding(2);
            graphsLayoutPanel.Name = "graphsLayoutPanel";
            graphsLayoutPanel.RowCount = 1;
            graphsLayoutPanel.RowStyles.Add(new RowStyle());
            graphsLayoutPanel.Size = new Size(872, 870);
            graphsLayoutPanel.TabIndex = 55;
            // 
            // boligerBoligTypePlot
            // 
            boligerBoligTypePlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligerBoligTypePlot.AutoScroll = true;
            boligerBoligTypePlot.AutoSize = true;
            boligerBoligTypePlot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boligerBoligTypePlot.AutoValidate = AutoValidate.EnablePreventFocusChange;
            boligerBoligTypePlot.DisplayScale = 1.5F;
            boligerBoligTypePlot.Location = new Point(397, 3);
            boligerBoligTypePlot.Margin = new Padding(2);
            boligerBoligTypePlot.Name = "boligerBoligTypePlot";
            boligerBoligTypePlot.Size = new Size(472, 864);
            boligerBoligTypePlot.TabIndex = 154;
            // 
            // køberBoligTypePlot
            // 
            køberBoligTypePlot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            køberBoligTypePlot.AutoSize = true;
            køberBoligTypePlot.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            køberBoligTypePlot.BackgroundImageLayout = ImageLayout.None;
            køberBoligTypePlot.DisplayScale = 1.5F;
            køberBoligTypePlot.Location = new Point(3, 3);
            køberBoligTypePlot.Margin = new Padding(2);
            køberBoligTypePlot.Name = "køberBoligTypePlot";
            køberBoligTypePlot.Size = new Size(389, 864);
            køberBoligTypePlot.TabIndex = 345;
            // 
            // nyeKøbere
            // 
            nyeKøbere.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nyeKøbere.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nyeKøbere.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nyeKøbere.Location = new Point(3, 272);
            nyeKøbere.Margin = new Padding(2);
            nyeKøbere.Name = "nyeKøbere";
            nyeKøbere.ReadOnly = true;
            nyeKøbere.RowHeadersWidth = 62;
            nyeKøbere.Size = new Size(872, 121);
            nyeKøbere.TabIndex = 546;
            // 
            // nyeBoligerLabel
            // 
            nyeBoligerLabel.AutoSize = true;
            nyeBoligerLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nyeBoligerLabel.Location = new Point(4, 155);
            nyeBoligerLabel.Name = "nyeBoligerLabel";
            nyeBoligerLabel.Size = new Size(171, 38);
            nyeBoligerLabel.TabIndex = 0;
            nyeBoligerLabel.Text = "Nye Boliger";
            // 
            // nyeKøberLabel
            // 
            nyeKøberLabel.AutoSize = true;
            nyeKøberLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            nyeKøberLabel.Location = new Point(4, 399);
            nyeKøberLabel.Name = "nyeKøberLabel";
            nyeKøberLabel.Size = new Size(116, 25);
            nyeKøberLabel.TabIndex = 3;
            nyeKøberLabel.Text = "Nye Købere";
            // 
            // nyeBoliger
            // 
            nyeBoliger.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nyeBoliger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nyeBoliger.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            nyeBoliger.Location = new Point(3, 122);
            nyeBoliger.Margin = new Padding(2);
            nyeBoliger.Name = "nyeBoliger";
            nyeBoliger.ReadOnly = true;
            nyeBoliger.RowHeadersWidth = 62;
            nyeBoliger.Size = new Size(872, 119);
            nyeBoliger.TabIndex = 1;
            // 
            // Forside
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            Controls.Add(nyeLayoutPanel);
            Margin = new Padding(2);
            Name = "Forside";
            Size = new Size(1146, 1060);
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
            nyeLayoutPanel.ResumeLayout(false);
            nyeLayoutPanel.PerformLayout();
            graphsLayoutPanel.ResumeLayout(false);
            graphsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nyeKøbere).EndInit();
            ((System.ComponentModel.ISupportInitialize)nyeBoliger).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel statsBackgroundPanel;
        private TableLayoutPanel statBoxesLayoutPanel;
        private Label købereLabel;
        private Label eftersøgtBoligTypeLabel;
        private Label købereAntalLabel;
        private Label sælgereLabel;
        private Label boligtypeEftersøgtLabel;
        private Label udbudtBoligtypeLabel;
        private Label sælgereAntalLabel;
        private Label boligtypeUdbudtLabel;
        private Label salgLabel;
        private Label sumSalgLabel;
        private Label antalSalgLabel;
        private Label sumPengeSalgLabel;
        private TableLayoutPanel boligerLayoutPanel;
        private Label usolgteBoligerLabel;
        private Label boligLabel;
        private Label antalUsolgteBoligerLabel;
        private Label boligAntalLabel;
        private TableLayoutPanel købereLayoutPanel;
        private TableLayoutPanel sælgereLayoutPanel;
        private TableLayoutPanel salgLayoutPanel;
        private TableLayoutPanel nyeLayoutPanel;
        private Label nyeBoligerLabel;
        private Label nyeKøberLabel;
        private DataGridView nyeKøbere;
        private DataGridView nyeBoliger;
        private TableLayoutPanel graphsLayoutPanel;
        private ScottPlot.WinForms.FormsPlot boligerBoligTypePlot;
        private ScottPlot.WinForms.FormsPlot køberBoligTypePlot;
    }
}