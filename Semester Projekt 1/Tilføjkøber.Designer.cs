namespace Semester_Projekt_1
{
    partial class TilføjKøber
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
            navnTextbox = new TextBox();
            cprnummerTextbox = new TextBox();
            adresseTextbox = new TextBox();
            telefonnummerTextbox = new TextBox();
            søgeområdeTextbox = new TextBox();
            emailTextbox = new TextBox();
            værelserTextbox = new TextBox();
            prisklasseTextbox = new TextBox();
            boligstørrelseTextbox = new TextBox();
            grundstørrelseTextbox = new TextBox();
            efternavnTextbox = new TextBox();
            NavnLabel = new Label();
            EfternavnLabel = new Label();
            AdresseLabel = new Label();
            TelefonnummerLabel = new Label();
            CPRNummerLabel = new Label();
            EmailLabel = new Label();
            SøgeområdeLabel = new Label();
            PrisklasseLabel = new Label();
            BoligtypeLabel = new Label();
            GrundstørrelseLabel = new Label();
            VærelserLabel = new Label();
            BoligstørrelseLabel = new Label();
            YderligereInfoLabel = new Label();
            boligtypeCombobox = new ComboBox();
            anullerButton = new Button();
            opretButton = new Button();
            yderligereinfoTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // navnTextbox
            // 
            navnTextbox.ForeColor = SystemColors.ControlText;
            navnTextbox.Location = new Point(12, 32);
            navnTextbox.Name = "navnTextbox";
            navnTextbox.Size = new Size(191, 23);
            navnTextbox.TabIndex = 0;
            navnTextbox.Text = "Navn...";
            // 
            // cprnummerTextbox
            // 
            cprnummerTextbox.ForeColor = SystemColors.ControlText;
            cprnummerTextbox.Location = new Point(246, 138);
            cprnummerTextbox.Name = "cprnummerTextbox";
            cprnummerTextbox.Size = new Size(183, 23);
            cprnummerTextbox.TabIndex = 1;
            cprnummerTextbox.Text = "CPR-Nummer...";
            // 
            // adresseTextbox
            // 
            adresseTextbox.ForeColor = SystemColors.ControlText;
            adresseTextbox.Location = new Point(12, 83);
            adresseTextbox.Name = "adresseTextbox";
            adresseTextbox.Size = new Size(417, 23);
            adresseTextbox.TabIndex = 2;
            adresseTextbox.Text = "Adresse...";
            // 
            // telefonnummerTextbox
            // 
            telefonnummerTextbox.ForeColor = SystemColors.ControlText;
            telefonnummerTextbox.Location = new Point(12, 138);
            telefonnummerTextbox.Name = "telefonnummerTextbox";
            telefonnummerTextbox.Size = new Size(191, 23);
            telefonnummerTextbox.TabIndex = 3;
            telefonnummerTextbox.Text = "Telefonnummer";
            // 
            // søgeområdeTextbox
            // 
            søgeområdeTextbox.ForeColor = SystemColors.ControlText;
            søgeområdeTextbox.Location = new Point(12, 260);
            søgeområdeTextbox.Name = "søgeområdeTextbox";
            søgeområdeTextbox.Size = new Size(417, 23);
            søgeområdeTextbox.TabIndex = 4;
            søgeområdeTextbox.Text = "Ønsket Søgeområde...";
            // 
            // emailTextbox
            // 
            emailTextbox.ForeColor = SystemColors.ControlText;
            emailTextbox.Location = new Point(12, 198);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(417, 23);
            emailTextbox.TabIndex = 5;
            emailTextbox.Text = "E-mail...";
            // 
            // værelserTextbox
            // 
            værelserTextbox.ForeColor = SystemColors.ControlText;
            værelserTextbox.Location = new Point(166, 387);
            værelserTextbox.Name = "værelserTextbox";
            værelserTextbox.Size = new Size(100, 23);
            værelserTextbox.TabIndex = 8;
            værelserTextbox.Text = "Antal...";
            // 
            // prisklasseTextbox
            // 
            prisklasseTextbox.ForeColor = SystemColors.ControlText;
            prisklasseTextbox.Location = new Point(12, 317);
            prisklasseTextbox.Name = "prisklasseTextbox";
            prisklasseTextbox.Size = new Size(191, 23);
            prisklasseTextbox.TabIndex = 9;
            prisklasseTextbox.Text = "Prisklasse...";
            // 
            // boligstørrelseTextbox
            // 
            boligstørrelseTextbox.ForeColor = SystemColors.ControlText;
            boligstørrelseTextbox.Location = new Point(281, 387);
            boligstørrelseTextbox.Name = "boligstørrelseTextbox";
            boligstørrelseTextbox.Size = new Size(148, 23);
            boligstørrelseTextbox.TabIndex = 10;
            boligstørrelseTextbox.Text = "Ønsket Størrelse...";
            boligstørrelseTextbox.TextChanged += textBox11_TextChanged;
            // 
            // grundstørrelseTextbox
            // 
            grundstørrelseTextbox.ForeColor = SystemColors.ControlText;
            grundstørrelseTextbox.Location = new Point(12, 387);
            grundstørrelseTextbox.Name = "grundstørrelseTextbox";
            grundstørrelseTextbox.Size = new Size(127, 23);
            grundstørrelseTextbox.TabIndex = 11;
            grundstørrelseTextbox.Text = "Ønsket Størrelse...";
            // 
            // efternavnTextbox
            // 
            efternavnTextbox.ForeColor = SystemColors.ControlText;
            efternavnTextbox.Location = new Point(246, 32);
            efternavnTextbox.Name = "efternavnTextbox";
            efternavnTextbox.Size = new Size(183, 23);
            efternavnTextbox.TabIndex = 12;
            efternavnTextbox.Text = "Efternavn...";
            // 
            // NavnLabel
            // 
            NavnLabel.AutoSize = true;
            NavnLabel.Location = new Point(12, 14);
            NavnLabel.Name = "NavnLabel";
            NavnLabel.Size = new Size(35, 15);
            NavnLabel.TabIndex = 13;
            NavnLabel.Text = "Navn";
            // 
            // EfternavnLabel
            // 
            EfternavnLabel.AutoSize = true;
            EfternavnLabel.Location = new Point(246, 14);
            EfternavnLabel.Name = "EfternavnLabel";
            EfternavnLabel.Size = new Size(57, 15);
            EfternavnLabel.TabIndex = 14;
            EfternavnLabel.Text = "Efternavn";
            // 
            // AdresseLabel
            // 
            AdresseLabel.AutoSize = true;
            AdresseLabel.Location = new Point(12, 65);
            AdresseLabel.Name = "AdresseLabel";
            AdresseLabel.Size = new Size(48, 15);
            AdresseLabel.TabIndex = 15;
            AdresseLabel.Text = "Adresse";
            // 
            // TelefonnummerLabel
            // 
            TelefonnummerLabel.AutoSize = true;
            TelefonnummerLabel.Location = new Point(12, 120);
            TelefonnummerLabel.Name = "TelefonnummerLabel";
            TelefonnummerLabel.Size = new Size(92, 15);
            TelefonnummerLabel.TabIndex = 16;
            TelefonnummerLabel.Text = "Telefonnummer";
            // 
            // CPRNummerLabel
            // 
            CPRNummerLabel.AutoSize = true;
            CPRNummerLabel.Location = new Point(246, 120);
            CPRNummerLabel.Name = "CPRNummerLabel";
            CPRNummerLabel.Size = new Size(82, 15);
            CPRNummerLabel.TabIndex = 17;
            CPRNummerLabel.Text = "CPR-Nummer";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(12, 180);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(41, 15);
            EmailLabel.TabIndex = 18;
            EmailLabel.Text = "E-mail";
            // 
            // SøgeområdeLabel
            // 
            SøgeområdeLabel.AutoSize = true;
            SøgeområdeLabel.Location = new Point(12, 242);
            SøgeområdeLabel.Name = "SøgeområdeLabel";
            SøgeområdeLabel.Size = new Size(74, 15);
            SøgeområdeLabel.TabIndex = 19;
            SøgeområdeLabel.Text = "Søgeområde";
            // 
            // PrisklasseLabel
            // 
            PrisklasseLabel.AutoSize = true;
            PrisklasseLabel.Location = new Point(12, 299);
            PrisklasseLabel.Name = "PrisklasseLabel";
            PrisklasseLabel.Size = new Size(57, 15);
            PrisklasseLabel.TabIndex = 20;
            PrisklasseLabel.Text = "Prisklasse";
            // 
            // BoligtypeLabel
            // 
            BoligtypeLabel.AutoSize = true;
            BoligtypeLabel.Location = new Point(246, 299);
            BoligtypeLabel.Name = "BoligtypeLabel";
            BoligtypeLabel.Size = new Size(57, 15);
            BoligtypeLabel.TabIndex = 21;
            BoligtypeLabel.Text = "Boligtype";
            // 
            // GrundstørrelseLabel
            // 
            GrundstørrelseLabel.AutoSize = true;
            GrundstørrelseLabel.Location = new Point(12, 369);
            GrundstørrelseLabel.Name = "GrundstørrelseLabel";
            GrundstørrelseLabel.Size = new Size(84, 15);
            GrundstørrelseLabel.TabIndex = 22;
            GrundstørrelseLabel.Text = "Grundstørrelse";
            // 
            // VærelserLabel
            // 
            VærelserLabel.AutoSize = true;
            VærelserLabel.Location = new Point(166, 369);
            VærelserLabel.Name = "VærelserLabel";
            VærelserLabel.Size = new Size(51, 15);
            VærelserLabel.TabIndex = 23;
            VærelserLabel.Text = "Værelser";
            // 
            // BoligstørrelseLabel
            // 
            BoligstørrelseLabel.AutoSize = true;
            BoligstørrelseLabel.Location = new Point(281, 369);
            BoligstørrelseLabel.Name = "BoligstørrelseLabel";
            BoligstørrelseLabel.Size = new Size(78, 15);
            BoligstørrelseLabel.TabIndex = 24;
            BoligstørrelseLabel.Text = "Boligstørrelse";
            // 
            // YderligereInfoLabel
            // 
            YderligereInfoLabel.AutoSize = true;
            YderligereInfoLabel.Location = new Point(12, 441);
            YderligereInfoLabel.Name = "YderligereInfoLabel";
            YderligereInfoLabel.Size = new Size(125, 15);
            YderligereInfoLabel.TabIndex = 25;
            YderligereInfoLabel.Text = "Yderligere Information";
            // 
            // boligtypeCombobox
            // 
            boligtypeCombobox.ForeColor = SystemColors.ControlText;
            boligtypeCombobox.FormattingEnabled = true;
            boligtypeCombobox.Items.AddRange(new object[] { "Villa", "Lejlighed", "Rækkehus", "Andelsbolig", "Ejerlejlighed", "Parcelhus", "Sommerhus", "Kolonihavehus", "Landejendom", "Flerfamiliehus", "Byhus", "Dobbelthus", "Tolvhus", "Fritidshus", "Penthouse", "Studiolejlighed", "Ungdomsbolig", "Ældrebolig", "Almennyttig bolig", "Bofællesskab" });
            boligtypeCombobox.Location = new Point(246, 317);
            boligtypeCombobox.Name = "boligtypeCombobox";
            boligtypeCombobox.Size = new Size(183, 23);
            boligtypeCombobox.TabIndex = 26;
            boligtypeCombobox.Text = "Vælg Boligtype...";
            boligtypeCombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // anullerButton
            // 
            anullerButton.BackColor = Color.IndianRed;
            anullerButton.Location = new Point(12, 609);
            anullerButton.Name = "anullerButton";
            anullerButton.Size = new Size(93, 39);
            anullerButton.TabIndex = 27;
            anullerButton.Text = "Annuller";
            anullerButton.UseVisualStyleBackColor = false;
            anullerButton.Click += anullerButton_Click;
            // 
            // opretButton
            // 
            opretButton.BackColor = Color.LimeGreen;
            opretButton.Location = new Point(336, 609);
            opretButton.Name = "opretButton";
            opretButton.Size = new Size(93, 39);
            opretButton.TabIndex = 28;
            opretButton.Text = "Opret";
            opretButton.UseVisualStyleBackColor = false;
            opretButton.Click += opretButton_Click;
            // 
            // yderligereinfoTextBox
            // 
            yderligereinfoTextBox.ForeColor = SystemColors.ControlText;
            yderligereinfoTextBox.Location = new Point(12, 459);
            yderligereinfoTextBox.Name = "yderligereinfoTextBox";
            yderligereinfoTextBox.Size = new Size(417, 144);
            yderligereinfoTextBox.TabIndex = 29;
            yderligereinfoTextBox.Text = "Relevant info...";
            // 
            // TilføjKøber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 246, 182);
            ClientSize = new Size(449, 662);
            Controls.Add(yderligereinfoTextBox);
            Controls.Add(opretButton);
            Controls.Add(anullerButton);
            Controls.Add(boligtypeCombobox);
            Controls.Add(YderligereInfoLabel);
            Controls.Add(BoligstørrelseLabel);
            Controls.Add(VærelserLabel);
            Controls.Add(GrundstørrelseLabel);
            Controls.Add(BoligtypeLabel);
            Controls.Add(PrisklasseLabel);
            Controls.Add(SøgeområdeLabel);
            Controls.Add(EmailLabel);
            Controls.Add(CPRNummerLabel);
            Controls.Add(TelefonnummerLabel);
            Controls.Add(AdresseLabel);
            Controls.Add(EfternavnLabel);
            Controls.Add(NavnLabel);
            Controls.Add(efternavnTextbox);
            Controls.Add(grundstørrelseTextbox);
            Controls.Add(boligstørrelseTextbox);
            Controls.Add(prisklasseTextbox);
            Controls.Add(værelserTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(søgeområdeTextbox);
            Controls.Add(telefonnummerTextbox);
            Controls.Add(adresseTextbox);
            Controls.Add(cprnummerTextbox);
            Controls.Add(navnTextbox);
            Name = "TilføjKøber";
            Text = "Tilføj Køber";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox navnTextbox;
        private TextBox cprnummerTextbox;
        private TextBox adresseTextbox;
        private TextBox telefonnummerTextbox;
        private TextBox søgeområdeTextbox;
        private TextBox emailTextbox;
        private TextBox værelserTextbox;
        private TextBox prisklasseTextbox;
        private TextBox boligstørrelseTextbox;
        private TextBox grundstørrelseTextbox;
        private TextBox efternavnTextbox;
        private Label NavnLabel;
        private Label EfternavnLabel;
        private Label AdresseLabel;
        private Label TelefonnummerLabel;
        private Label CPRNummerLabel;
        private Label EmailLabel;
        private Label SøgeområdeLabel;
        private Label PrisklasseLabel;
        private Label BoligtypeLabel;
        private Label GrundstørrelseLabel;
        private Label VærelserLabel;
        private Label BoligstørrelseLabel;
        private Label YderligereInfoLabel;
        private ComboBox boligtypeCombobox;
        private Button anullerButton;
        private Button opretButton;
        private RichTextBox yderligereinfoTextBox;
    }
}