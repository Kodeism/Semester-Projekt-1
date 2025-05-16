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

        public BoligDetaljer()
        {
            InitializeComponent();

            boligLogic = new BoligLogic();
            boligDetaljer = boligLogic.GetBolig(1);
            editableTextBoxes = new List<TextBox>() { prisTextBox };
            editableComboBoxes = new List<ComboBox>() { };
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createSaleButton_Click(object sender, EventArgs e)
        {
            //opret salg med valgte bolig
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
            prisTextBox.Text = boligDetaljer.Pris.ToString();
            adresseTextBox.Text = boligDetaljer.Adresse;
            byTextBox.Text = boligDetaljer.ByNavn;
            typeComboBox.Text = boligDetaljer.Type;
            regionComboBox.Text = "missing in class and db";
            postnrTextBox.Text = boligDetaljer.PostNummer.ToString();
            grundArealTextBox.Text = boligDetaljer.GrundStørrelse.ToString();
            boligarealTextBox.Text = boligDetaljer.BoligAreal.ToString();
            statusComboBox.Text = boligDetaljer.Status;
            energimærkeTextBox.Text = boligDetaljer.EnergiMærke;
            værelserTextBox.Text = boligDetaljer.Værelser.ToString();


        }

        private void gemÆndringerButton_Click(object sender, EventArgs e)
        {
            boligDetaljer.Pris = int.Parse(prisTextBox.Text);
            boligLogic.UpdateBoligPris(boligDetaljer);
            this.Close();
        }
    }
}
