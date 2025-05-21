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
    public partial class salgSide : UserControl
    {
        public enum Mode { Mine, Alle }
        private Mode currentMode;
        public salgSide(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
            salgDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void SetMode(Mode _mode)
        {
            currentMode = _mode;
            switch (_mode)
            {
                case Mode.Mine:
                    salgLabel.Text = "Mine Salg";
                    HentMineSalgLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.Alle:
                    salgLabel.Text = "Alle Salg";
                    HentAlleSalgLoad();
                    break;
            }
        }
        public void OpdaterSalgDataGrid(List<Salg> salg)
        {
            salgDataGridView.DataSource = null;
            salgDataGridView.DataSource = salg;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (salgDataGridView.Columns.Contains("EjendomsmæglerID"))
                salgDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (salgDataGridView.Columns.Contains("SælgerID"))
                salgDataGridView.Columns["SælgerID"].Visible = false;
            salgDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void HentAlleSalgLoad()
        {
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.HentSalg(conn);
                OpdaterSalgDataGrid(result);
                //result = DataRepository.HentSalg(conn, mæglerID);
                //OpdaterSalgDataGrid(result);
            }
        }
        private void HentMineSalgLoad(int? mæglerID = 0)
        {
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.HentSalg(conn, mæglerID);
                OpdaterSalgDataGrid(result);
                //result = DataRepository.HentSalg(conn, mæglerID);
                //OpdaterSalgDataGrid(result);
            }
        }
    }
}
