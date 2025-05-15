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


        private void FilterFormButton_Click(object sender, EventArgs e)
        {
            // Pris
            int? prisMin = int.TryParse(FilterPriceMinTextbox.Text, out int prisMinVal) ? prisMinVal : (int?)null;
            int? prisMax = int.TryParse(FilterPriceMaxTextBox.Text, out int prisMaxVal) ? prisMaxVal : (int?)null;


            // string prisMin = string.IsNullOrWhiteSpace(FilterPriceMinTextbox.Text) ? null : FilterPriceMinTextbox.Text;
            // string prisMax = string.IsNullOrWhiteSpace(FilterPriceMaxTextBox.Text) ? null : FilterPriceMaxTextBox.Text;


            //// Boligareal
            //int? boligArealMin = int.TryParse(FilterHousingAreaMinTextBox.Text, out int baMin) ? baMin : (int?)null;
            //int? boligArealMax = int.TryParse(FilterHousingAreaMaxTextBox.Text, out int baMax) ? baMax : (int?)null;

            //// Grundstørrelse
            //int? grundStørrelseMin = int.TryParse(FilterPlotAreaMinTextBox.Text, out int gsMin) ? gsMin : (int?)null;
            //int? grundStørrelseMax = int.TryParse(FilterPlotAreaMaxTextBox.Text, out int gsMax) ? gsMax : (int?)null;

            //// Værelser
            //int? værelserMin = int.TryParse(FilterRoomCountMinComboBox.SelectedItem?.ToString(), out int vMin) ? vMin : (int?)null;
            //int? værelserMax = int.TryParse(FilterRoomCountMaxComboBox.SelectedItem?.ToString(), out int vMax) ? vMax : (int?)null;

            //// Adresse
            //string adresse = string.IsNullOrWhiteSpace(FilterAddressTextBox.Text) ? null : FilterAddressTextBox.Text;

            //// By + Postnummer
            //string byNavn = string.IsNullOrWhiteSpace(FilterCityTextBox.Text) ? null : FilterCityTextBox.Text;
            //int? postnummer = int.TryParse(FilterPostnummerTextBox.Text, out int pn) ? pn : (int?)null;

            //// Type
            //string boligType = FilterHousingTypeComboBox.SelectedItem?.ToString();

            //// Byggeår
            ////DateTime? byggeDato = DateTime.TryParse(FilterBuiltDateTextBox.Text, out DateTime bd) ? bd : (DateTime?)null;

            //// Mægler ID
            //int? ejendomsmæglerID = int.TryParse(FilterRealtorTextBox.Text, out int emId) ? emId : (int?)null;

            //// Sælger ID
            //int? sælgerID = int.TryParse(FilterSellerTextBox.Text, out int sælger) ? sælger : (int?)null;

            //// Energimærke
            //string energiMærke = FilterEnergyLabelComboBox.SelectedItem?.ToString();

            //// Status
            //string status = FilterStatusCheckBox.Checked ? "Til Salg" : null;




            var boligFilter = new BoligFilter(
                prisMin ?? 0, prisMax ?? 0//,
                //boligArealMin ?? 0, boligArealMax ?? 0,
                //grundStørrelseMin ?? 0, grundStørrelseMax ?? 0,
                //værelserMin ?? 0, værelserMax ?? 0,
                //adresse, postnummer ?? 0, byNavn,
                //boligType, /*byggeDato ?? DateTime.MinValue,*/
                //ejendomsmæglerID ?? 0, sælgerID ?? 0,
                //energiMærke, status
            );

            using (SqlConnection conn = new SqlConnection(BoligLogic.GetConnectionString()))
            {
                var result = DataRepository.SøgMedFilter(conn, boligFilter);
                boligFilterTest.OpdaterBoligerDataGrid(result);
            }
        }


    }
}
