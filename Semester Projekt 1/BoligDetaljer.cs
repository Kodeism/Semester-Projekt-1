using BusineesLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Projekt_1
{
    public partial class BoligDetaljer : Form
    {
        private List<TextBox> editableTextBoxes;
        private List<ComboBox> editableComboBoxes;
        private BoligLogic boligLogic;
        private Bolig boligDetaljer;
        private DataGridViewRow Bolig;

        public BoligDetaljer(DataGridViewRow bolig)
        {
            InitializeComponent();

            Bolig = bolig;
            boligLogic = new BoligLogic();
            editableTextBoxes = new List<TextBox>() { prisTextBox };
            editableComboBoxes = new List<ComboBox>() { };
            boligInfoLabel.Text = $"Bolig:[{bolig.Cells["BoligID"].Value.ToString()}] Info";
            if(SessionManager.EjendomsmæglerId != Convert.ToInt32(bolig.Cells["EjendomsmæglerID"].Value))
            {
                redigerButton.Enabled = false;
                gemÆndringerButton.Enabled = false;
                createSaleButton.Enabled = false;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createSaleButton_Click(object sender, EventArgs e)
        {
            Delete_Sell delete_Sell = new Delete_Sell(Bolig);
            delete_Sell.ShowDialog();
        }

        private void redigerButton_Click(object sender, EventArgs e)
        {
            foreach (TextBox editBox in editableTextBoxes)
            {
                editBox.Enabled = true;
            }
            foreach (ComboBox editBox in editableComboBoxes)
            {
                editBox.Enabled = true;
            }
        }

        private void BoligDetaljer_Load(object sender, EventArgs e)
        {
            prisTextBox.Text = Bolig.Cells["Pris"].Value.ToString();
            adresseTextBox.Text = Bolig.Cells["Adresse"].Value.ToString();
            byTextBox.Text = Bolig.Cells["ByNavn"].Value.ToString();
            typeTextBox.Text = Bolig.Cells["BoligType"].Value.ToString(); ;
            regionTextBox.Text = "N/A";
            postnrTextBox.Text = Bolig.Cells["Postnummer"].Value.ToString();
            grundArealTextBox.Text = Bolig.Cells["GrundStørrelse"].Value.ToString();
            boligarealTextBox.Text = Bolig.Cells["BoligAreal"].Value.ToString();
            statusTextBox.Text = Bolig.Cells["Status"].Value.ToString();
            energimærkeTextBox.Text = Bolig.Cells["EnergiMærke"].Value.ToString();
            værelserTextBox.Text = Bolig.Cells["Værelser"].Value.ToString();
            mæglerTextBox.Text = Bolig.Cells["EjendomsmæglerID"].Value.ToString();
            sælgerTextBox.Text = Bolig.Cells["SælgerID"].Value.ToString();
            byggeDatoTextBox.Text = Bolig.Cells["ByggeDato"].Value.ToString();
        }

        private void gemÆndringerButton_Click(object sender, EventArgs e)
        {
            int Pris;
            try
            {
                Pris = Convert.ToInt32(prisTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Pris skal inkluderes og kan kun skrives med tal", "Pris", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            boligLogic.UpdateBoligPris(Pris, Convert.ToInt32(Bolig.Cells["BoligID"].Value));
            prisTextBox.Enabled = false;
        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
