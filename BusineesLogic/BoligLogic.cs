using DataAccess.Repositories;
using Models;

namespace BusineesLogic
{
    public class BoligLogic
    {
        private DataRepository repository;
        public List<string> Regions = new List<string>() { "Nordjylland", "Syddanmark", "Sjælland", "Hovedstaden", "Midtjylland" };
        public List<string> SaleStatusList = new List<string>() { "Til Salg", "Solgt", "Under behandling" };
        public List<string> BoligTypes = new List<string>() { "Hus", "Rækkehus", "Lejlighed" };


        public BoligLogic()
        {
            // Special connection string for Ruben's "special" pc
            //repository = new("Server = DESKTOP-LKSSI4H\\SQLEXPRESS; Database = Semester projekt gruppe 1;Trusted_Connection = True; TrustServerCertificate = True;");

            // For normal people 
            repository = new();
        }
        public static string GetConnectionString() // bruges til kald af metode i BoligFilter
        {
            // Special connection string for Ruben's "special" pc
            //return "Server = DESKTOP-LKSSI4H\\SQLEXPRESS; Database = Semester projekt gruppe 1;Trusted_Connection = True; TrustServerCertificate = True;";
            // For normal people 
            return "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; Trusted_Connection = True; TrustServerCertificate=True;";
        }

        public List<Sælger> GetSælgerList()
        {
            return new List<Sælger>()
            {
                new Sælger(1, "Lars", "Jensen", 22334455, "lars.jensen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(2, "Maria", "Andersen", 11223344, "maria.andersen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(3, "Thomas", "Nielsen", 33445566, "thomas.nielsen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(4, "Camilla", "Pedersen", 55667788, "camilla.pedersen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(5, "Jonas", "Christensen", 66778899, "jonas.christensen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(6, "Sofie", "Larsen", 99887766, "sofie.larsen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(7, "Emil", "Madsen", 77889900, "emil.madsen@example.com", "12345678-1234", "hejsaalle")
            };
        }

        public void CreateBolig(
            int pris, string adresse, int postnr, string by, string boligType, int boligAreal, int værelser,
            DateTime byggeDato, int grundAreal, int mæglerId, int sæglerID, string energiMærke, string status
            )
        {
            var tempBolig = new Bolig(
                pris, adresse, postnr, by, boligType, boligAreal, værelser,
                byggeDato, grundAreal, mæglerId, sæglerID, energiMærke, status
            );
            repository.CreateBolig(tempBolig);
        }

        public Bolig GetBolig(int boligID)
        {
            //repository.getSingleBolig(boligID);
            var bolig = repository.GetSingleBolig(boligID);
            //var bolig = new Bolig(boligID, 700000, "testvej 28", 7000, "testby", "Villa", 700, 17, DateTime.Now, 900000, 2, 1);
            return bolig;
        }

        public void UpdateBoligPris(Bolig bolig)
        {
            repository.UpdatePris(bolig.BoligID, bolig.Pris);

        }

        public int PrisEsmator(int boligAreal, int grundAreal, int værelser, string boligType)
        {
            int estimation = 0;
            //find gennemsnits kvadrat meter pris for boligtyperne i danmark
            //jord koster cirka 20 kr. pr. m2 i danmark
            //vi kunne også inkludere mængden af badeværelser og soveværelser i vores data.
            //den endelige formuar ville være noget ligende:
            //pris = boligAreal * kvadratmeterpris + grundAreal * 20 + værelser * 1000000 + boligType * 1000000
            //eller noget i den stil
            return estimation;
        }
    }
}
