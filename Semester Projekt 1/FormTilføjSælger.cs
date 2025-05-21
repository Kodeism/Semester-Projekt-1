using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusineesLogic;

namespace Semester_Projekt_1
{
    public partial class FormTilføjSælger : Form
    {
        public FormTilføjSælger()
        {
            InitializeComponent();
            sælgerCprNummerTextbox.PlaceholderText = "DDMMÅÅ-****";
        }

        private void SælgerTelefonNummerTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormTilføjSælger_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FFF6B6");
            panel1.BackColor = ColorTranslator.FromHtml("#FFF6DA");
            sælgerOpretOpretButton.BackColor = ColorTranslator.FromHtml("#2DC75C");
            sælgerAnnulerOpretButton.BackColor = ColorTranslator.FromHtml("#FF6464");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sælgerOpretOpretButton_Click(object sender, EventArgs e)
        {
            string navn = sælgerFornavnTextbox.Text;
            navn = navn.Trim();
            if (string.IsNullOrEmpty(navn))
            {
                sælgerFornavnTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst fornavn");
            }
            string efternavn = sælgerEfternavnTextbox.Text;
            efternavn = efternavn.Trim();
            if (string.IsNullOrEmpty(efternavn))
            {
                sælgerEfternavnTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst efternavn");
            }
            string adresse = sælgerAdresseTextbox.Text;
            adresse = adresse.Trim();
            if (string.IsNullOrEmpty(adresse))
            {
                sælgerAdresseTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst adresse");
            }

            //Giver error message, og highlighter box med rød, hvis der indtastes andet end tal i til tlfnummer.
            int tlfNummer = 0;
            try
            {
                tlfNummer = int.Parse(SælgerTelefonNummerTextbox.Text);
            }
            catch
            {
                SælgerTelefonNummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i telefonnummerboxen");
                return;
            }
            string cprNummer = sælgerCprNummerTextbox.Text;
            cprNummer = cprNummer.Trim();
            if (string.IsNullOrEmpty(cprNummer))
            {
                sælgerCprNummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst sælgers CPR-NR");
            }
            else if (cprNummer.Length > 11 || cprNummer.Length < 11)
            {
                sælgerCprNummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast CPR med format DDMMÅÅ-****");
            }



            string email = sælgerEmailTextbox.Text;
            email = email.Trim();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                sælgerEmailTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast en gyldig email");
            }
            

            
                SælgerFunktioner sælgerfunktion = new SælgerFunktioner();
            try
            {
                sælgerfunktion.TilføjSælger(navn, efternavn, tlfNummer, email, cprNummer, adresse);
                MessageBox.Show("Sælger er oprettet.");
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Noget gik galt!");
            }
            
        }

        private void sælgerFornavnTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sælgerAnnulerOpretButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
