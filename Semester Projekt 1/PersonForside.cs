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
    public partial class PersonForside : UserControl
    {
        public PersonForside()
        {
            InitializeComponent();
            sælgereSøgeFelt.PlaceholderText = "Søg Navn...";
            købereSøgeFelt.PlaceholderText = "Søg Navn...";
            mæglerSøgeFelt.PlaceholderText = "Søg Navn...";
        }
        private void sælgereRegistrerKnap_Click(object sender, EventArgs e)
        {
            FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
            formTilføjSælger.ShowDialog();
        }

        private void købereRegistrerKnap_Click(object sender, EventArgs e)
        {
            TilføjKøber tilKøber = new TilføjKøber();
            tilKøber.ShowDialog();
        }
    }
}
