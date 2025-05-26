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
    public partial class Delete_Sell : Form
    {
        int BoligID;
        public Delete_Sell(int boligID)
        {
            InitializeComponent();
            BoligID = boligID;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaleRegistration saleRegistration = new SaleRegistration(BoligID);
            saleRegistration.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hent værdien af BoligID i den valgte række

            DeleteBolig deleteBolig = new DeleteBolig(BoligID);
            deleteBolig.Show();
        }
    }
}
