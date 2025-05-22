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
    public partial class MæglerSide : UserControl
    {
        public MæglerSide()
        {
            InitializeComponent();
            mæglerSøgeFelt.PlaceholderText = "Søg Navn...";
            HentEjendomsmægler();
            mæglerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void HentEjendomsmægler(int? mæglerID = 0)
        {
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.HentEjendomsmæglere(conn);
                OpdaterEjendomsmæglerDataGrid(result);
            }
        }
        public void OpdaterEjendomsmæglerDataGrid(List<Ejendomsmægler> ejendomsmægler)
        {
            mæglerDataGridView.DataSource = null;
            mæglerDataGridView.DataSource = ejendomsmægler;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mæglerDataGridView.Columns.Contains("EjendomsmæglerID"))
                mæglerDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mæglerDataGridView.Columns.Contains("SælgerID"))
                mæglerDataGridView.Columns["SælgerID"].Visible = false;
            mæglerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
