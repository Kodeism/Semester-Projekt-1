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
        private List<Bolig> boligerCache; // til sortering af pris

        private Mode mode_;
        public enum Mode { AlleS, MineS, AlleK, MineK, AlleB, MineB }
        private Mode currentMode;

        public UniForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);

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
            if (currentMode == Mode.MineS)
            {
                if (e.RowIndex >= 0) // Sørger for at det ikke er header-rækken
                {
                    DataGridView uniDataGridView = (DataGridView)sender;

                    // Hent værdien af BoligID i den valgte række
                    var sælgerIDValue = uniDataGridView.Rows[e.RowIndex].Cells["SælgerID"].Value;

                    // Konverter evt. til int hvis nødvendigt
                    int sælgerID = Convert.ToInt32(sælgerIDValue);

                    // Brug boligId som du vil
                    DeleteSælger deleteSælger = new DeleteSælger(sælgerID);
                    deleteSælger.Show();
                }
            }
            if (currentMode == Mode.MineB)
            {
                if (e.RowIndex >= 0) // Sørger for at det ikke er header-rækken
                {
                    DataGridView uniDataGridView = (DataGridView)sender;

                    // Hent værdien af BoligID i den valgte række
                    var boligIDValue = uniDataGridView.Rows[e.RowIndex].Cells["BoligID"].Value;

                    // Konverter evt. til int hvis nødvendigt
                    int boligID = Convert.ToInt32(boligIDValue);

                    // Brug boligId som du vil
                    DeleteBolig deleteBolig = new DeleteBolig(boligID);
                    deleteBolig.Show();
                }
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

        private string lastSortedColumn = "";
        private bool sortAscending = true;

        private void uniDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (boligerCache != null && boligerCache.Any())
            {
                string columnName = uniDataGridView.Columns[e.ColumnIndex].Name;

                // Find property på Bolig-objekter der matcher kolonnenavnet
                var propInfo = typeof(Bolig).GetProperty(columnName);
                if (propInfo != null)
                {
                    List<Bolig> sortedList;

                    // Skift sorteringsretning hvis det er samme kolonne som sidst
                    if (lastSortedColumn == columnName)
                        sortAscending = !sortAscending;
                    else
                        sortAscending = true;

                    lastSortedColumn = columnName;

                    if (sortAscending)
                        sortedList = boligerCache.OrderBy(b => propInfo.GetValue(b, null)).ToList();
                    else
                        sortedList = boligerCache.OrderByDescending(b => propInfo.GetValue(b, null)).ToList();

                    uniDataGridView.DataSource = null;
                    uniDataGridView.DataSource = sortedList;

                    // Skjul ID-kolonner
                    if (uniDataGridView.Columns.Contains("EjendomsmæglerID"))
                        uniDataGridView.Columns["EjendomsmæglerID"].Visible = false;

                    if (uniDataGridView.Columns.Contains("SælgerID"))
                        uniDataGridView.Columns["SælgerID"].Visible = false;
                }
            }
        }


    }
}
