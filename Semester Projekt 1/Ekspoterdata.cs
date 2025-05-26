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
            boligStatus.DataSource = new List<string>() { "Solgt", "Ikke Solgt", "Alle" };
            InitializeElements();
        }
        private void InitializeElements()
        {
            int[] rowHeight = tableLayoutPanel2.GetRowHeights();
            dataFlowPanel.Height = rowHeight[0] + rowHeight[1];
        }
        private void selectDataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectDataComboBox.Text == "Køber")
            {
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                boligStatus.SelectedIndex = -1;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "CprNr", "Adresse", "KøberID", "PrisKlasse", "SøgeOmråde", "BoligType", "Noter", "ØnsketGrundStørrelse", "ØnsketBoligStørrelse", "ØnsketVærelser" };
                boligByNavn.Text = "";
            }
            else if (selectDataComboBox.Text == "Sælger")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "CprNr", "Adresse", "SælgerID" };
                boligByNavn.Text = "";
            }
            else if (selectDataComboBox.Text == "Salg")
            {
                boligStatus.SelectedIndex = -1;
                boligByNavn.Text = "";
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "KøberID", "BoligID", "Beløb", "SalgsID" };
            }
            else if (selectDataComboBox.Text == "Boliger")
            {
                dataFlowPanel.Height = tableLayoutPanel2.Height;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "BoligID", "Pris", "Adresse", "Postnummer", "ByNavn", "BoligType", "BoligAreal", "Værelser", "ByggeDato", "GrundStørrelse", "EnergiMærke", "EjendomsmæglerID", "SælgerID", "Status" };
            }
            else if (selectDataComboBox.Text == "Ejendomsmæglere")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>() { "Fornavn", "EfterNavn", "Email", "TlfNummer", "Brugernavn", "MæglerID" };
                boligByNavn.Text = "";
            }
            else if (selectDataComboBox.Text == "")
            {
                boligStatus.SelectedIndex = -1;
                dataFlowPanel.Height = selectDataComboBox.Height + label1.Height + 10;
                sortByComboBox.Enabled = false;
                sortByComboBox.DataSource = null;
                boligByNavn.Text = "";
            }
        }

        private void eksporterDataKnap_Click(object sender, EventArgs e)
        {
            string data = selectDataComboBox.Text;
            string sortBy = sortByComboBox.Text;
            string status = "";
            string bynavn = boligByNavn.Text;
            status = boligStatus.Text;
            if(status != ""||bynavn != "")
            {
                BusineesLogic.EksporterText eksportText = new BusineesLogic.EksporterText();
                string eks = eksportText.EksporterBoligSælgerText(bynavn, status, sortBy);
                if(eks == "Ingen boliger fundet med det bynavn")
                {
                    MessageBox.Show(eks, "Eksport af data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(eks, "Eksport af data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                BusineesLogic.EksportLogik eksportLogik = new BusineesLogic.EksportLogik();
                string besked = eksportLogik.eksportData(data, sortBy);
                MessageBox.Show(besked, "Eksport af data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Ekspoterdata_Load(object sender, EventArgs e)
        {

        }
    }
}
