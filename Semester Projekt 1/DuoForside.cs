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
        private List<Bolig> mineBoligerCache; // til sortering af pris
        private bool sortAscendingPrisMineBoliger = true;
        private List<Bolig> alleBoligerCache; // til sortering af pris
        private bool sortAscendingPrisAlleBoliger = true;
        public enum Mode { Salg, Boliger, Købere, Sælgere }
        private Mode _mode;
        private Mode currentMode;
        public duoForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
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
        }

        public void OpdaterMineBoligerDataGrid(List<Bolig> boliger)
        {
            mineBoligerCache = boliger; // gem den til lokal sortering
            mineDataGridView.DataSource = null;
            mineDataGridView.DataSource = boliger;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (mineDataGridView.Columns.Contains("SælgerID"))
                mineDataGridView.Columns["SælgerID"].Visible = false;

        }
        public void OpdaterAlleBoligerDataGrid(List<Bolig> boliger)
        {
            alleBoligerCache = boliger; // gem den til lokal sortering
            alleDataGridView.DataSource = null;
            alleDataGridView.DataSource = boliger;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (alleDataGridView.Columns.Contains("SælgerID"))
                alleDataGridView.Columns["SælgerID"].Visible = false;

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
            if (currentMode == Mode.Boliger)
            {
                BoligFilterForm boligFilterForm = new BoligFilterForm(this, currentMode, true);
                boligFilterForm.Show();
            }
        }

        private void alleFilterKnap_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Boliger)
            {
                BoligFilterForm boligFilterForm = new BoligFilterForm(this, currentMode, false);
                boligFilterForm.Show();
            }
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

        private string mineLastSortedColumn = "";
        private bool mineSortAscending = true;
        private void mineDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (mineBoligerCache != null && mineBoligerCache.Any())
            {
                string columnName = mineDataGridView.Columns[e.ColumnIndex].Name;

                // Find property på Bolig-objekter der matcher kolonnenavnet
                var propInfo = typeof(Bolig).GetProperty(columnName);
                if (propInfo != null)
                {
                    List<Bolig> sortedList;

                    // Skift sorteringsretning hvis det er samme kolonne som sidst
                    if (mineLastSortedColumn == columnName)
                        sortAscendingPrisMineBoliger = !sortAscendingPrisMineBoliger;
                    else
                        sortAscendingPrisMineBoliger = true;

                    mineLastSortedColumn = columnName;

                    if (sortAscendingPrisMineBoliger)
                        sortedList = mineBoligerCache.OrderBy(b => propInfo.GetValue(b, null)).ToList();
                    else
                        sortedList = mineBoligerCache.OrderByDescending(b => propInfo.GetValue(b, null)).ToList();

                    mineDataGridView.DataSource = null;
                    mineDataGridView.DataSource = sortedList;

                    // Skjul ID-kolonner
                    if (mineDataGridView.Columns.Contains("EjendomsmæglerID"))
                        mineDataGridView.Columns["EjendomsmæglerID"].Visible = false;

                    if (mineDataGridView.Columns.Contains("SælgerID"))
                        mineDataGridView.Columns["SælgerID"].Visible = false;
                }
            }
        }

        private string alleLastSortedColumn = "";
        private bool alleSortAscending = true;
        private void alleDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (alleBoligerCache != null && alleBoligerCache.Any())
            {
                string columnName = alleDataGridView.Columns[e.ColumnIndex].Name;

                // Find property på Bolig-objekter der matcher kolonnenavnet
                var propInfo = typeof(Bolig).GetProperty(columnName);
                if (propInfo != null)
                {
                    List<Bolig> sortedList;

                    // Skift sorteringsretning hvis det er samme kolonne som sidst
                    if (alleLastSortedColumn == columnName)
                        sortAscendingPrisAlleBoliger = !sortAscendingPrisAlleBoliger;
                    else
                        sortAscendingPrisAlleBoliger = true;

                    alleLastSortedColumn = columnName;

                    if (sortAscendingPrisAlleBoliger)
                        sortedList = alleBoligerCache.OrderBy(b => propInfo.GetValue(b, null)).ToList();
                    else
                        sortedList = alleBoligerCache.OrderByDescending(b => propInfo.GetValue(b, null)).ToList();

                    alleDataGridView.DataSource = null;
                    alleDataGridView.DataSource = sortedList;

                    // Skjul ID-kolonner
                    if (alleDataGridView.Columns.Contains("EjendomsmæglerID"))
                        alleDataGridView.Columns["EjendomsmæglerID"].Visible = false;

                    if (alleDataGridView.Columns.Contains("SælgerID"))
                        alleDataGridView.Columns["SælgerID"].Visible = false;
                }
            }
        }

        private void mineDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentMode == Mode.Sælgere)
            {
                if (e.RowIndex >= 0) // Sørger for at det ikke er header-rækken
                {
                    DataGridView mineDataGridView = (DataGridView)sender;

                    // Hent værdien af BoligID i den valgte række
                    var sælgerIDValue = mineDataGridView.Rows[e.RowIndex].Cells["SælgerID"].Value;

                    int sælgerID = Convert.ToInt32(sælgerIDValue);

                    DeleteSælger deleteSælger = new DeleteSælger(sælgerID);
                    deleteSælger.Show();
                }
            }
            if (currentMode == Mode.Boliger)
            {
                if (e.RowIndex < 0)
                    return;
                DataGridViewRow selectedRow = mineDataGridView.Rows[e.RowIndex];
                BoligDetaljer bd = new BoligDetaljer(selectedRow);
                bd.Show();
            }
        }

        private void alleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // burde potentielt også blive udkommenteret, men det er fint indtil videre
            // altså hvorfor kan jeg slette sælgere som ikke har med en specifik ejendomsmægler?
            if (currentMode == Mode.Sælgere)
            {
                if (e.RowIndex >= 0) // Sørger for at det ikke er header-rækken
                {
                    DataGridView alleDataGridView = (DataGridView)sender;

                    // Hent værdien af BoligID i den valgte række
                    var sælgerIDValue = alleDataGridView.Rows[e.RowIndex].Cells["SælgerID"].Value;

                    // Konverter evt. til int hvis nødvendigt
                    int sælgerID = Convert.ToInt32(sælgerIDValue);

                    DeleteSælger deleteSælger = new DeleteSælger(sælgerID);
                    deleteSælger.Show();
                }
            }
            // udkommenteret eftersom det vil være underligt at kunne slette andres boliger
            if (currentMode == Mode.Boliger)
            {
                if (e.RowIndex < 0)
                    return;
                DataGridViewRow selectedRow = alleDataGridView.Rows[e.RowIndex];
                BoligLogic boligLogic = new BoligLogic();
                DataTable datas = boligLogic.GetBoligDetails(Convert.ToInt32(selectedRow.Cells["BoligID"].Value));
                BoligDetaljer bd = new BoligDetaljer(datas);
                bd.Show();
            }
        }
    }
}
