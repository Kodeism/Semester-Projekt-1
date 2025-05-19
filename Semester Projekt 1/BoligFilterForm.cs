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
        public BoligFilterForm()
        {
            InitializeComponent();

        }
        public BoligFilterForm(BoligFilterTest boligForm)
        {
            InitializeComponent();
            boligFilterTest = boligForm;

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

            var boligFilter = new BoligFilter(
                prisMin, prisMax, 
                boligArealMin, boligArealMax,
                grundStørrelseMin, grundStørrelseMax,
                værelserMin, værelserMax,
                adresse, postnummer,
                byNavn, boligType, 
                energiMærke, status,
                ejendomsmæglerNavn, sælgerNavn
                //byggeDato ?? DateTime.MinValue // mangler at blive lavet
            );

            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter);
                boligFilterTest.OpdaterBoligerDataGrid(result);

            }
        }

    }
}
