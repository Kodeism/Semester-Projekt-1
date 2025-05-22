using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Projekt_1
{
    public partial class Ekspoterdata : Form
    {
        public Ekspoterdata()
        {
            InitializeComponent();
            eksporterDataKnap.Enabled = false;
            boligStatus.DataSource = new List<string>() { "Solgt", "Til salg", "Alle"};
        }
        private void selectDataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectDataComboBox.Text == "Køber")
            {
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                boligStatus.SelectedIndex = -1;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "CprNr", "Adresse", "KøberID", "PrisKlasse", "SøgeOmråde", "BoligType", "Noter", "ØnsketGrundStørrelse", "ØnsketBoligStørrelse", "ØnsketVærelser" };
                eksporterDataKnap.Enabled = true;
            }
            else if (selectDataComboBox.Text == "Sælger")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "CprNr", "Adresse", "SælgerID" };
                eksporterDataKnap.Enabled = true;
            }
            else if (selectDataComboBox.Text == "Salg")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "SælgerID", "KøberID", "BoligID", "Beløb", "SalgsID" };
                eksporterDataKnap.Enabled = true;
            }
            else if (selectDataComboBox.Text == "Boliger")
            {
                dataFlowPanel.Height = boligStatus.Height + label1.Height + label2.Height + selectDataComboBox.Height + 15;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "BoligID", "Pris", "Adresse", "Postnummer", "ByNavn", "BoligType", "BoligAreal", "Værelser", "ByggeDato", "GrundStørrelse", "EnergiMærke", "EjendomsmæglerID", "SælgerID", "Status" };
                eksporterDataKnap.Enabled = true;
            }
            else if (selectDataComboBox.Text == "Ejendomsmæglere")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "Brugernavn", "MæglerID" };
                eksporterDataKnap.Enabled = true;
            }
            else if (selectDataComboBox.Text == "")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = false;
                sortByComboBox.DataSource = null;
                eksporterDataKnap.Enabled = false;
            }
        }

        private void eksporterDataKnap_Click(object sender, EventArgs e)
        {
            eksporterDataKnap.Enabled = false;
            string data = selectDataComboBox.Text;
            string sortBy = sortByComboBox.Text;
            if (boligStatus.Text=="Solgt")
            {

            }
            else if (boligStatus.Text == "Til salg")
            {

            }
            else
            {
                BusineesLogic.EksportLogik eksportLogik = new BusineesLogic.EksportLogik();
                string besked = eksportLogik.eksportData(data, sortBy);
                MessageBox.Show(besked, "Eksport af data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
