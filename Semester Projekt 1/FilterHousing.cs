using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BusineesLogic;
using DataAccess.Repositories;
using DataAccess;
using Microsoft.Data.SqlClient;
using Models;

namespace Semester_Projekt_1
{
    public partial class FilterHousing : Form
    {
        public FilterHousing()
        {
            InitializeComponent();
        }

        private void FilterFormButton_Click(object sender, EventArgs e)
        {
            string MinPrice = string.IsNullOrWhiteSpace(FilterPriceMinTextbox.Text) ? null : FilterPriceMinTextbox.Text;
            string MaxPrice = string.IsNullOrWhiteSpace(FilterPriceMaxTextBox.Text) ? null : FilterPriceMaxTextBox.Text;

            var boligFilter = new BoligFilter(MinPrice, MaxPrice);


            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result;

            }
        }

    }
}
