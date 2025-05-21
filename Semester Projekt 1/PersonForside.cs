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
    public partial class PersonForside : UserControl
    {
        public PersonForside()
        {
            InitializeComponent();
            HentEjendomsmægler();
            HentKøberLoad();
            HentSælgerLoad();
        }
        public void OpdaterKøberDataGrid(List<Køber> køber)
        {
            købereDataGridView.DataSource = null;
            købereDataGridView.DataSource = køber;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (købereDataGridView.Columns.Contains("EjendomsmæglerID"))
                købereDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (købereDataGridView.Columns.Contains("SælgerID"))
                købereDataGridView.Columns["SælgerID"].Visible = false;

            købereDataGridView.Columns["KøberInfo"].Visible = false;
            købereDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void OpdaterSælgerDataGrid(List<Sælger> sælgerer)
        {
            sælgereDataGridView.DataSource = null;
            sælgereDataGridView.DataSource = sælgerer;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (sælgereDataGridView.Columns.Contains("EjendomsmæglerID"))
                sælgereDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (sælgereDataGridView.Columns.Contains("SælgerID"))
                sælgereDataGridView.Columns["SælgerID"].Visible = false;
            sælgereDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void HentEjendomsmægler(int? mæglerID = 0)
        {
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.HentEjendomsmæglere(conn);
                OpdaterEjendomsmæglerDataGrid(result);
            }
        }
        private void HentKøberLoad(int? mæglerID = 0)
        {
            var køberFilter = new Models.KøberFilter();
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgKøberMedFilter(conn, køberFilter, mæglerID);
                OpdaterKøberDataGrid(result);
            }
        }
        private void HentSælgerLoad(int? mæglerID = 0)
        {
            var sælgerFilter = new Models.SælgerFilter();
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgSælgerMedFilter(conn, sælgerFilter, mæglerID);
                OpdaterSælgerDataGrid(result);
            }
        }
        public void OpdaterEjendomsmæglerDataGrid(List<Ejendomsmægler> ejendomsmægler)
        {
            mæglerDataGrid.DataSource = null;
            mæglerDataGrid.DataSource = ejendomsmægler;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mæglerDataGrid.Columns.Contains("EjendomsmæglerID"))
                mæglerDataGrid.Columns["EjendomsmæglerID"].Visible = false;

            if (mæglerDataGrid.Columns.Contains("SælgerID"))
                mæglerDataGrid.Columns["SælgerID"].Visible = false;
            mæglerDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}
