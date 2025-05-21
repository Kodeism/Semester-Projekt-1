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
        }

        //        Køber
        //Sælger
        //Salg
        //Boliger
        //Ejendomsmæglere
        private void selectDataComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if(selectDataComboBox.Text == "Køber")
            {
                sortByComboBox.Enabled = true;
                sortByComboBox.DataSource = new List<string>(){ "Fornavn", "EfterNavn", "Email", "TlfNummer", "CprNr", "Adresse", "KøberID", "PrisKlasse", "SøgeOmråde", "BoligType", "Noter", "ØnsketGrundStørrelse", "ØnsketBoligStørrelse", "ØnsketVærelser" };
                //exportdata(selectDataComboBox.Text, sortByComboBox.Text)
            }
        }
    }
}
