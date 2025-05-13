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
            uDBPanel = new Panel();
            startDBKnap = new Button();
            pageLabel = new Label();
            logUdDBKnap = new Button();
            SDBPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            personDBPanel = new FlowLayoutPanel();
            personDBKnap = new Button();
            mæglerDBKnap = new Button();
            personLayOutDBPanel = new TableLayoutPanel();
            sælgerLayoutDBPanel = new FlowLayoutPanel();
            sælgereDBKnap = new Button();
            mineSælgereDBKnap = new Button();
            alleSælgereDBKnap = new Button();
            registrerDBKnap = new Button();
            købereDBLayoutPanel = new FlowLayoutPanel();
            køberDBKnap = new Button();
            mineKøbereDBKnap = new Button();
            alleKøbereDBKnap = new Button();
            registrerKøberDBKnap = new Button();
            boligDBPanel = new FlowLayoutPanel();
            boligDBKnap = new Button();
            mineBoligerDBKnap = new Button();
            alleBolgierDBKnap = new Button();
            boligerRegistrerDBKnap = new Button();
            salgDBFlowLayoutPanel = new FlowLayoutPanel();
            salgDBKnap = new Button();
            alleSalgDBKnap = new Button();
            mineSalgDBKnap = new Button();
            salgRegistrerDBKnap = new Button();
            brugerDBKnap = new Button();
            screenDBPanel = new Panel();
            uDBPanel.SuspendLayout();
            SDBPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            personDBPanel.SuspendLayout();
            personLayOutDBPanel.SuspendLayout();
            sælgerLayoutDBPanel.SuspendLayout();
            købereDBLayoutPanel.SuspendLayout();
            boligDBPanel.SuspendLayout();
            salgDBFlowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // uDBPanel
            // 
            uDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            uDBPanel.BackColor = Color.FromArgb(255, 246, 218);
            uDBPanel.BorderStyle = BorderStyle.FixedSingle;
            uDBPanel.Controls.Add(startDBKnap);
            uDBPanel.Controls.Add(pageLabel);
            uDBPanel.Dock = DockStyle.Top;
            uDBPanel.Location = new Point(0, 0);
            uDBPanel.Name = "uDBPanel";
            uDBPanel.Size = new Size(840, 52);
            uDBPanel.TabIndex = 0;
            // 
            // startDBKnap
            // 
            startDBKnap.BackColor = Color.FromArgb(198, 220, 255);
            startDBKnap.BackgroundImageLayout = ImageLayout.None;
            startDBKnap.FlatStyle = FlatStyle.Flat;
            startDBKnap.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            startDBKnap.ForeColor = Color.Black;
            startDBKnap.Image = Properties.Resources.image__24_;
            startDBKnap.ImageAlign = ContentAlignment.BottomLeft;
            startDBKnap.Location = new Point(-1, 0);
            startDBKnap.Name = "startDBKnap";
            startDBKnap.Size = new Size(144, 51);
            startDBKnap.TabIndex = 5;
            startDBKnap.Text = "Start";
            startDBKnap.TextAlign = ContentAlignment.MiddleRight;
            startDBKnap.UseVisualStyleBackColor = false;
            startDBKnap.Click += startDBKnap_Click;
            // 
            // pageLabel
            // 
            pageLabel.Anchor = AnchorStyles.None;
            pageLabel.AutoSize = true;
            pageLabel.FlatStyle = FlatStyle.Flat;
            pageLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            pageLabel.Location = new Point(400, 3);
            pageLabel.Name = "pageLabel";
            pageLabel.Size = new Size(171, 41);
            pageLabel.TabIndex = 0;
            pageLabel.Text = "Dashboard";
            // 
            // logUdDBKnap
            // 
            logUdDBKnap.BackColor = Color.FromArgb(255, 100, 100);
            logUdDBKnap.BackgroundImageLayout = ImageLayout.None;
            logUdDBKnap.FlatStyle = FlatStyle.Flat;
            logUdDBKnap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            logUdDBKnap.ForeColor = Color.Black;
            logUdDBKnap.Image = Properties.Resources.image__22__mini;
            logUdDBKnap.ImageAlign = ContentAlignment.MiddleLeft;
            logUdDBKnap.Location = new Point(3, 186);
            logUdDBKnap.Name = "logUdDBKnap";
            logUdDBKnap.RightToLeft = RightToLeft.No;
            logUdDBKnap.Size = new Size(133, 54);
            logUdDBKnap.TabIndex = 1;
            logUdDBKnap.Text = "Log Ud";
            logUdDBKnap.TextAlign = ContentAlignment.MiddleRight;
            logUdDBKnap.UseVisualStyleBackColor = false;
            // 
            // SDBPanel
            // 
            SDBPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SDBPanel.BackColor = Color.FromArgb(255, 246, 218);
            SDBPanel.BorderStyle = BorderStyle.FixedSingle;
            SDBPanel.Controls.Add(tableLayoutPanel1);
            SDBPanel.Controls.Add(brugerDBKnap);
            SDBPanel.Location = new Point(0, 52);
            SDBPanel.Name = "SDBPanel";
            SDBPanel.Size = new Size(144, 665);
            SDBPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(personDBPanel, 0, 1);
            tableLayoutPanel1.Controls.Add(logUdDBKnap, 0, 3);
            tableLayoutPanel1.Controls.Add(boligDBPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(salgDBFlowLayoutPanel, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 162);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(139, 245);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // personDBPanel
            // 
            personDBPanel.BorderStyle = BorderStyle.FixedSingle;
            personDBPanel.Controls.Add(personDBKnap);
            personDBPanel.Controls.Add(mæglerDBKnap);
            personDBPanel.Controls.Add(personLayOutDBPanel);
            personDBPanel.Location = new Point(3, 64);
            personDBPanel.MaximumSize = new Size(133, 320);
            personDBPanel.MinimumSize = new Size(132, 51);
            personDBPanel.Name = "personDBPanel";
            personDBPanel.Size = new Size(132, 55);
            personDBPanel.TabIndex = 4;
            // 
            // personDBKnap
            // 
            personDBKnap.BackColor = Color.FromArgb(164, 236, 142);
            personDBKnap.BackgroundImageLayout = ImageLayout.None;
            personDBKnap.FlatAppearance.BorderSize = 0;
            personDBKnap.FlatStyle = FlatStyle.Flat;
            personDBKnap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            personDBKnap.ForeColor = Color.Black;
            personDBKnap.Image = Properties.Resources._8503b364be6ba9825ae617c947fa5280;
            personDBKnap.Location = new Point(0, 0);
            personDBKnap.Margin = new Padding(0);
            personDBKnap.Name = "personDBKnap";
            personDBKnap.RightToLeft = RightToLeft.No;
            personDBKnap.Size = new Size(132, 51);
            personDBKnap.TabIndex = 3;
            personDBKnap.TextAlign = ContentAlignment.MiddleRight;
            personDBKnap.UseVisualStyleBackColor = false;
            // 
            // mæglerDBKnap
            // 
            mæglerDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            mæglerDBKnap.BackgroundImageLayout = ImageLayout.None;
            mæglerDBKnap.FlatAppearance.BorderSize = 0;
            mæglerDBKnap.FlatStyle = FlatStyle.Flat;
            mæglerDBKnap.Font = new Font("Segoe UI", 8F);
            mæglerDBKnap.ForeColor = Color.Black;
            mæglerDBKnap.Location = new Point(0, 51);
            mæglerDBKnap.Margin = new Padding(0);
            mæglerDBKnap.Name = "mæglerDBKnap";
            mæglerDBKnap.RightToLeft = RightToLeft.No;
            mæglerDBKnap.Size = new Size(132, 30);
            mæglerDBKnap.TabIndex = 13;
            mæglerDBKnap.Text = "Mæglere";
            mæglerDBKnap.TextAlign = ContentAlignment.TopLeft;
            mæglerDBKnap.UseVisualStyleBackColor = false;
            // 
            // personLayOutDBPanel
            // 
            personLayOutDBPanel.ColumnCount = 1;
            personLayOutDBPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            personLayOutDBPanel.Controls.Add(sælgerLayoutDBPanel, 0, 0);
            personLayOutDBPanel.Controls.Add(købereDBLayoutPanel, 0, 1);
            personLayOutDBPanel.Location = new Point(0, 81);
            personLayOutDBPanel.Margin = new Padding(0);
            personLayOutDBPanel.MaximumSize = new Size(132, 235);
            personLayOutDBPanel.MinimumSize = new Size(132, 52);
            personLayOutDBPanel.Name = "personLayOutDBPanel";
            personLayOutDBPanel.RowCount = 2;
            personLayOutDBPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            personLayOutDBPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            personLayOutDBPanel.Size = new Size(132, 52);
            personLayOutDBPanel.TabIndex = 7;
            // 
            // sælgerLayoutDBPanel
            // 
            sælgerLayoutDBPanel.Controls.Add(sælgereDBKnap);
            sælgerLayoutDBPanel.Controls.Add(mineSælgereDBKnap);
            sælgerLayoutDBPanel.Controls.Add(alleSælgereDBKnap);
            sælgerLayoutDBPanel.Controls.Add(registrerDBKnap);
            sælgerLayoutDBPanel.Location = new Point(0, 0);
            sælgerLayoutDBPanel.Margin = new Padding(0);
            sælgerLayoutDBPanel.MaximumSize = new Size(132, 120);
            sælgerLayoutDBPanel.MinimumSize = new Size(132, 31);
            sælgerLayoutDBPanel.Name = "sælgerLayoutDBPanel";
            sælgerLayoutDBPanel.Size = new Size(132, 31);
            sælgerLayoutDBPanel.TabIndex = 6;
            // 
            // sælgereDBKnap
            // 
            sælgereDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            sælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            sælgereDBKnap.FlatAppearance.BorderSize = 0;
            sælgereDBKnap.FlatStyle = FlatStyle.Flat;
            sælgereDBKnap.Font = new Font("Segoe UI", 8F);
            sælgereDBKnap.ForeColor = Color.Black;
            sælgereDBKnap.Location = new Point(0, 0);
            sælgereDBKnap.Margin = new Padding(0);
            sælgereDBKnap.Name = "sælgereDBKnap";
            sælgereDBKnap.RightToLeft = RightToLeft.No;
            sælgereDBKnap.Size = new Size(132, 30);
            sælgereDBKnap.TabIndex = 5;
            sælgereDBKnap.Text = "Sælgere";
            sælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            sælgereDBKnap.UseVisualStyleBackColor = false;
            // 
            // mineSælgereDBKnap
            // 
            mineSælgereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            mineSælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineSælgereDBKnap.FlatAppearance.BorderSize = 0;
            mineSælgereDBKnap.FlatStyle = FlatStyle.Flat;
            mineSælgereDBKnap.Font = new Font("Segoe UI", 8F);
            mineSælgereDBKnap.ForeColor = Color.Black;
            mineSælgereDBKnap.Location = new Point(0, 30);
            mineSælgereDBKnap.Margin = new Padding(0);
            mineSælgereDBKnap.Name = "mineSælgereDBKnap";
            mineSælgereDBKnap.RightToLeft = RightToLeft.No;
            mineSælgereDBKnap.Size = new Size(132, 30);
            mineSælgereDBKnap.TabIndex = 6;
            mineSælgereDBKnap.Text = "Mine Sælgere";
            mineSælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineSælgereDBKnap.UseVisualStyleBackColor = false;
            // 
            // alleSælgereDBKnap
            // 
            alleSælgereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            alleSælgereDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleSælgereDBKnap.FlatAppearance.BorderSize = 0;
            alleSælgereDBKnap.FlatStyle = FlatStyle.Flat;
            alleSælgereDBKnap.Font = new Font("Segoe UI", 8F);
            alleSælgereDBKnap.ForeColor = Color.Black;
            alleSælgereDBKnap.Location = new Point(0, 60);
            alleSælgereDBKnap.Margin = new Padding(0);
            alleSælgereDBKnap.Name = "alleSælgereDBKnap";
            alleSælgereDBKnap.RightToLeft = RightToLeft.No;
            alleSælgereDBKnap.Size = new Size(132, 30);
            alleSælgereDBKnap.TabIndex = 7;
            alleSælgereDBKnap.Text = "Alle Sælgere";
            alleSælgereDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleSælgereDBKnap.UseVisualStyleBackColor = false;
            // 
            // registrerDBKnap
            // 
            registrerDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            registrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            registrerDBKnap.FlatAppearance.BorderSize = 0;
            registrerDBKnap.FlatStyle = FlatStyle.Flat;
            registrerDBKnap.Font = new Font("Segoe UI", 8F);
            registrerDBKnap.ForeColor = Color.Black;
            registrerDBKnap.Location = new Point(0, 90);
            registrerDBKnap.Margin = new Padding(0);
            registrerDBKnap.Name = "registrerDBKnap";
            registrerDBKnap.RightToLeft = RightToLeft.No;
            registrerDBKnap.Size = new Size(132, 29);
            registrerDBKnap.TabIndex = 8;
            registrerDBKnap.Text = "Registrer";
            registrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            registrerDBKnap.UseVisualStyleBackColor = false;
            // 
            // købereDBLayoutPanel
            // 
            købereDBLayoutPanel.Controls.Add(køberDBKnap);
            købereDBLayoutPanel.Controls.Add(mineKøbereDBKnap);
            købereDBLayoutPanel.Controls.Add(alleKøbereDBKnap);
            købereDBLayoutPanel.Controls.Add(registrerKøberDBKnap);
            købereDBLayoutPanel.Location = new Point(0, 26);
            købereDBLayoutPanel.Margin = new Padding(0);
            købereDBLayoutPanel.MaximumSize = new Size(132, 122);
            købereDBLayoutPanel.MinimumSize = new Size(132, 30);
            købereDBLayoutPanel.Name = "købereDBLayoutPanel";
            købereDBLayoutPanel.Size = new Size(132, 30);
            købereDBLayoutPanel.TabIndex = 7;
            // 
            // køberDBKnap
            // 
            køberDBKnap.BackColor = Color.FromArgb(175, 240, 155);
            køberDBKnap.BackgroundImageLayout = ImageLayout.None;
            køberDBKnap.FlatAppearance.BorderSize = 0;
            køberDBKnap.FlatStyle = FlatStyle.Flat;
            køberDBKnap.Font = new Font("Segoe UI", 8F);
            køberDBKnap.ForeColor = Color.Black;
            køberDBKnap.Location = new Point(0, 0);
            køberDBKnap.Margin = new Padding(0);
            køberDBKnap.Name = "køberDBKnap";
            køberDBKnap.RightToLeft = RightToLeft.No;
            køberDBKnap.Size = new Size(132, 30);
            køberDBKnap.TabIndex = 9;
            køberDBKnap.Text = "Købere";
            køberDBKnap.TextAlign = ContentAlignment.TopLeft;
            køberDBKnap.UseVisualStyleBackColor = false;
            // 
            // mineKøbereDBKnap
            // 
            mineKøbereDBKnap.BackColor = Color.FromArgb(197, 255, 180);
            mineKøbereDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineKøbereDBKnap.FlatAppearance.BorderSize = 0;
            mineKøbereDBKnap.FlatStyle = FlatStyle.Flat;
            mineKøbereDBKnap.Font = new Font("Segoe UI", 8F);
            mineKøbereDBKnap.ForeColor = Color.Black;
            mineKøbereDBKnap.Location = new Point(0, 30);
            mineKøbereDBKnap.Margin = new Padding(0);
            mineKøbereDBKnap.Name = "mineKøbereDBKnap";
            mineKøbereDBKnap.RightToLeft = RightToLeft.No;
            mineKøbereDBKnap.Size = new Size(132, 30);
            mineKøbereDBKnap.TabIndex = 10;
            mineKøbereDBKnap.Text = "Mine Købere";
            mineKøbereDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineKøbereDBKnap.UseVisualStyleBackColor = false;
            // 
            // alleKøbereDBKnap
            // 
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
            alleKøbereDBKnap.Size = new Size(132, 30);
            alleKøbereDBKnap.TabIndex = 11;
            alleKøbereDBKnap.Text = "Alle Købere";
            alleKøbereDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleKøbereDBKnap.UseVisualStyleBackColor = false;
            // 
            // registrerKøberDBKnap
            // 
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
            registrerKøberDBKnap.Size = new Size(132, 30);
            registrerKøberDBKnap.TabIndex = 12;
            registrerKøberDBKnap.Text = "Registrer";
            registrerKøberDBKnap.TextAlign = ContentAlignment.TopLeft;
            registrerKøberDBKnap.UseVisualStyleBackColor = false;
            // 
            // boligDBPanel
            // 
            boligDBPanel.BorderStyle = BorderStyle.FixedSingle;
            boligDBPanel.Controls.Add(boligDBKnap);
            boligDBPanel.Controls.Add(mineBoligerDBKnap);
            boligDBPanel.Controls.Add(alleBolgierDBKnap);
            boligDBPanel.Controls.Add(boligerRegistrerDBKnap);
            boligDBPanel.Location = new Point(3, 3);
            boligDBPanel.MaximumSize = new Size(132, 164);
            boligDBPanel.MinimumSize = new Size(132, 53);
            boligDBPanel.Name = "boligDBPanel";
            boligDBPanel.Size = new Size(132, 55);
            boligDBPanel.TabIndex = 1;
            // 
            // boligDBKnap
            // 
            boligDBKnap.BackColor = Color.FromArgb(253, 187, 131);
            boligDBKnap.BackgroundImageLayout = ImageLayout.None;
            boligDBKnap.FlatAppearance.BorderSize = 0;
            boligDBKnap.FlatStyle = FlatStyle.Flat;
            boligDBKnap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            boligDBKnap.ForeColor = Color.Transparent;
            boligDBKnap.Image = (Image)resources.GetObject("boligDBKnap.Image");
            boligDBKnap.Location = new Point(0, 0);
            boligDBKnap.Margin = new Padding(0);
            boligDBKnap.Name = "boligDBKnap";
            boligDBKnap.RightToLeft = RightToLeft.No;
            boligDBKnap.Size = new Size(131, 51);
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
            mineBoligerDBKnap.Location = new Point(0, 51);
            mineBoligerDBKnap.Margin = new Padding(0);
            mineBoligerDBKnap.Name = "mineBoligerDBKnap";
            mineBoligerDBKnap.RightToLeft = RightToLeft.No;
            mineBoligerDBKnap.Size = new Size(132, 37);
            mineBoligerDBKnap.TabIndex = 3;
            mineBoligerDBKnap.Text = "Mine Boliger";
            mineBoligerDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineBoligerDBKnap.UseVisualStyleBackColor = false;
            // 
            // alleBolgierDBKnap
            // 
            alleBolgierDBKnap.BackColor = Color.FromArgb(255, 199, 152);
            alleBolgierDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleBolgierDBKnap.FlatAppearance.BorderSize = 0;
            alleBolgierDBKnap.FlatStyle = FlatStyle.Flat;
            alleBolgierDBKnap.Font = new Font("Segoe UI", 8F);
            alleBolgierDBKnap.ForeColor = Color.Black;
            alleBolgierDBKnap.Location = new Point(0, 88);
            alleBolgierDBKnap.Margin = new Padding(0);
            alleBolgierDBKnap.Name = "alleBolgierDBKnap";
            alleBolgierDBKnap.RightToLeft = RightToLeft.No;
            alleBolgierDBKnap.Size = new Size(132, 37);
            alleBolgierDBKnap.TabIndex = 4;
            alleBolgierDBKnap.Text = "Alle Boliger";
            alleBolgierDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleBolgierDBKnap.UseVisualStyleBackColor = false;
            // 
            // boligerRegistrerDBKnap
            // 
            boligerRegistrerDBKnap.BackColor = Color.FromArgb(255, 199, 152);
            boligerRegistrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            boligerRegistrerDBKnap.FlatAppearance.BorderSize = 0;
            boligerRegistrerDBKnap.FlatStyle = FlatStyle.Flat;
            boligerRegistrerDBKnap.Font = new Font("Segoe UI", 8F);
            boligerRegistrerDBKnap.ForeColor = Color.Black;
            boligerRegistrerDBKnap.Location = new Point(0, 125);
            boligerRegistrerDBKnap.Margin = new Padding(0);
            boligerRegistrerDBKnap.Name = "boligerRegistrerDBKnap";
            boligerRegistrerDBKnap.RightToLeft = RightToLeft.No;
            boligerRegistrerDBKnap.Size = new Size(132, 37);
            boligerRegistrerDBKnap.TabIndex = 5;
            boligerRegistrerDBKnap.Text = "Registrer";
            boligerRegistrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            boligerRegistrerDBKnap.UseVisualStyleBackColor = false;
            // 
            // salgDBFlowLayoutPanel
            // 
            salgDBFlowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
            salgDBFlowLayoutPanel.Controls.Add(salgDBKnap);
            salgDBFlowLayoutPanel.Controls.Add(alleSalgDBKnap);
            salgDBFlowLayoutPanel.Controls.Add(mineSalgDBKnap);
            salgDBFlowLayoutPanel.Controls.Add(salgRegistrerDBKnap);
            salgDBFlowLayoutPanel.Location = new Point(3, 125);
            salgDBFlowLayoutPanel.MaximumSize = new Size(133, 142);
            salgDBFlowLayoutPanel.MinimumSize = new Size(133, 54);
            salgDBFlowLayoutPanel.Name = "salgDBFlowLayoutPanel";
            salgDBFlowLayoutPanel.Size = new Size(133, 54);
            salgDBFlowLayoutPanel.TabIndex = 5;
            // 
            // salgDBKnap
            // 
            salgDBKnap.BackColor = Color.FromArgb(176, 176, 176);
            salgDBKnap.BackgroundImageLayout = ImageLayout.None;
            salgDBKnap.FlatAppearance.BorderSize = 0;
            salgDBKnap.FlatStyle = FlatStyle.Flat;
            salgDBKnap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            salgDBKnap.ForeColor = Color.Black;
            salgDBKnap.Image = (Image)resources.GetObject("salgDBKnap.Image");
            salgDBKnap.Location = new Point(0, 0);
            salgDBKnap.Margin = new Padding(0);
            salgDBKnap.Name = "salgDBKnap";
            salgDBKnap.RightToLeft = RightToLeft.No;
            salgDBKnap.Size = new Size(132, 51);
            salgDBKnap.TabIndex = 6;
            salgDBKnap.TextAlign = ContentAlignment.MiddleRight;
            salgDBKnap.UseVisualStyleBackColor = false;
            // 
            // alleSalgDBKnap
            // 
            alleSalgDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            alleSalgDBKnap.BackgroundImageLayout = ImageLayout.None;
            alleSalgDBKnap.FlatAppearance.BorderSize = 0;
            alleSalgDBKnap.FlatStyle = FlatStyle.Flat;
            alleSalgDBKnap.Font = new Font("Segoe UI", 8F);
            alleSalgDBKnap.ForeColor = Color.Black;
            alleSalgDBKnap.Location = new Point(0, 51);
            alleSalgDBKnap.Margin = new Padding(0);
            alleSalgDBKnap.Name = "alleSalgDBKnap";
            alleSalgDBKnap.RightToLeft = RightToLeft.No;
            alleSalgDBKnap.Size = new Size(132, 30);
            alleSalgDBKnap.TabIndex = 5;
            alleSalgDBKnap.Text = "Alle Salg";
            alleSalgDBKnap.TextAlign = ContentAlignment.TopLeft;
            alleSalgDBKnap.UseVisualStyleBackColor = false;
            // 
            // mineSalgDBKnap
            // 
            mineSalgDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            mineSalgDBKnap.BackgroundImageLayout = ImageLayout.None;
            mineSalgDBKnap.FlatAppearance.BorderSize = 0;
            mineSalgDBKnap.FlatStyle = FlatStyle.Flat;
            mineSalgDBKnap.Font = new Font("Segoe UI", 8F);
            mineSalgDBKnap.ForeColor = Color.Black;
            mineSalgDBKnap.Location = new Point(0, 81);
            mineSalgDBKnap.Margin = new Padding(0);
            mineSalgDBKnap.Name = "mineSalgDBKnap";
            mineSalgDBKnap.RightToLeft = RightToLeft.No;
            mineSalgDBKnap.Size = new Size(132, 30);
            mineSalgDBKnap.TabIndex = 6;
            mineSalgDBKnap.Text = "Mine Salg";
            mineSalgDBKnap.TextAlign = ContentAlignment.TopLeft;
            mineSalgDBKnap.UseVisualStyleBackColor = false;
            // 
            // salgRegistrerDBKnap
            // 
            salgRegistrerDBKnap.BackColor = Color.FromArgb(200, 194, 194);
            salgRegistrerDBKnap.BackgroundImageLayout = ImageLayout.None;
            salgRegistrerDBKnap.FlatAppearance.BorderSize = 0;
            salgRegistrerDBKnap.FlatStyle = FlatStyle.Flat;
            salgRegistrerDBKnap.Font = new Font("Segoe UI", 8F);
            salgRegistrerDBKnap.ForeColor = Color.Black;
            salgRegistrerDBKnap.Location = new Point(0, 111);
            salgRegistrerDBKnap.Margin = new Padding(0);
            salgRegistrerDBKnap.Name = "salgRegistrerDBKnap";
            salgRegistrerDBKnap.RightToLeft = RightToLeft.No;
            salgRegistrerDBKnap.Size = new Size(132, 30);
            salgRegistrerDBKnap.TabIndex = 7;
            salgRegistrerDBKnap.Text = "Registrer";
            salgRegistrerDBKnap.TextAlign = ContentAlignment.TopLeft;
            salgRegistrerDBKnap.UseVisualStyleBackColor = false;
            // 
            // brugerDBKnap
            // 
            brugerDBKnap.FlatStyle = FlatStyle.Flat;
            brugerDBKnap.Image = Properties.Resources.user_profile_icon__4___1__mini;
            brugerDBKnap.ImageAlign = ContentAlignment.TopCenter;
            brugerDBKnap.Location = new Point(-1, -1);
            brugerDBKnap.Name = "brugerDBKnap";
            brugerDBKnap.Size = new Size(144, 160);
            brugerDBKnap.TabIndex = 2;
            brugerDBKnap.Text = "Brugernavn";
            brugerDBKnap.TextAlign = ContentAlignment.BottomCenter;
            brugerDBKnap.UseVisualStyleBackColor = true;
            // 
            // screenDBPanel
            // 
            screenDBPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            screenDBPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            screenDBPanel.BorderStyle = BorderStyle.FixedSingle;
            screenDBPanel.Location = new Point(143, 52);
            screenDBPanel.Name = "screenDBPanel";
            screenDBPanel.Size = new Size(697, 665);
            screenDBPanel.TabIndex = 2;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(840, 717);
            Controls.Add(screenDBPanel);
            Controls.Add(SDBPanel);
            Controls.Add(uDBPanel);
            Name = "DashBoard";
            Text = "DashBoard";
            TransparencyKey = Color.Yellow;
            uDBPanel.ResumeLayout(false);
            uDBPanel.PerformLayout();
            SDBPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            personDBPanel.ResumeLayout(false);
            personLayOutDBPanel.ResumeLayout(false);
            sælgerLayoutDBPanel.ResumeLayout(false);
            købereDBLayoutPanel.ResumeLayout(false);
            boligDBPanel.ResumeLayout(false);
            salgDBFlowLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel uDBPanel;
        private Label pageLabel;
        private Button logUdDBKnap;
        private Panel SDBPanel;
        private Button brugerDBKnap;
        private Button boligDBKnap;
        private Button personDBKnap;
        private Button startDBKnap;
        private Panel screenDBPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel boligDBPanel;
        private Button mineBoligerDBKnap;
        private Button alleBolgierDBKnap;
        private Button boligerRegistrerDBKnap;
        private FlowLayoutPanel personDBPanel;
        private Button sælgereDBKnap;
        private FlowLayoutPanel sælgerLayoutDBPanel;
        private Button mineSælgereDBKnap;
        private TableLayoutPanel personLayOutDBPanel;
        private Button alleSælgereDBKnap;
        private Button registrerDBKnap;
        private Button køberDBKnap;
        private FlowLayoutPanel købereDBLayoutPanel;
        private Button mineKøbereDBKnap;
        private Button alleKøbereDBKnap;
        private Button registrerKøberDBKnap;
        private Button mæglerDBKnap;
        private FlowLayoutPanel salgDBFlowLayoutPanel;
        private Button alleSalgDBKnap;
        private Button mineSalgDBKnap;
        private Button salgRegistrerDBKnap;
        private Button salgDBKnap;
    }
}
