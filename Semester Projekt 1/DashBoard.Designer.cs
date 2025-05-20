namespace Semester_Projekt_1
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            startDBKnap = new Button();
            pageLabel = new Label();
            logUdDBKnap = new Button();
            menuDBLayoutPanel = new TableLayoutPanel();
            personDBPanel = new FlowLayoutPanel();
            personDBKnap = new Button();
            mæglerDBKnap = new Button();
            personLayOutDBPanel = new TableLayoutPanel();
            sælgerDBPanel = new FlowLayoutPanel();
            sælgereDBKnap = new Button();
            mineSælgereDBKnap = new Button();
            alleSælgereDBKnap = new Button();
            registrerDBKnap = new Button();
            køberDBPanel = new FlowLayoutPanel();
            køberDBKnap = new Button();
            mineKøbereDBKnap = new Button();
            alleKøbereDBKnap = new Button();
            registrerKøberDBKnap = new Button();
            salgDBPanel = new FlowLayoutPanel();
            salgDBKnap = new Button();
            mineSalgDBKnap = new Button();
            alleSalgDBKnap = new Button();
            salgRegistrerDBKnap = new Button();
            boligDBPanel = new FlowLayoutPanel();
            boligDBKnap = new Button();
            mineBoligerDBKnap = new Button();
            alleBolgierDBKnap = new Button();
            boligerRegistrerDBKnap = new Button();
            brugerDBKnap = new Button();
            screenDBPanel = new Panel();
            brugerLayoutPanel = new TableLayoutPanel();
            brugerNavnLabel = new Label();
            uDBLayoutPanel = new TableLayoutPanel();
            lDBLayoutPanel = new TableLayoutPanel();
            menuDBLayoutPanel.SuspendLayout();
            personDBPanel.SuspendLayout();
            personLayOutDBPanel.SuspendLayout();
            sælgerDBPanel.SuspendLayout();
            køberDBPanel.SuspendLayout();
            salgDBPanel.SuspendLayout();
            boligDBPanel.SuspendLayout();
            brugerLayoutPanel.SuspendLayout();
            uDBLayoutPanel.SuspendLayout();
            lDBLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startDBKnap
            // 
            startDBKnap.BackColor = Color.FromArgb(198, 220, 255);
            startDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            startDBKnap.Dock = DockStyle.Fill;
            startDBKnap.FlatStyle = FlatStyle.Flat;
            startDBKnap.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            startDBKnap.ForeColor = Color.Black;
            startDBKnap.ImageAlign = ContentAlignment.BottomLeft;
            startDBKnap.Location = new Point(0, 0);
            startDBKnap.Margin = new Padding(0);
            startDBKnap.Name = "startDBKnap";
            startDBKnap.Size = new Size(146, 63);
            startDBKnap.TabIndex = 5;
            startDBKnap.Text = "Start";
            startDBKnap.UseVisualStyleBackColor = false;
            startDBKnap.Click += startDBKnap_Click;
            // 
            // pageLabel
            // 
            pageLabel.AutoSize = true;
            pageLabel.BorderStyle = BorderStyle.FixedSingle;
            pageLabel.Dock = DockStyle.Fill;
            pageLabel.FlatStyle = FlatStyle.Flat;
            pageLabel.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            pageLabel.Location = new Point(146, 0);
            pageLabel.Margin = new Padding(0);
            pageLabel.Name = "pageLabel";
            pageLabel.Size = new Size(694, 63);
            pageLabel.TabIndex = 0;
            pageLabel.Text = "Velkommen";
            pageLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logUdDBKnap
            // 
            logUdDBKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logUdDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            logUdDBKnap.BackColor = Color.FromArgb(255, 100, 100);
            logUdDBKnap.BackgroundImage = Properties.Resources.image__22_;
            logUdDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            logUdDBKnap.FlatAppearance.BorderColor = Color.Black;
            logUdDBKnap.FlatStyle = FlatStyle.Flat;
            logUdDBKnap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logUdDBKnap.ForeColor = Color.Black;
            logUdDBKnap.ImageAlign = ContentAlignment.MiddleLeft;
            logUdDBKnap.Location = new Point(4, 183);
            logUdDBKnap.MaximumSize = new Size(139, 52);
            logUdDBKnap.MinimumSize = new Size(139, 52);
            logUdDBKnap.Name = "logUdDBKnap";
            logUdDBKnap.RightToLeft = RightToLeft.No;
            logUdDBKnap.Size = new Size(139, 52);
            logUdDBKnap.TabIndex = 1;
            logUdDBKnap.TextAlign = ContentAlignment.MiddleRight;
            logUdDBKnap.UseVisualStyleBackColor = false;
            logUdDBKnap.Click += logUdDBKnap_Click;
            // 
            // menuDBLayoutPanel
            // 
            menuDBLayoutPanel.AutoSize = true;
            menuDBLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            menuDBLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            menuDBLayoutPanel.ColumnCount = 1;
            menuDBLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            menuDBLayoutPanel.Controls.Add(personDBPanel, 0, 1);
            menuDBLayoutPanel.Controls.Add(salgDBPanel, 0, 2);
            menuDBLayoutPanel.Controls.Add(logUdDBKnap, 0, 3);
            menuDBLayoutPanel.Controls.Add(boligDBPanel, 0, 0);
            menuDBLayoutPanel.Location = new Point(1, 167);
            menuDBLayoutPanel.Margin = new Padding(0);
            menuDBLayoutPanel.MaximumSize = new Size(144, 0);
            menuDBLayoutPanel.MinimumSize = new Size(144, 233);
            menuDBLayoutPanel.Name = "menuDBLayoutPanel";
            menuDBLayoutPanel.RowCount = 4;
            menuDBLayoutPanel.RowStyles.Add(new RowStyle());
            menuDBLayoutPanel.RowStyles.Add(new RowStyle());
            menuDBLayoutPanel.RowStyles.Add(new RowStyle());
            menuDBLayoutPanel.RowStyles.Add(new RowStyle());
            menuDBLayoutPanel.Size = new Size(144, 239);
            menuDBLayoutPanel.TabIndex = 0;
            // 
            // personDBPanel
            // 
            personDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            personDBPanel.Controls.Add(personDBKnap);
            personDBPanel.Controls.Add(mæglerDBKnap);
            personDBPanel.Controls.Add(personLayOutDBPanel);
            personDBPanel.Location = new Point(4, 63);
            personDBPanel.MaximumSize = new Size(139, 322);
            personDBPanel.MinimumSize = new Size(139, 52);
            personDBPanel.Name = "personDBPanel";
            personDBPanel.Size = new Size(139, 52);
            personDBPanel.TabIndex = 4;
            // 
            // personDBKnap
            // 
            personDBKnap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            personDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            personDBKnap.BackColor = Color.FromArgb(164, 236, 142);
            personDBKnap.BackgroundImage = Properties.Resources._8503b364be6ba9825ae617c947fa5280;
            personDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            personDBKnap.FlatStyle = FlatStyle.Flat;
            personDBKnap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            personDBKnap.ForeColor = Color.Black;
            personDBKnap.Location = new Point(0, 0);
            personDBKnap.Margin = new Padding(0);
            personDBKnap.MaximumSize = new Size(139, 52);
            personDBKnap.MinimumSize = new Size(139, 52);
            personDBKnap.Name = "personDBKnap";
            personDBKnap.RightToLeft = RightToLeft.No;
            personDBKnap.Size = new Size(139, 52);
            personDBKnap.TabIndex = 3;
            personDBKnap.TextAlign = ContentAlignment.MiddleRight;
            personDBKnap.UseVisualStyleBackColor = false;
            personDBKnap.Click += personDBKnap_Click;
            // 
            // mæglerDBKnap
            // 
            mæglerDBKnap.Anchor = AnchorStyles.None;
            mæglerDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            mæglerDBKnap.BackgroundImageLayout = ImageLayout.None;
            mæglerDBKnap.FlatAppearance.BorderSize = 0;
            mæglerDBKnap.FlatStyle = FlatStyle.Flat;
            mæglerDBKnap.Font = new Font("Segoe UI", 8F);
            mæglerDBKnap.ForeColor = Color.Black;
            mæglerDBKnap.Location = new Point(0, 52);
            mæglerDBKnap.Margin = new Padding(0);
            mæglerDBKnap.MaximumSize = new Size(139, 30);
            mæglerDBKnap.MinimumSize = new Size(139, 30);
            mæglerDBKnap.Name = "mæglerDBKnap";
            mæglerDBKnap.RightToLeft = RightToLeft.No;
            mæglerDBKnap.Size = new Size(139, 30);
            mæglerDBKnap.TabIndex = 13;
            mæglerDBKnap.Text = "Mæglere";
            mæglerDBKnap.TextAlign = ContentAlignment.TopLeft;
            mæglerDBKnap.UseVisualStyleBackColor = false;
            mæglerDBKnap.Click += mæglerDBKnap_Click;
            // 
            // personLayOutDBPanel
            // 
            personLayOutDBPanel.Anchor = AnchorStyles.None;
            personLayOutDBPanel.AutoSize = true;
            personLayOutDBPanel.ColumnCount = 1;
            personLayOutDBPanel.ColumnStyles.Add(new ColumnStyle());
            personLayOutDBPanel.Controls.Add(sælgerDBPanel, 0, 0);
            personLayOutDBPanel.Controls.Add(køberDBPanel, 0, 1);
            personLayOutDBPanel.Location = new Point(0, 82);
            personLayOutDBPanel.Margin = new Padding(0);
            personLayOutDBPanel.MaximumSize = new Size(139, 300);
            personLayOutDBPanel.MinimumSize = new Size(139, 52);
            personLayOutDBPanel.Name = "personLayOutDBPanel";
            personLayOutDBPanel.RowCount = 2;
            personLayOutDBPanel.RowStyles.Add(new RowStyle());
            personLayOutDBPanel.RowStyles.Add(new RowStyle());
            personLayOutDBPanel.Size = new Size(139, 62);
            personLayOutDBPanel.TabIndex = 7;
            // 
            // sælgerDBPanel
            // 
            sælgerDBPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sælgerDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgerDBPanel.Controls.Add(sælgereDBKnap);
            sælgerDBPanel.Controls.Add(mineSælgereDBKnap);
            sælgerDBPanel.Controls.Add(alleSælgereDBKnap);
            sælgerDBPanel.Controls.Add(registrerDBKnap);
            sælgerDBPanel.Location = new Point(0, 0);
            sælgerDBPanel.Margin = new Padding(0);
            sælgerDBPanel.MaximumSize = new Size(139, 120);
            sælgerDBPanel.MinimumSize = new Size(139, 32);
            sælgerDBPanel.Name = "sælgerDBPanel";
            sælgerDBPanel.Size = new Size(139, 32);
            sælgerDBPanel.TabIndex = 6;
            // 
            // sælgereDBKnap
            // 
            sælgereDBKnap.Anchor = AnchorStyles.None;
            sælgereDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sælgereDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            sælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            sælgereDBKnap.FlatAppearance.BorderSize = 0;
            sælgereDBKnap.FlatStyle = FlatStyle.Flat;
            sælgereDBKnap.Font = new Font("Segoe UI", 8F);
            sælgereDBKnap.ForeColor = Color.Black;
            sælgereDBKnap.Image = Properties.Resources.Drop_down_arrow_icon_rounded;
            sælgereDBKnap.ImageAlign = ContentAlignment.BottomRight;
            sælgereDBKnap.Location = new Point(0, 0);
            sælgereDBKnap.Margin = new Padding(0);
            sælgereDBKnap.MaximumSize = new Size(139, 30);
            sælgereDBKnap.MinimumSize = new Size(139, 30);
            sælgereDBKnap.Name = "sælgereDBKnap";
            sælgereDBKnap.RightToLeft = RightToLeft.No;
            sælgereDBKnap.Size = new Size(139, 30);
            sælgereDBKnap.TabIndex = 5;
            sælgereDBKnap.Text = "Sælgere";
            sælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            sælgereDBKnap.UseVisualStyleBackColor = false;
            sælgereDBKnap.Click += sælgereDBKnap_Click;
            // 
            // mineSælgereDBKnap
            // 
            mineSælgereDBKnap.Anchor = AnchorStyles.None;
            mineSælgereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            mineSælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineSælgereDBKnap.FlatAppearance.BorderSize = 0;
            mineSælgereDBKnap.FlatStyle = FlatStyle.Flat;
            mineSælgereDBKnap.Font = new Font("Segoe UI", 8F);
            mineSælgereDBKnap.ForeColor = Color.Black;
            mineSælgereDBKnap.Location = new Point(0, 30);
            mineSælgereDBKnap.Margin = new Padding(0);
            mineSælgereDBKnap.MaximumSize = new Size(139, 30);
            mineSælgereDBKnap.MinimumSize = new Size(139, 30);
            mineSælgereDBKnap.Name = "mineSælgereDBKnap";
            mineSælgereDBKnap.RightToLeft = RightToLeft.No;
            mineSælgereDBKnap.Size = new Size(139, 30);
            mineSælgereDBKnap.TabIndex = 6;
            mineSælgereDBKnap.Text = "Mine Sælgere";
            mineSælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineSælgereDBKnap.UseVisualStyleBackColor = false;
            mineSælgereDBKnap.Click += mineSælgereDBKnap_Click;
            // 
            // alleSælgereDBKnap
            // 
            alleSælgereDBKnap.Anchor = AnchorStyles.None;
            alleSælgereDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            alleSælgereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            alleSælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleSælgereDBKnap.FlatAppearance.BorderSize = 0;
            alleSælgereDBKnap.FlatStyle = FlatStyle.Flat;
            alleSælgereDBKnap.Font = new Font("Segoe UI", 8F);
            alleSælgereDBKnap.ForeColor = Color.Black;
            alleSælgereDBKnap.Location = new Point(0, 60);
            alleSælgereDBKnap.Margin = new Padding(0);
            alleSælgereDBKnap.MaximumSize = new Size(139, 30);
            alleSælgereDBKnap.MinimumSize = new Size(139, 30);
            alleSælgereDBKnap.Name = "alleSælgereDBKnap";
            alleSælgereDBKnap.RightToLeft = RightToLeft.No;
            alleSælgereDBKnap.Size = new Size(139, 30);
            alleSælgereDBKnap.TabIndex = 7;
            alleSælgereDBKnap.Text = "Alle Sælgere";
            alleSælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleSælgereDBKnap.UseVisualStyleBackColor = false;
            alleSælgereDBKnap.Click += alleSælgereDBKnap_Click;
            // 
            // registrerDBKnap
            // 
            registrerDBKnap.Anchor = AnchorStyles.None;
            registrerDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            registrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            registrerDBKnap.FlatAppearance.BorderSize = 0;
            registrerDBKnap.FlatStyle = FlatStyle.Flat;
            registrerDBKnap.Font = new Font("Segoe UI", 8F);
            registrerDBKnap.ForeColor = Color.Black;
            registrerDBKnap.Location = new Point(0, 90);
            registrerDBKnap.Margin = new Padding(0);
            registrerDBKnap.MaximumSize = new Size(139, 30);
            registrerDBKnap.MinimumSize = new Size(139, 30);
            registrerDBKnap.Name = "registrerDBKnap";
            registrerDBKnap.RightToLeft = RightToLeft.No;
            registrerDBKnap.Size = new Size(139, 30);
            registrerDBKnap.TabIndex = 8;
            registrerDBKnap.Text = "Registrer";
            registrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            registrerDBKnap.UseVisualStyleBackColor = false;
            registrerDBKnap.Click += registrerDBKnap_Click;
            // 
            // køberDBPanel
            // 
            køberDBPanel.Anchor = AnchorStyles.None;
            køberDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            køberDBPanel.Controls.Add(køberDBKnap);
            køberDBPanel.Controls.Add(mineKøbereDBKnap);
            køberDBPanel.Controls.Add(alleKøbereDBKnap);
            køberDBPanel.Controls.Add(registrerKøberDBKnap);
            køberDBPanel.Location = new Point(0, 32);
            køberDBPanel.Margin = new Padding(0);
            køberDBPanel.MaximumSize = new Size(139, 120);
            køberDBPanel.MinimumSize = new Size(139, 30);
            køberDBPanel.Name = "køberDBPanel";
            køberDBPanel.Size = new Size(139, 30);
            køberDBPanel.TabIndex = 7;
            // 
            // køberDBKnap
            // 
            køberDBKnap.Anchor = AnchorStyles.None;
            køberDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            køberDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            køberDBKnap.BackgroundImageLayout = ImageLayout.None;
            køberDBKnap.FlatAppearance.BorderSize = 0;
            køberDBKnap.FlatStyle = FlatStyle.Flat;
            køberDBKnap.Font = new Font("Segoe UI", 8F);
            køberDBKnap.ForeColor = Color.Black;
            køberDBKnap.Image = Properties.Resources.Drop_down_arrow_icon_rounded;
            køberDBKnap.ImageAlign = ContentAlignment.BottomRight;
            køberDBKnap.Location = new Point(0, 0);
            køberDBKnap.Margin = new Padding(0);
            køberDBKnap.MaximumSize = new Size(139, 30);
            køberDBKnap.MinimumSize = new Size(139, 30);
            køberDBKnap.Name = "køberDBKnap";
            køberDBKnap.RightToLeft = RightToLeft.No;
            køberDBKnap.Size = new Size(139, 30);
            køberDBKnap.TabIndex = 9;
            køberDBKnap.Text = "Købere";
            køberDBKnap.TextAlign = ContentAlignment.TopLeft;
            køberDBKnap.UseVisualStyleBackColor = false;
            køberDBKnap.Click += køberDBKnap_Click;
            // 
            // mineKøbereDBKnap
            // 
            mineKøbereDBKnap.Anchor = AnchorStyles.None;
            mineKøbereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            mineKøbereDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineKøbereDBKnap.FlatAppearance.BorderSize = 0;
            mineKøbereDBKnap.FlatStyle = FlatStyle.Flat;
            mineKøbereDBKnap.Font = new Font("Segoe UI", 8F);
            mineKøbereDBKnap.ForeColor = Color.Black;
            mineKøbereDBKnap.Location = new Point(0, 30);
            mineKøbereDBKnap.Margin = new Padding(0);
            mineKøbereDBKnap.MaximumSize = new Size(139, 30);
            mineKøbereDBKnap.MinimumSize = new Size(139, 30);
            mineKøbereDBKnap.Name = "mineKøbereDBKnap";
            mineKøbereDBKnap.RightToLeft = RightToLeft.No;
            mineKøbereDBKnap.Size = new Size(139, 30);
            mineKøbereDBKnap.TabIndex = 10;
            mineKøbereDBKnap.Text = "Mine Købere";
            mineKøbereDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineKøbereDBKnap.UseVisualStyleBackColor = false;
            mineKøbereDBKnap.Click += mineKøbereDBKnap_Click;
            // 
            // alleKøbereDBKnap
            // 
            alleKøbereDBKnap.Anchor = AnchorStyles.None;
            alleKøbereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            alleKøbereDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleKøbereDBKnap.FlatAppearance.BorderSize = 0;
            alleKøbereDBKnap.FlatStyle = FlatStyle.Flat;
            alleKøbereDBKnap.Font = new Font("Segoe UI", 8F);
            alleKøbereDBKnap.ForeColor = Color.Black;
            alleKøbereDBKnap.Location = new Point(0, 60);
            alleKøbereDBKnap.Margin = new Padding(0);
            alleKøbereDBKnap.Name = "alleKøbereDBKnap";
            alleKøbereDBKnap.RightToLeft = RightToLeft.No;
            alleKøbereDBKnap.Size = new Size(139, 30);
            alleKøbereDBKnap.TabIndex = 11;
            alleKøbereDBKnap.Text = "Alle Købere";
            alleKøbereDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleKøbereDBKnap.UseVisualStyleBackColor = false;
            alleKøbereDBKnap.Click += alleKøbereDBKnap_Click;
            // 
            // registrerKøberDBKnap
            // 
            registrerKøberDBKnap.Anchor = AnchorStyles.None;
            registrerKøberDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            registrerKøberDBKnap.BackgroundImageLayout = ImageLayout.None;
            registrerKøberDBKnap.FlatAppearance.BorderSize = 0;
            registrerKøberDBKnap.FlatStyle = FlatStyle.Flat;
            registrerKøberDBKnap.Font = new Font("Segoe UI", 8F);
            registrerKøberDBKnap.ForeColor = Color.Black;
            registrerKøberDBKnap.Location = new Point(0, 90);
            registrerKøberDBKnap.Margin = new Padding(0);
            registrerKøberDBKnap.Name = "registrerKøberDBKnap";
            registrerKøberDBKnap.RightToLeft = RightToLeft.No;
            registrerKøberDBKnap.Size = new Size(139, 30);
            registrerKøberDBKnap.TabIndex = 12;
            registrerKøberDBKnap.Text = "Registrer";
            registrerKøberDBKnap.TextAlign = ContentAlignment.TopLeft;
            registrerKøberDBKnap.UseVisualStyleBackColor = false;
            registrerKøberDBKnap.Click += registrerKøberDBKnap_Click;
            // 
            // salgDBPanel
            // 
            salgDBPanel.Anchor = AnchorStyles.None;
            salgDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            salgDBPanel.BorderStyle = BorderStyle.FixedSingle;
            salgDBPanel.Controls.Add(salgDBKnap);
            salgDBPanel.Controls.Add(mineSalgDBKnap);
            salgDBPanel.Controls.Add(alleSalgDBKnap);
            salgDBPanel.Controls.Add(salgRegistrerDBKnap);
            salgDBPanel.Location = new Point(4, 122);
            salgDBPanel.MaximumSize = new Size(139, 144);
            salgDBPanel.MinimumSize = new Size(139, 54);
            salgDBPanel.Name = "salgDBPanel";
            salgDBPanel.Size = new Size(139, 54);
            salgDBPanel.TabIndex = 5;
            // 
            // salgDBKnap
            // 
            salgDBKnap.BackColor = Color.FromArgb(176, 176, 176);
            salgDBKnap.BackgroundImage = Properties.Resources.vecteezy_money_icon_png_on_transparent_background_17785212;
            salgDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            salgDBKnap.FlatAppearance.BorderColor = Color.Black;
            salgDBKnap.FlatStyle = FlatStyle.Flat;
            salgDBKnap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            salgDBKnap.ForeColor = Color.Black;
            salgDBKnap.Location = new Point(0, 0);
            salgDBKnap.Margin = new Padding(0);
            salgDBKnap.MaximumSize = new Size(139, 52);
            salgDBKnap.MinimumSize = new Size(139, 52);
            salgDBKnap.Name = "salgDBKnap";
            salgDBKnap.RightToLeft = RightToLeft.No;
            salgDBKnap.Size = new Size(139, 52);
            salgDBKnap.TabIndex = 6;
            salgDBKnap.TextAlign = ContentAlignment.MiddleRight;
            salgDBKnap.UseVisualStyleBackColor = false;
            salgDBKnap.Click += salgDBKnap_Click;
            // 
            // mineSalgDBKnap
            // 
            mineSalgDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            mineSalgDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineSalgDBKnap.FlatAppearance.BorderSize = 0;
            mineSalgDBKnap.FlatStyle = FlatStyle.Flat;
            mineSalgDBKnap.Font = new Font("Segoe UI", 8F);
            mineSalgDBKnap.ForeColor = Color.Black;
            mineSalgDBKnap.Location = new Point(0, 52);
            mineSalgDBKnap.Margin = new Padding(0);
            mineSalgDBKnap.Name = "mineSalgDBKnap";
            mineSalgDBKnap.RightToLeft = RightToLeft.No;
            mineSalgDBKnap.Size = new Size(144, 30);
            mineSalgDBKnap.TabIndex = 6;
            mineSalgDBKnap.Text = "Mine Salg";
            mineSalgDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineSalgDBKnap.UseVisualStyleBackColor = false;
            mineSalgDBKnap.Click += mineSalgDBKnap_Click;
            // 
            // alleSalgDBKnap
            // 
            alleSalgDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            alleSalgDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleSalgDBKnap.FlatAppearance.BorderSize = 0;
            alleSalgDBKnap.FlatStyle = FlatStyle.Flat;
            alleSalgDBKnap.Font = new Font("Segoe UI", 8F);
            alleSalgDBKnap.ForeColor = Color.Black;
            alleSalgDBKnap.Location = new Point(0, 82);
            alleSalgDBKnap.Margin = new Padding(0);
            alleSalgDBKnap.Name = "alleSalgDBKnap";
            alleSalgDBKnap.RightToLeft = RightToLeft.No;
            alleSalgDBKnap.Size = new Size(144, 30);
            alleSalgDBKnap.TabIndex = 5;
            alleSalgDBKnap.Text = "Alle Salg";
            alleSalgDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleSalgDBKnap.UseVisualStyleBackColor = false;
            alleSalgDBKnap.Click += alleSalgDBKnap_Click;
            // 
            // salgRegistrerDBKnap
            // 
            salgRegistrerDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            salgRegistrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            salgRegistrerDBKnap.FlatAppearance.BorderSize = 0;
            salgRegistrerDBKnap.FlatStyle = FlatStyle.Flat;
            salgRegistrerDBKnap.Font = new Font("Segoe UI", 8F);
            salgRegistrerDBKnap.ForeColor = Color.Black;
            salgRegistrerDBKnap.Location = new Point(0, 112);
            salgRegistrerDBKnap.Margin = new Padding(0);
            salgRegistrerDBKnap.Name = "salgRegistrerDBKnap";
            salgRegistrerDBKnap.RightToLeft = RightToLeft.No;
            salgRegistrerDBKnap.Size = new Size(144, 30);
            salgRegistrerDBKnap.TabIndex = 7;
            salgRegistrerDBKnap.Text = "Registrer";
            salgRegistrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            salgRegistrerDBKnap.UseVisualStyleBackColor = false;
            salgRegistrerDBKnap.Click += salgRegistrerDBKnap_Click;
            // 
            // boligDBPanel
            // 
            boligDBPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            boligDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boligDBPanel.Controls.Add(boligDBKnap);
            boligDBPanel.Controls.Add(mineBoligerDBKnap);
            boligDBPanel.Controls.Add(alleBolgierDBKnap);
            boligDBPanel.Controls.Add(boligerRegistrerDBKnap);
            boligDBPanel.Location = new Point(4, 4);
            boligDBPanel.MaximumSize = new Size(146, 163);
            boligDBPanel.MinimumSize = new Size(139, 52);
            boligDBPanel.Name = "boligDBPanel";
            boligDBPanel.Size = new Size(139, 52);
            boligDBPanel.TabIndex = 1;
            // 
            // boligDBKnap
            // 
            boligDBKnap.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            boligDBKnap.BackColor = Color.FromArgb(253, 187, 131);
            boligDBKnap.BackgroundImage = (Image)resources.GetObject("boligDBKnap.BackgroundImage");
            boligDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            boligDBKnap.FlatAppearance.BorderColor = Color.Black;
            boligDBKnap.FlatStyle = FlatStyle.Flat;
            boligDBKnap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            boligDBKnap.ForeColor = Color.Transparent;
            boligDBKnap.Location = new Point(0, 0);
            boligDBKnap.Margin = new Padding(0);
            boligDBKnap.MaximumSize = new Size(139, 52);
            boligDBKnap.MinimumSize = new Size(139, 52);
            boligDBKnap.Name = "boligDBKnap";
            boligDBKnap.RightToLeft = RightToLeft.No;
            boligDBKnap.Size = new Size(139, 52);
            boligDBKnap.TabIndex = 2;
            boligDBKnap.TextAlign = ContentAlignment.MiddleRight;
            boligDBKnap.UseVisualStyleBackColor = false;
            boligDBKnap.Click += boligDBKnap_Click;
            // 
            // mineBoligerDBKnap
            // 
            mineBoligerDBKnap.BackColor = Color.FromArgb(255, 199, 152);
            mineBoligerDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineBoligerDBKnap.FlatAppearance.BorderSize = 0;
            mineBoligerDBKnap.FlatStyle = FlatStyle.Flat;
            mineBoligerDBKnap.Font = new Font("Segoe UI", 8F);
            mineBoligerDBKnap.ForeColor = Color.Black;
            mineBoligerDBKnap.Location = new Point(0, 52);
            mineBoligerDBKnap.Margin = new Padding(0);
            mineBoligerDBKnap.MaximumSize = new Size(139, 37);
            mineBoligerDBKnap.MinimumSize = new Size(139, 37);
            mineBoligerDBKnap.Name = "mineBoligerDBKnap";
            mineBoligerDBKnap.RightToLeft = RightToLeft.No;
            mineBoligerDBKnap.Size = new Size(139, 37);
            mineBoligerDBKnap.TabIndex = 3;
            mineBoligerDBKnap.Text = "Mine Boliger";
            mineBoligerDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineBoligerDBKnap.UseVisualStyleBackColor = false;
            mineBoligerDBKnap.Click += mineBoligerDBKnap_Click;
            // 
            // alleBolgierDBKnap
            // 
            alleBolgierDBKnap.BackColor = Color.FromArgb(255, 199, 152);
            alleBolgierDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleBolgierDBKnap.FlatAppearance.BorderSize = 0;
            alleBolgierDBKnap.FlatStyle = FlatStyle.Flat;
            alleBolgierDBKnap.Font = new Font("Segoe UI", 8F);
            alleBolgierDBKnap.ForeColor = Color.Black;
            alleBolgierDBKnap.Location = new Point(0, 89);
            alleBolgierDBKnap.Margin = new Padding(0);
            alleBolgierDBKnap.MaximumSize = new Size(139, 37);
            alleBolgierDBKnap.MinimumSize = new Size(139, 37);
            alleBolgierDBKnap.Name = "alleBolgierDBKnap";
            alleBolgierDBKnap.RightToLeft = RightToLeft.No;
            alleBolgierDBKnap.Size = new Size(139, 37);
            alleBolgierDBKnap.TabIndex = 4;
            alleBolgierDBKnap.Text = "Alle Boliger";
            alleBolgierDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleBolgierDBKnap.UseVisualStyleBackColor = false;
            alleBolgierDBKnap.Click += alleBolgierDBKnap_Click;
            // 
            // boligerRegistrerDBKnap
            // 
            boligerRegistrerDBKnap.BackColor = Color.FromArgb(255, 199, 152);
            boligerRegistrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            boligerRegistrerDBKnap.FlatAppearance.BorderSize = 0;
            boligerRegistrerDBKnap.FlatStyle = FlatStyle.Flat;
            boligerRegistrerDBKnap.Font = new Font("Segoe UI", 8F);
            boligerRegistrerDBKnap.ForeColor = Color.Black;
            boligerRegistrerDBKnap.Location = new Point(0, 126);
            boligerRegistrerDBKnap.Margin = new Padding(0);
            boligerRegistrerDBKnap.MaximumSize = new Size(139, 37);
            boligerRegistrerDBKnap.MinimumSize = new Size(139, 37);
            boligerRegistrerDBKnap.Name = "boligerRegistrerDBKnap";
            boligerRegistrerDBKnap.RightToLeft = RightToLeft.No;
            boligerRegistrerDBKnap.Size = new Size(139, 37);
            boligerRegistrerDBKnap.TabIndex = 5;
            boligerRegistrerDBKnap.Text = "Registrer";
            boligerRegistrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            boligerRegistrerDBKnap.UseVisualStyleBackColor = false;
            // 
            // brugerDBKnap
            // 
            brugerDBKnap.BackgroundImage = Properties.Resources.user_profile_icon__4___1_;
            brugerDBKnap.BackgroundImageLayout = ImageLayout.Zoom;
            brugerDBKnap.Dock = DockStyle.Fill;
            brugerDBKnap.FlatAppearance.BorderSize = 0;
            brugerDBKnap.FlatStyle = FlatStyle.Flat;
            brugerDBKnap.ImageAlign = ContentAlignment.TopCenter;
            brugerDBKnap.Location = new Point(0, 0);
            brugerDBKnap.Margin = new Padding(0);
            brugerDBKnap.Name = "brugerDBKnap";
            brugerDBKnap.Size = new Size(144, 137);
            brugerDBKnap.TabIndex = 2;
            brugerDBKnap.TextAlign = ContentAlignment.BottomCenter;
            brugerDBKnap.UseVisualStyleBackColor = true;
            // 
            // screenDBPanel
            // 
            screenDBPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screenDBPanel.AutoScroll = true;
            screenDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            screenDBPanel.Location = new Point(166, 72);
            screenDBPanel.Name = "screenDBPanel";
            screenDBPanel.Size = new Size(652, 634);
            screenDBPanel.TabIndex = 2;
            // 
            // brugerLayoutPanel
            // 
            brugerLayoutPanel.AutoScroll = true;
            brugerLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            brugerLayoutPanel.ColumnCount = 1;
            brugerLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            brugerLayoutPanel.Controls.Add(brugerDBKnap, 0, 0);
            brugerLayoutPanel.Controls.Add(brugerNavnLabel, 0, 1);
            brugerLayoutPanel.Dock = DockStyle.Fill;
            brugerLayoutPanel.Location = new Point(1, 1);
            brugerLayoutPanel.Margin = new Padding(0);
            brugerLayoutPanel.Name = "brugerLayoutPanel";
            brugerLayoutPanel.RowCount = 2;
            brugerLayoutPanel.RowStyles.Add(new RowStyle());
            brugerLayoutPanel.RowStyles.Add(new RowStyle());
            brugerLayoutPanel.Size = new Size(144, 165);
            brugerLayoutPanel.TabIndex = 0;
            // 
            // brugerNavnLabel
            // 
            brugerNavnLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            brugerNavnLabel.AutoSize = true;
            brugerNavnLabel.Location = new Point(0, 137);
            brugerNavnLabel.Margin = new Padding(0);
            brugerNavnLabel.Name = "brugerNavnLabel";
            brugerNavnLabel.Size = new Size(144, 28);
            brugerNavnLabel.TabIndex = 3;
            brugerNavnLabel.Text = "[Brugernavn]";
            brugerNavnLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uDBLayoutPanel
            // 
            uDBLayoutPanel.AutoSize = true;
            uDBLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uDBLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            uDBLayoutPanel.ColumnCount = 2;
            uDBLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            uDBLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            uDBLayoutPanel.Controls.Add(startDBKnap, 0, 0);
            uDBLayoutPanel.Controls.Add(pageLabel, 1, 0);
            uDBLayoutPanel.Dock = DockStyle.Top;
            uDBLayoutPanel.Location = new Point(0, 0);
            uDBLayoutPanel.Margin = new Padding(0);
            uDBLayoutPanel.Name = "uDBLayoutPanel";
            uDBLayoutPanel.RowCount = 1;
            uDBLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uDBLayoutPanel.Size = new Size(840, 63);
            uDBLayoutPanel.TabIndex = 3;
            // 
            // lDBLayoutPanel
            // 
            lDBLayoutPanel.BackColor = Color.FromArgb(255, 246, 218);
            lDBLayoutPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            lDBLayoutPanel.ColumnCount = 1;
            lDBLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            lDBLayoutPanel.Controls.Add(brugerLayoutPanel, 0, 0);
            lDBLayoutPanel.Controls.Add(menuDBLayoutPanel, 0, 1);
            lDBLayoutPanel.Dock = DockStyle.Left;
            lDBLayoutPanel.Location = new Point(0, 63);
            lDBLayoutPanel.Margin = new Padding(0);
            lDBLayoutPanel.Name = "lDBLayoutPanel";
            lDBLayoutPanel.RowCount = 3;
            lDBLayoutPanel.RowStyles.Add(new RowStyle());
            lDBLayoutPanel.RowStyles.Add(new RowStyle());
            lDBLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            lDBLayoutPanel.Size = new Size(146, 654);
            lDBLayoutPanel.TabIndex = 4;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(840, 717);
            Controls.Add(lDBLayoutPanel);
            Controls.Add(uDBLayoutPanel);
            Controls.Add(screenDBPanel);
            Name = "DashBoard";
            Text = "DashBoard";
            TransparencyKey = Color.Yellow;
            menuDBLayoutPanel.ResumeLayout(false);
            personDBPanel.ResumeLayout(false);
            personDBPanel.PerformLayout();
            personLayOutDBPanel.ResumeLayout(false);
            sælgerDBPanel.ResumeLayout(false);
            køberDBPanel.ResumeLayout(false);
            salgDBPanel.ResumeLayout(false);
            boligDBPanel.ResumeLayout(false);
            brugerLayoutPanel.ResumeLayout(false);
            brugerLayoutPanel.PerformLayout();
            uDBLayoutPanel.ResumeLayout(false);
            uDBLayoutPanel.PerformLayout();
            lDBLayoutPanel.ResumeLayout(false);
            lDBLayoutPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label pageLabel;
        private Button logUdDBKnap;
        private Button brugerDBKnap;
        private Button boligDBKnap;
        private Button personDBKnap;
        private Button startDBKnap;
        private Panel screenDBPanel;
        private TableLayoutPanel menuDBLayoutPanel;
        private FlowLayoutPanel boligDBPanel;
        private Button mineBoligerDBKnap;
        private Button alleBolgierDBKnap;
        private Button boligerRegistrerDBKnap;
        private FlowLayoutPanel personDBPanel;
        private Button sælgereDBKnap;
        private FlowLayoutPanel sælgerDBPanel;
        private Button mineSælgereDBKnap;
        private TableLayoutPanel personLayOutDBPanel;
        private Button alleSælgereDBKnap;
        private Button registrerDBKnap;
        private Button køberDBKnap;
        private FlowLayoutPanel køberDBPanel;
        private Button mineKøbereDBKnap;
        private Button alleKøbereDBKnap;
        private Button registrerKøberDBKnap;
        private FlowLayoutPanel salgDBPanel;
        private Button alleSalgDBKnap;
        private Button mineSalgDBKnap;
        private Button salgRegistrerDBKnap;
        private Button salgDBKnap;
        private TableLayoutPanel uDBLayoutPanel;
        private TableLayoutPanel lDBLayoutPanel;
        private Button mæglerDBKnap;
        private TableLayoutPanel brugerLayoutPanel;
        private Label brugerNavnLabel;
    }
}
