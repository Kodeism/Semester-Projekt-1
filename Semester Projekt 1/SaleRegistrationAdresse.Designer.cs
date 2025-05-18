namespace Semester_Projekt_1
{
    partial class SaleRegistrationAdresse
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
            panel1 = new Panel();
            saleRegistrationAdresseVælgButton = new Button();
            saleRegistrationAnnullerButton = new Button();
            vælgAdresseCombobox = new ComboBox();
            SaleRegistrationAdresseOverskrift = new Label();
            sælgerCprTextbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sælgerCprTextbox);
            panel1.Controls.Add(saleRegistrationAdresseVælgButton);
            panel1.Controls.Add(saleRegistrationAnnullerButton);
            panel1.Controls.Add(vælgAdresseCombobox);
            panel1.Controls.Add(SaleRegistrationAdresseOverskrift);
            panel1.Location = new Point(88, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 535);
            panel1.TabIndex = 0;
            // 
            // saleRegistrationAdresseVælgButton
            // 
            saleRegistrationAdresseVælgButton.Location = new Point(703, 411);
            saleRegistrationAdresseVælgButton.Name = "saleRegistrationAdresseVælgButton";
            saleRegistrationAdresseVælgButton.Size = new Size(223, 85);
            saleRegistrationAdresseVælgButton.TabIndex = 3;
            saleRegistrationAdresseVælgButton.Text = "Vælg";
            saleRegistrationAdresseVælgButton.UseVisualStyleBackColor = true;
            // 
            // saleRegistrationAnnullerButton
            // 
            saleRegistrationAnnullerButton.Location = new Point(61, 411);
            saleRegistrationAnnullerButton.Name = "saleRegistrationAnnullerButton";
            saleRegistrationAnnullerButton.Size = new Size(223, 85);
            saleRegistrationAnnullerButton.TabIndex = 2;
            saleRegistrationAnnullerButton.Text = "Annuller";
            saleRegistrationAnnullerButton.UseVisualStyleBackColor = true;
            saleRegistrationAnnullerButton.Click += saleRegistrationAnnullerButton_Click;
            // 
            // vælgAdresseCombobox
            // 
            vælgAdresseCombobox.Font = new Font("Segoe UI", 12F);
            vælgAdresseCombobox.ForeColor = SystemColors.GrayText;
            vælgAdresseCombobox.FormattingEnabled = true;
            vælgAdresseCombobox.Location = new Point(61, 295);
            vælgAdresseCombobox.Name = "vælgAdresseCombobox";
            vælgAdresseCombobox.Size = new Size(866, 62);
            vælgAdresseCombobox.TabIndex = 1;
            vælgAdresseCombobox.Text = "Vælg den solgte boligs adresse ...";
            // 
            // SaleRegistrationAdresseOverskrift
            // 
            SaleRegistrationAdresseOverskrift.AutoSize = true;
            SaleRegistrationAdresseOverskrift.BorderStyle = BorderStyle.FixedSingle;
            SaleRegistrationAdresseOverskrift.Font = new Font("Segoe UI", 16F);
            SaleRegistrationAdresseOverskrift.Location = new Point(1, 1);
            SaleRegistrationAdresseOverskrift.MinimumSize = new Size(993, 0);
            SaleRegistrationAdresseOverskrift.Name = "SaleRegistrationAdresseOverskrift";
            SaleRegistrationAdresseOverskrift.Size = new Size(993, 74);
            SaleRegistrationAdresseOverskrift.TabIndex = 0;
            SaleRegistrationAdresseOverskrift.Text = "Indtast adresse til nyt salg";
            SaleRegistrationAdresseOverskrift.Click += SaleRegistrationAdresseOverskrift_Click;
            // 
            // sælgerCprTextbox
            // 
            sælgerCprTextbox.Font = new Font("Segoe UI", 12F);
            sælgerCprTextbox.ForeColor = SystemColors.GrayText;
            sælgerCprTextbox.Location = new Point(61, 160);
            sælgerCprTextbox.Name = "sælgerCprTextbox";
            sælgerCprTextbox.Size = new Size(865, 61);
            sælgerCprTextbox.TabIndex = 4;
            sælgerCprTextbox.Text = "DDMMÅÅ-****";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 116);
            label1.Name = "label1";
            label1.Size = new Size(229, 41);
            label1.TabIndex = 5;
            label1.Text = "Sælgers CPR-Nr";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 253);
            label2.Name = "label2";
            label2.Size = new Size(123, 41);
            label2.TabIndex = 6;
            label2.Text = "Adresse";
            // 
            // SaleRegistrationAdresse
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 689);
            Controls.Add(panel1);
            Name = "SaleRegistrationAdresse";
            Text = "SaleRegistrationAdresse";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label SaleRegistrationAdresseOverskrift;
        private Button saleRegistrationAdresseVælgButton;
        private Button saleRegistrationAnnullerButton;
        private ComboBox vælgAdresseCombobox;
        private TextBox sælgerCprTextbox;
        private Label label2;
        private Label label1;
    }
}