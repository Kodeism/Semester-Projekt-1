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
    public partial class duoForside : UserControl
    {
        public enum Mode { Salg, Boliger, Købere, Sælgere }
        private Mode _mode;
        private Mode currentMode;
        public duoForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void SetMode(Mode mode)
        {
            currentMode = mode;
            _mode = mode;
            switch (_mode)
            {
                case Mode.Salg:
                    mineLabel.Text = "Mine Salg";
                    alleLabel.Text = "Alle Salg";
                    mineSøgeFelt.Text = "Søg Adresse...";
                    alleSøgeFelt.Text = "Søg Adresse...";
                    HentSalgLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.Sælgere:
                    mineLabel.Text = "Mine Sælgere";
                    alleLabel.Text = "Alle Sælgere";
                    mineSøgeFelt.Text = "Søg Navn...";
                    alleSøgeFelt.Text = "Søg Navn...";
                    HentSælgerLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.Købere:
                    mineLabel.Text = "Mine Købere";
                    alleLabel.Text = "Alle Købere";
                    mineSøgeFelt.Text = "Søg Navn...";
                    alleSøgeFelt.Text = "Søg Navn...";
                    HentKøberLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.Boliger:
                    mineLabel.Text = "Mine Boliger";
                    alleLabel.Text = "Alle Boliger";
                    mineSøgeFelt.Text = "Søg Adresse...";
                    alleSøgeFelt.Text = "Søg Adresse...";
                    HentBoligLoad(SessionManager.EjendomsmæglerId);
                    break;
            }
        }

        public void OpdaterAlleSælgerDataGrid(List<Sælger> sælgerer)
        {
            alleDataGridView.DataSource = null;
            alleDataGridView.DataSource = sælgerer;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (alleDataGridView.Columns.Contains("SælgerID"))
                alleDataGridView.Columns["SælgerID"].Visible = false;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        public void OpdaterMineSælgerDataGrid(List<Sælger> sælgerer)
        {
            mineDataGridView.DataSource = null;
            mineDataGridView.DataSource = sælgerer;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mineDataGridView.Columns.Contains("SælgerID"))
                mineDataGridView.Columns["SælgerID"].Visible = false;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void OpdaterMineSalgDataGrid(List<Salg> salg)
        {
            mineDataGridView.DataSource = null;
            mineDataGridView.DataSource = salg;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mineDataGridView.Columns.Contains("SælgerID"))
                mineDataGridView.Columns["SælgerID"].Visible = false;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void OpdaterAlleSalgDataGrid(List<Salg> salg)
        {
            alleDataGridView.DataSource = null;
            alleDataGridView.DataSource = salg;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (alleDataGridView.Columns.Contains("SælgerID"))
                alleDataGridView.Columns["SælgerID"].Visible = false;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void HentSalgLoad(int? mæglerID = 0)
        {
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.HentSalg(conn);
                OpdaterMineSalgDataGrid(result);
                result = DataRepository.HentSalg(conn, mæglerID);
                OpdaterAlleSalgDataGrid(result);
            }
        }
        private void HentSælgerLoad(int? mæglerID = 0)
        {
            var sælgerFilter = new Models.SælgerFilter();
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgSælgerMedFilter(conn, sælgerFilter, mæglerID);
                OpdaterMineSælgerDataGrid(result);
                result = DataRepository.SøgSælgerMedFilter(conn, sælgerFilter);
                OpdaterAlleSælgerDataGrid(result);
            }
        }
        private void HentKøberLoad(int? mæglerID = 0)
        {
            var køberFilter = new Models.KøberFilter();
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgKøberMedFilter(conn, køberFilter, mæglerID);
                OpdaterMineKøberDataGrid(result);
                result = DataRepository.SøgKøberMedFilter(conn, køberFilter);
                OpdaterAlleKøberDataGrid(result);
            }
        }
        public void OpdaterMineKøberDataGrid(List<Køber> køber)
        {
            mineDataGridView.DataSource = null;
            mineDataGridView.DataSource = køber;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mineDataGridView.Columns.Contains("SælgerID"))
                mineDataGridView.Columns["SælgerID"].Visible = false;

            mineDataGridView.Columns["KøberInfo"].Visible = false;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        public void OpdaterAlleKøberDataGrid(List<Køber> køber)
        {
            alleDataGridView.DataSource = null;
            alleDataGridView.DataSource = køber;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (alleDataGridView.Columns.Contains("SælgerID"))
                alleDataGridView.Columns["SælgerID"].Visible = false;

            alleDataGridView.Columns["KøberInfo"].Visible = false;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void OpdaterMineBoligerDataGrid(List<Bolig> boliger)
        {
            mineDataGridView.DataSource = null;
            mineDataGridView.DataSource = boliger;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mineDataGridView.Columns.Contains("SælgerID"))
                mineDataGridView.Columns["SælgerID"].Visible = false;
            mineDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        public void OpdaterAlleBoligerDataGrid(List<Bolig> boliger)
        {
            alleDataGridView.DataSource = null;
            alleDataGridView.DataSource = boliger;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (alleDataGridView.Columns.Contains("SælgerID"))
                alleDataGridView.Columns["SælgerID"].Visible = false;
            alleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
        private void HentBoligLoad(int? mæglerID = 0)
        {
            var boligFilter = new Models.BoligFilter();

            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter, mæglerID);
                OpdaterMineBoligerDataGrid(result);
                result = DataRepository.SøgMedFilter(conn, boligFilter);
                OpdaterAlleBoligerDataGrid(result);
            }
        }

        private void mineFilterKnap_Click(object sender, EventArgs e)
        {
            BoligFilterForm boligFilterForm = new BoligFilterForm(this, currentMode, true);
            boligFilterForm.Show();
        }

        private void alleFilterKnap_Click(object sender, EventArgs e)
        {
            BoligFilterForm boligFilterForm = new BoligFilterForm(this, currentMode, false);
            boligFilterForm.Show();
        }

        private void mineRegistrerKnap_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Salg)
            {
                SaleRegistration salg = new SaleRegistration();
                salg.ShowDialog();
            }
            if (_mode == Mode.Sælgere)
            {
                FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
                formTilføjSælger.ShowDialog();
            }
            if (_mode == Mode.Købere)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            if (_mode == Mode.Boliger)
            {
                BoligRegistration formTilføjBolig = new BoligRegistration();
                formTilføjBolig.ShowDialog();
            }
        }

        private void alleRegistrerKnap_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Salg)
            {
                SaleRegistration salg = new SaleRegistration();
                salg.ShowDialog();
            }
            if (_mode == Mode.Sælgere)
            {
                FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
                formTilføjSælger.ShowDialog();
            }
            if (_mode == Mode.Købere)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            if (_mode == Mode.Boliger)
            {
                BoligRegistration formTilføjBolig = new BoligRegistration();
                formTilføjBolig.ShowDialog();
            }
        }
    }
}
