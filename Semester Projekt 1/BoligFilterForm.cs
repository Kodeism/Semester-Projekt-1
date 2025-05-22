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
    public partial class BoligFilterForm : Form
    {
        private BoligFilterTest boligFilterTest;
        private UniForside uniForside;
        private UniForside.Mode currentModeUni;
        private duoForside duoForside;
        private duoForside.Mode currentModeDuo;
        private bool mine;
        public BoligFilterForm()
        {
            InitializeComponent();

        }
        public BoligFilterForm(UniForside boligForm, UniForside.Mode mode)
        {
            InitializeComponent();
            uniForside = boligForm;
            currentModeUni = mode;
            Debug.WriteLine("Test uni");

        }
        public BoligFilterForm(duoForside boligForm, duoForside.Mode mode, bool erMine)
        {
            InitializeComponent();
            duoForside = boligForm;
            currentModeDuo = mode;
            Debug.WriteLine("Test duo");
            mine = erMine;
        }


        private void FilterFormButton_Click(object sender, EventArgs e) // for hver udfyldt værdi så sendes det til BoligFilter
                                                                        // BoligFilter vil hermed tjekkes igennem for data i DataRepository.cs Med SøgMedFilter() metoden
                                                                        // Hermed sendes en sql query som så bruges til at filtrer data
        {
            // Pris
            int prisMin = 0;
            if (!string.IsNullOrWhiteSpace(FilterPriceMinTextbox.Text))
            {
                int.TryParse(FilterPriceMinTextbox.Text, out prisMin);
            }
            int prisMax = 0;
            if (!string.IsNullOrWhiteSpace(FilterPriceMaxTextBox.Text))
            {
                int.TryParse(FilterPriceMaxTextBox.Text, out prisMax);
            }

            int boligArealMin = 0;
            if (!string.IsNullOrWhiteSpace(FilterHousingAreaMinTextBox.Text))
            {
                int.TryParse(FilterHousingAreaMinTextBox.Text, out boligArealMin);
            }
            int boligArealMax = 0;
            if (!string.IsNullOrWhiteSpace(FilterHousingAreaMaxTextBox.Text))
            {
                int.TryParse(FilterHousingAreaMaxTextBox.Text, out boligArealMax);
            }
            int grundStørrelseMin = 0;
            if (!string.IsNullOrWhiteSpace(FilterPlotAreaMinTextBox.Text))
            {
                int.TryParse(FilterPlotAreaMinTextBox.Text, out grundStørrelseMin);
            }
            int grundStørrelseMax = 0;
            if (!string.IsNullOrWhiteSpace(FilterPlotAreaMaxTextBox.Text))
            {
                int.TryParse(FilterPlotAreaMaxTextBox.Text, out grundStørrelseMax);
            }
            int værelserMin = 0;
            if (FilterRoomCountMinComboBox.SelectedItem != null)
            {
                string selectedValue = FilterRoomCountMinComboBox.SelectedItem.ToString();
                int.TryParse(selectedValue, out værelserMin);
            }
            int værelserMax = 0;
            if (FilterRoomCountMaxComboBox.SelectedItem != null)
            {
                string selectedValue = FilterRoomCountMaxComboBox.SelectedItem.ToString();
                int.TryParse(selectedValue, out værelserMax);
            }

            // Adresse
            string adresse = string.IsNullOrWhiteSpace(FilterAddressTextBox.Text) ? null : FilterAddressTextBox.Text;

            // By + Postnummer
            string byNavn = string.IsNullOrWhiteSpace(FilterCityTextBox.Text) ? null : FilterCityTextBox.Text;

            int postnummer = 0;
            if (!string.IsNullOrWhiteSpace(FilterPostnummerTextBox.Text))
            {
                int.TryParse(FilterPostnummerTextBox.Text, out postnummer);
            }

            // Type
            string boligType = FilterHousingTypeComboBox.SelectedItem?.ToString();

            // Byggeår // mangler at blive lavet
            //DateTime? byggeDato = DateTime.TryParse(FilterBuiltDateTextBox.Text, out DateTime bd) ? bd : (DateTime?)null;

            // Energimærke
            string energiMærke = FilterEnergyLabelComboBox.SelectedItem?.ToString();

            //// Mægler ID
            //int? ejendomsmæglerID = int.TryParse(FilterRealtorTextBox.Text, out int emId) ? emId : (int?)null;
            string ejendomsmæglerNavn = string.IsNullOrWhiteSpace(FilterRealtorTextBox.Text) ? null : FilterRealtorTextBox.Text;

            //// Sælger ID
            //int? sælgerID = int.TryParse(FilterSellerTextBox.Text, out int sælger) ? sælger : (int?)null;
            string sælgerNavn = string.IsNullOrWhiteSpace(FilterSellerTextBox.Text) ? null : FilterSellerTextBox.Text;

            // Status
            string status = FilterStatusComboBox.SelectedItem?.ToString();
            int ejendomsmæglerID = 0;

            if (uniForside != null && currentModeUni == UniForside.Mode.MineB)
            {
                ejendomsmæglerID = SessionManager.EjendomsmæglerId;
            }
            else if (duoForside != null && currentModeDuo == duoForside.Mode.Boliger && mine == true)
            {
                ejendomsmæglerID = SessionManager.EjendomsmæglerId;
            }

                int sælgerID = 0;

            var boligFilter = new BoligFilter(
                prisMin, prisMax,
                boligArealMin, boligArealMax,
                grundStørrelseMin, grundStørrelseMax,
                værelserMin, værelserMax,
                adresse, postnummer,
                byNavn, boligType,
                energiMærke, status,
                ejendomsmæglerNavn, sælgerNavn,
                ejendomsmæglerID, sælgerID
            //byggeDato ?? DateTime.MinValue // mangler at blive lavet
            );

            Debug.WriteLine("id" + ejendomsmæglerID);
            Debug.WriteLine("idsesh" + SessionManager.EjendomsmæglerId);
            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                Debug.WriteLine("duo " + currentModeDuo);
                Debug.WriteLine("uni " + currentModeUni);
                if (uniForside != null && currentModeUni == UniForside.Mode.MineB)
                {
                    var result = DataRepository.SøgMedFilter(conn, boligFilter, ejendomsmæglerID);
                    uniForside.OpdaterBoligerDataGrid(result);
                } else if (uniForside != null && currentModeUni == UniForside.Mode.AlleB)
                {
                    var result = DataRepository.SøgMedFilter(conn, boligFilter, ejendomsmæglerID);
                    uniForside.OpdaterBoligerDataGrid(result);
                }
                else if (duoForside != null && currentModeDuo == duoForside.Mode.Boliger)
                {
                    if (mine)
                    {
                        var result = DataRepository.SøgMedFilter(conn, boligFilter, ejendomsmæglerID);
                        duoForside.OpdaterMineBoligerDataGrid(result);
                    } else
                    {
                        var result = DataRepository.SøgMedFilter(conn, boligFilter, ejendomsmæglerID);
                        duoForside.OpdaterAlleBoligerDataGrid(result);
                    }
                }
            }

        }

    }
}
