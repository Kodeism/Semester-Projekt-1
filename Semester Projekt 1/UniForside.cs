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
    public partial class UniForside : UserControl
    {
        private bool sortAscendingPris = true;
        private List<Bolig> boligerCache; // Vi gemmer listen her til sortering

        private Mode mode_;
        public enum Mode { AlleS, MineS, AlleK, MineK, AlleB, MineB }
        private Mode currentMode;

        public UniForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
            uniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // skaler størrelse til hele bredden

            mode_ = mode;
        }
        public void SetMode(Mode mode)
        {
            currentMode = mode;
            switch (mode)
            {
                case Mode.AlleS:
                    uniLabel.Text = "Alle Sælgere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    HentSælgerLoad();
                    break;
                case Mode.MineS:
                    uniLabel.Text = "Mine Sælgere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    HentSælgerLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.AlleK:
                    uniLabel.Text = "Alle Købere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    HentKøberLoad();
                    break;
                case Mode.MineK:
                    uniLabel.Text = "Mine Købere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    HentKøberLoad(SessionManager.EjendomsmæglerId);
                    break;
                case Mode.AlleB:
                    uniLabel.Text = "Alle Boliger";
                    uniSøgeFelt.Text = "Søg Adresse...";
                    HentBoligLoad();
                    break;
                case Mode.MineB:
                    uniLabel.Text = "Mine Boliger";
                    uniSøgeFelt.Text = "Søg Adresse...";
                    HentBoligLoad(SessionManager.EjendomsmæglerId);
                    break;
            }
        }

        public void OpdaterKøberDataGrid(List<Køber> køber)
        {
            uniDataGridView.DataSource = null;
            uniDataGridView.DataSource = køber;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (uniDataGridView.Columns.Contains("EjendomsmæglerID"))
                uniDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (uniDataGridView.Columns.Contains("SælgerID"))
                uniDataGridView.Columns["SælgerID"].Visible = false;

            uniDataGridView.Columns["KøberInfo"].Visible = false;
            uniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void OpdaterBoligerDataGrid(List<Bolig> boliger)
        {
            boligerCache = boliger; // gem den til lokal sortering
            uniDataGridView.DataSource = null;
            uniDataGridView.DataSource = boliger;

            if (uniDataGridView.Columns.Contains("EjendomsmæglerID"))
                uniDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (uniDataGridView.Columns.Contains("SælgerID"))
                uniDataGridView.Columns["SælgerID"].Visible = false;

        }

        public void OpdaterSælgerDataGrid(List<Sælger> sælgerer)
        {
            uniDataGridView.DataSource = null;
            uniDataGridView.DataSource = sælgerer;
            // Skjul id som ikke burde blive vist men de bliver vist aligevel
            if (uniDataGridView.Columns.Contains("EjendomsmæglerID"))
                uniDataGridView.Columns["EjendomsmæglerID"].Visible = false;

            if (uniDataGridView.Columns.Contains("SælgerID"))
                uniDataGridView.Columns["SælgerID"].Visible = false;
            uniDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

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
        private void HentBoligLoad(int? mæglerID = 0)
        {
            var boligFilter = new Models.BoligFilter();

            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter, mæglerID);
                OpdaterBoligerDataGrid(result);
            }
        }

        private void uniFilterKnap_Click(object sender, EventArgs e)
        {
            BoligFilterForm boligFilterForm = new BoligFilterForm(this, currentMode);
            boligFilterForm.Show();
        }

        private void uniDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentMode != Mode.MineK)
            {
                return;
            }
            if (e.RowIndex >= 0) // Sørger for at det ikke er header-rækken
            {
                DataGridView uniDataGridView = (DataGridView)sender;

                // Hent værdien af BoligID i den valgte række
                var køberIDValue = uniDataGridView.Rows[e.RowIndex].Cells["KøberID"].Value;

                // Konverter evt. til int hvis nødvendigt
                int køberID = Convert.ToInt32(køberIDValue);

                // Brug boligId som du vil
                TilføjKøber tilføjKøber = new TilføjKøber(køberID);
                tilføjKøber.Show();
            }
        }

        private void uniRegistrerKnap_Click(object sender, EventArgs e)
        {
            if (mode_ == Mode.AlleS || mode_ == Mode.MineS)
            {
                SaleRegistration saleRegistration = new SaleRegistration();
                saleRegistration.ShowDialog();
            }
            else if (mode_ == Mode.AlleK || mode_ == Mode.MineK)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            else if (mode_ == Mode.AlleB || mode_ == Mode.MineB)
            {
                BoligRegistration tilBolig = new BoligRegistration();
                tilBolig.ShowDialog();
            }
        }

        private void uniDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Tjek om det er "Pris"-kolonnen
            if (uniDataGridView.Columns[e.ColumnIndex].Name == "Pris")
            {
                if (boligerCache != null)
                {
                    List<Bolig> sortedList;
                    if (sortAscendingPris)
                        sortedList = boligerCache.OrderBy(b => b.Pris).ToList();
                    else
                        sortedList = boligerCache.OrderByDescending(b => b.Pris).ToList();

                    sortAscendingPris = !sortAscendingPris;

                    uniDataGridView.DataSource = null;
                    uniDataGridView.DataSource = sortedList;

                    // Skjul id som ikke burde blive vist men de bliver vist aligevel
                    if (uniDataGridView.Columns.Contains("EjendomsmæglerID"))
                        uniDataGridView.Columns["EjendomsmæglerID"].Visible = false;

                    if (uniDataGridView.Columns.Contains("SælgerID"))
                        uniDataGridView.Columns["SælgerID"].Visible = false;
                }
            }
        }

    }
}
