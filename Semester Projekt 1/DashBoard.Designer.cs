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
            salgDBKnap = new Button();
            personDBKnap = new Button();
            boligDBKnap = new Button();
            brugerDBKnap = new Button();
            panel1 = new Panel();
            uDBPanel.SuspendLayout();
            SDBPanel.SuspendLayout();
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
            startDBKnap.Location = new Point(-2, 0);
            startDBKnap.Name = "startDBKnap";
            startDBKnap.Size = new Size(133, 51);
            startDBKnap.TabIndex = 5;
            startDBKnap.Text = "Start";
            startDBKnap.TextAlign = ContentAlignment.MiddleRight;
            startDBKnap.UseVisualStyleBackColor = false;
            // 
            // pageLabel
            // 
            pageLabel.Anchor = AnchorStyles.None;
            pageLabel.AutoSize = true;
            pageLabel.FlatStyle = FlatStyle.Flat;
            pageLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            pageLabel.Location = new Point(395, 3);
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
            logUdDBKnap.Location = new Point(-2, 327);
            logUdDBKnap.Name = "logUdDBKnap";
            logUdDBKnap.RightToLeft = RightToLeft.No;
            logUdDBKnap.Size = new Size(133, 51);
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
            SDBPanel.Controls.Add(logUdDBKnap);
            SDBPanel.Controls.Add(salgDBKnap);
            SDBPanel.Controls.Add(personDBKnap);
            SDBPanel.Controls.Add(boligDBKnap);
            SDBPanel.Controls.Add(brugerDBKnap);
            SDBPanel.Location = new Point(0, 52);
            SDBPanel.Name = "SDBPanel";
            SDBPanel.Size = new Size(132, 665);
            SDBPanel.TabIndex = 1;
            // 
            // salgDBKnap
            // 
            salgDBKnap.BackColor = Color.FromArgb(176, 176, 176);
            salgDBKnap.BackgroundImageLayout = ImageLayout.None;
            salgDBKnap.FlatStyle = FlatStyle.Flat;
            salgDBKnap.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            salgDBKnap.ForeColor = Color.Black;
            salgDBKnap.Image = (Image)resources.GetObject("salgDBKnap.Image");
            salgDBKnap.Location = new Point(-2, 270);
            salgDBKnap.Name = "salgDBKnap";
            salgDBKnap.RightToLeft = RightToLeft.No;
            salgDBKnap.Size = new Size(133, 51);
            salgDBKnap.TabIndex = 4;
            salgDBKnap.UseVisualStyleBackColor = false;
            // 
            // personDBKnap
            // 
            personDBKnap.BackColor = Color.FromArgb(164, 236, 142);
            personDBKnap.BackgroundImageLayout = ImageLayout.None;
            personDBKnap.FlatStyle = FlatStyle.Flat;
            personDBKnap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            personDBKnap.ForeColor = Color.Black;
            personDBKnap.Image = Properties.Resources._8503b364be6ba9825ae617c947fa5280;
            personDBKnap.Location = new Point(-1, 213);
            personDBKnap.Name = "personDBKnap";
            personDBKnap.RightToLeft = RightToLeft.No;
            personDBKnap.Size = new Size(133, 51);
            personDBKnap.TabIndex = 3;
            personDBKnap.TextAlign = ContentAlignment.MiddleRight;
            personDBKnap.UseVisualStyleBackColor = false;
            // 
            // boligDBKnap
            // 
            boligDBKnap.BackColor = Color.FromArgb(253, 187, 131);
            boligDBKnap.BackgroundImageLayout = ImageLayout.None;
            boligDBKnap.FlatStyle = FlatStyle.Flat;
            boligDBKnap.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            boligDBKnap.ForeColor = Color.Black;
            boligDBKnap.Image = (Image)resources.GetObject("boligDBKnap.Image");
            boligDBKnap.Location = new Point(-2, 156);
            boligDBKnap.Name = "boligDBKnap";
            boligDBKnap.RightToLeft = RightToLeft.No;
            boligDBKnap.Size = new Size(133, 51);
            boligDBKnap.TabIndex = 2;
            boligDBKnap.TextAlign = ContentAlignment.MiddleRight;
            boligDBKnap.UseVisualStyleBackColor = false;
            // 
            // brugerDBKnap
            // 
            brugerDBKnap.FlatStyle = FlatStyle.Flat;
            brugerDBKnap.Image = Properties.Resources.user_profile_icon__4___1__mini;
            brugerDBKnap.ImageAlign = ContentAlignment.TopCenter;
            brugerDBKnap.Location = new Point(-1, -1);
            brugerDBKnap.Name = "brugerDBKnap";
            brugerDBKnap.Size = new Size(132, 160);
            brugerDBKnap.TabIndex = 2;
            brugerDBKnap.Text = "Brugernavn";
            brugerDBKnap.TextAlign = ContentAlignment.BottomCenter;
            brugerDBKnap.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(132, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 669);
            panel1.TabIndex = 2;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(840, 717);
            Controls.Add(panel1);
            Controls.Add(SDBPanel);
            Controls.Add(uDBPanel);
            Name = "DashBoard";
            Text = "DashBoard";
            TransparencyKey = Color.Yellow;
            uDBPanel.ResumeLayout(false);
            uDBPanel.PerformLayout();
            SDBPanel.ResumeLayout(false);
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
        private Button salgDBKnap;
        private Button startDBKnap;
        private Panel panel1;
    }
}
