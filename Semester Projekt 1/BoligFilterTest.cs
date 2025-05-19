using BusineesLogic;
using DataAccess.Repositories;
using Microsoft.Data.SqlClient;
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
    public partial class BoligFilterTest : Form
    {
        public BoligFilterTest()
        {
            InitializeComponent();
            HentBoligLoad();
        }

        public void OpdaterBoligerDataGrid(List<Bolig> boliger)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = boliger;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (dataGridView1.Columns.Contains("EjendomsmæglerID"))
                dataGridView1.Columns["EjendomsmæglerID"].Visible = false;

            if (dataGridView1.Columns.Contains("SælgerID"))
                dataGridView1.Columns["SælgerID"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoligFilterForm boligFilterForm = new BoligFilterForm(this);
            boligFilterForm.Show();
        }
        private void HentBoligLoad()
        {
            var boligFilter = new Models.BoligFilter();

            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter);
                OpdaterBoligerDataGrid(result);
            }
        }
    }
}

