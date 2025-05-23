﻿using BusineesLogic;
using Models;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Semester_Projekt_1
{
    public partial class BoligRegistration : Form
    {
        private BoligLogic boligLogic = new();
        private BindingList<Sælger> sælgerBindings;
        public BindingList<string> regions;
        public BindingList<string> statusList;
        public BindingList<string> boligTypes;

        private List<TextBox> requiredFields;

        public BoligRegistration()
        {
            InitializeComponent();
            // Data bindings
            byggeDatoDatePicker.MaxDate = DateTime.Now;
            sælgerBindings = new BindingList<Sælger>(boligLogic.GetSælgerList());
            regions = new BindingList<string>(boligLogic.Regions);
            statusList = new BindingList<string>(boligLogic.SaleStatusList);
            boligTypes = new BindingList<string>(boligLogic.BoligTypes);

            boligOprettelseSælgerComboBox.DataSource = sælgerBindings;
            boligOprettelseSælgerComboBox.DisplayMember = "Email";
            boligOprettelseSælgerComboBox.ValueMember = "SælgerID";

            opretBoligRegionComboBox.DataSource = regions;
            boligOprettelseBoligtypeComboBox.DataSource = boligTypes;
            opretBoligStatusComboBox.DataSource = statusList;

            // Get required input fields
            requiredFields = new List<TextBox>()
            {
                boligOprettelseBoligPrisTextbox,
                opretBoligAdresseTextbox,
                opretBoligByTextbox,
                opretBoligPostnummerTextBox,
                opretBoligBoligarealTextbox,
                opretBoligGrundarealTextbox,
                opretBoligAntalVærelserTextBox
            };
        }

        private void opretBoligCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opretBoligOpretButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkRequiredFields();

                int pris = int.Parse(boligOprettelseBoligPrisTextbox.Text);
                string adresse = opretBoligAdresseTextbox.Text;
                int postnr = int.Parse(opretBoligPostnummerTextBox.Text);
                string by = opretBoligByTextbox.Text;
                string type = boligOprettelseBoligtypeComboBox.SelectedItem.ToString();
                int boligAreal = int.Parse(opretBoligBoligarealTextbox.Text);
                int værelser = int.Parse(opretBoligAntalVærelserTextBox.Text);
                DateTime byggeDato = byggeDatoDatePicker.Value;
                int grundAreal = int.Parse(opretBoligGrundarealTextbox.Text);
                int mæglerID = (int)boligOprettelseSælgerComboBox.SelectedValue;
                int sælgerID = 2;
                string energimærke = opretBoligEnergimærkeTextBox.Text;
                string status = (string)opretBoligStatusComboBox.SelectedValue;

                boligLogic.CreateBolig(
                        pris, adresse, postnr, by, type, boligAreal, værelser,
                        byggeDato, grundAreal, mæglerID, sælgerID, energimærke, status
                    );
            }
            catch (Exception)
            {
                MessageBox.Show("Husk at udfylde de vigtigste felter", "Check inputs", MessageBoxButtons.OK);
            }

        }

        private void checkRequiredFields()
        {
            bool allGood = true;
            foreach (TextBox field in requiredFields)
            {
                if (field.Text == "")
                {
                    field.BackColor = Color.Red;
                    allGood = false;
                }
            }

            if (allGood)
                return;
            else
                throw new Exception();
        }

        private void enforceInputIsNumber__Keypress(object sender, KeyPressEventArgs e)
        {
            //Explanation:
            //If e.Handled == True, the even has been handled and we return
            //If e.Handled is false, we are not done and the character goes in the textbox
            //Each char has a code to look up in a char table. The expression checks if the character
            // is in the numbers range or is a control character and equates to false if the char is a number.
            e.Handled = (e.KeyChar < '0' || e.KeyChar > '9') && !char.IsControl(e.KeyChar);
        }

        private void requiredField_TextChanged(object sender, EventArgs e)
        {
            foreach (TextBox field in requiredFields)
            {
                if (field.Text != "")
                {
                    field.BackColor = Color.White;
                }
            }
        }
        private bool checkEstimatFields()
        {
            bool allGood = true;
            if (opretBoligGrundarealTextbox.Text == "")
            {
                opretBoligGrundarealTextbox.BackColor = Color.Red;
                allGood = false;
            }
            if (opretBoligBoligarealTextbox.Text == "")
            {
                opretBoligBoligarealTextbox.BackColor = Color.Red;
                allGood = false;
            }
            if (!byggeDatoDatePicker.Checked)
            {
                opretBoligAntalVærelserTextBox.BackColor = Color.Red;
                allGood = false;
            }
            if(boligOprettelseBoligtypeComboBox.SelectedIndex == -1)
            {
                boligOprettelseBoligtypeComboBox.BackColor = Color.Red;
                allGood = false;
            }
            return allGood;
        }
        private void estimatePriceKnap_Click(object sender, EventArgs e)
        {
         if(checkEstimatFields())
            {
                int grundAreal = Convert.ToInt32(opretBoligGrundarealTextbox.Text);
                int boligAreal = int.Parse(opretBoligBoligarealTextbox.Text);
                string boligType = boligOprettelseBoligtypeComboBox.SelectedItem.ToString();
                int byggeDato = byggeDatoDatePicker.Value.Year;
                int pris = boligLogic.PrisEsmator(boligAreal, grundAreal, boligType, byggeDato);
                if (pris == 0)
                {
                    MessageBox.Show("Der er sket en fejl i beregningen af prisen, (evt. ikke nok eksempler at estimere ud fra) prøv igen", "Fejl", MessageBoxButtons.OK);
                }
                boligOprettelseBoligPrisTextbox.Text = pris.ToString();
            }
         else
            {
                MessageBox.Show("Husk at udfylde Grundareal, Boligareal, Boligtype og Byggedato for at estimere prisen", "Check inputs", MessageBoxButtons.OK);
            }
        }
    }
}
