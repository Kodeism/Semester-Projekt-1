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
    public partial class SaleRegistration : Form
    {
        public SaleRegistration()
        {
            InitializeComponent();
            SaleSellerCprTextbox.PlaceholderText = "DDMMÅÅ-****";
            SaleBuyerCPRTextBox.PlaceholderText = "DDMMÅÅ-****";
            SalePriceTextBox.PlaceholderText = "Indtast aftalte salgspris";
        }

        private void SaleRegistrationForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CreateSaleButton_Click(object sender, EventArgs e)
        {

            //Trimmer og tester sælgers cpr nr
            string SælgerCprNr = SaleSellerCprTextbox.Text;
            SælgerCprNr = SælgerCprNr.Trim();
            if (string.IsNullOrEmpty(SælgerCprNr))
            {
                SaleSellerCprTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst købers CPR-NR");
            }
            else if (SælgerCprNr.Length > 11 || SælgerCprNr.Length < 11)
            {
                SaleSellerCprTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast CPR med format DDMMÅÅ-****");
            }

            string adresse = SaleAdresseCombobox.Text;
            if (string.IsNullOrEmpty(adresse))
            {
                SaleAdresseCombobox.BackColor = Color.Red;
                MessageBox.Show("Vælgt venligst en adresse fra listen");
            }


            int salgspris = 0;
            try
            {
                salgspris = int.Parse(SalePriceTextBox.Text);
            }
            catch
            {
                SalePriceTextBox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i feltet");
                return;
            }

            //Kæbers CPR-NR trimmes i enderne, der testes for om den har en værdi sat, og om værdien er præcist 11 lang.
            string CprNr = SaleBuyerCPRTextBox.Text;
            CprNr = CprNr.Trim();
            if (string.IsNullOrEmpty(CprNr))
            {
                SaleBuyerCPRTextBox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst købers CPR-NR");
            }
            else if (CprNr.Length > 11 || CprNr.Length < 11)
            {
                SaleBuyerCPRTextBox.BackColor = Color.Red;
                MessageBox.Show("Indtast CPR med format DDMMÅÅ-****");
            }

            //Henter datetime fra DateTimePicker og konverterer til DateOnly.
            DateOnly dato = DateOnly.FromDateTime(dateTimePicker1.Value);

            
            
            SolgtFunktion solgtFunktion = new SolgtFunktion();
            try
            {
                solgtFunktion.ErklærSolgt(CprNr, adresse, dato, salgspris, SælgerCprNr);
                MessageBox.Show("Salget er oprettet.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Indtastede oplysninger stemmer ikke overens med lagrede oplysninger.");
            }



            }

        private void OpretSolgtBoligDateTImePicker(object sender, EventArgs e)
        {


        }

        private void CancelSaleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaleFormExit_Click(object sender, EventArgs e)
        {

        }

        private void SaleAdressLabel_Click(object sender, EventArgs e)
        {

        }

        private void SaleAdresseCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaleSellerCprTextbox_TextChanged(object sender, EventArgs e)
        {
            //Når denne ændres, vises mulighederne i combobox
            string søgSælgerCPR = SaleSellerCprTextbox.Text;
            søgSælgerCPR = søgSælgerCPR.Trim();
            SolgtFunktion solgtFunktion = new SolgtFunktion();
            
            List <string> adresser = solgtFunktion.SælgerCprTilAdresse(søgSælgerCPR);
            SaleAdresseCombobox.Items.Clear();
            SaleAdresseCombobox.Items.AddRange(adresser.ToArray());






        }
    }
}
