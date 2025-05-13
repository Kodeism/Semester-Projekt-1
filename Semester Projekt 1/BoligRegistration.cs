using Models;
using System.ComponentModel;

namespace Semester_Projekt_1
{
    public partial class BoligRegistration : Form
    {
        private BindingList<Sælger> sælgers;
        public BindingList<string> regions = new BindingList<string>() { "Nordjylland", "Syddanmark", "Sjælland", "Hovedstaden", "Midtjylland" };
        public BindingList<string> statusList = new BindingList<string>() { "Til Salg", "Solgt", "Under behandling" };
        public BindingList<string> boligTypes = new BindingList<string>() { "Hus", "Rækkehus", "Lejlighed" };

        public BoligRegistration()
        {
            sælgers = new BindingList<Sælger> ()
                {
                    new Sælger(1, "Lars", "Jensen", 22334455, "lars.jensen@example.com"),
                    new Sælger(2, "Maria", "Andersen", 11223344, "maria.andersen@example.com"),
                    new Sælger(3, "Thomas", "Nielsen", 33445566, "thomas.nielsen@example.com"),
                    new Sælger(4, "Camilla", "Pedersen", 55667788, "camilla.pedersen@example.com"),
                    new Sælger(5, "Jonas", "Christensen", 66778899, "jonas.christensen@example.com"),
                    new Sælger(6, "Sofie", "Larsen", 99887766, "sofie.larsen@example.com"),
                    new Sælger(7, "Emil", "Madsen", 77889900, "emil.madsen@example.com")
                };
            InitializeComponent();

            boligOprettelseSælgerComboBox.DataSource = sælgers;
            boligOprettelseSælgerComboBox.DisplayMember = "Email";
            opretBoligRegionComboBox.DataSource = regions;
            boligOprettelseBoligtypeComboBox.DataSource = boligTypes;
            opretBoligStatusComboBox.DataSource = statusList;
        }

    }
}
