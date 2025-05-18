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
    public partial class SaleRegistrationAdresse : Form
    {
        public SaleRegistrationAdresse()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#FFF6B6");
            panel1.BackColor = ColorTranslator.FromHtml("#FFF6DA");
            saleRegistrationAdresseVælgButton.BackColor = ColorTranslator.FromHtml("#2DC75C");
            saleRegistrationAnnullerButton.BackColor = ColorTranslator.FromHtml("#FF6464");
        }

        private void SaleRegistrationAdresseOverskrift_Click(object sender, EventArgs e)
        {

        }

        private void saleRegistrationAnnullerButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
