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
        DataGridViewRow Row;
        public Delete_Sell(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaleRegistration saleRegistration = new SaleRegistration(Convert.ToInt32(Row.Cells["BoligID"].Value));
            saleRegistration.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hent værdien af BoligID i den valgte række
            var boligIDValue = Row.Cells["BoligID"].Value;

            int boligID = Convert.ToInt32(boligIDValue);

            DeleteBolig deleteBolig = new DeleteBolig(boligID);
            deleteBolig.Show();
        }
    }
}
