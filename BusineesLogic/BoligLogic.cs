using DataAccess.Repositories;
using Models;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace BusineesLogic
{
    public class BoligLogic
    {
        private DataRepository repository;
        public List<string> Regions = new List<string>() { "Nordjylland", "Syddanmark", "Sjælland", "Hovedstaden", "Midtjylland" };
        public List<string> SaleStatusList = new List<string>() { "Til Salg", "Solgt", "Under behandling" };
        public List<string> BoligTypes = new List<string>() { "Ældrebolig", "Rækkehus", "Kolonihavehus", "Villa", "Ungdomsbolig", "Lejlighed", "Sommerhus", "Ejerlejlighed", "Andelsbolig" };


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
                new Sælger(1, "Lars", "Jensen", "22334455", "lars.jensen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(2, "Maria", "Andersen", "11223344", "maria.andersen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(3, "Thomas", "Nielsen", "33445566", "thomas.nielsen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(4, "Camilla", "Pedersen", "55667788", "camilla.pedersen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(5, "Jonas", "Christensen", "66778899", "jonas.christensen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(6, "Sofie", "Larsen", "99887766", "sofie.larsen@example.com", "12345678-1234", "hejsaalle"),
                new Sælger(7, "Emil", "Madsen", "77889900", "emil.madsen@example.com", "12345678-1234", "hejsaalle")
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

        public void UpdateBoligPris(int Pris, int ID)
        {
            repository.UpdatePris(ID, Pris);
        }

        public Dictionary<string,object> getSaleInfo(int boligID)
        {
            // Henter salgsinfo for en given boligID
            return repository.GetSaleInfo(boligID);
        }

        public DataTable GetBoligDetails(int boligID)
        {
            // Henter detaljer for en given boligID
            return repository.getBoligDetail(boligID);
        }

        public int PrisEsmator(int boligAreal, int grundAreal, string boligType, int byggedato)
        {
            //man kunne evt finetune det men jeg tror personligt at dette ville være en god opgave for kunstig intelligens
            //hvis man havde nok data så kunne man evt. træne en model til at inkludere husets lokation via google maps
            //man kunne evt. også lave programmet så det selv checker afstanden til forskellige faciliteter
            //så som skole, supermarked, togstation osv.
            //det ville dog kræve en del data og det ville tage lang tid at implementere.
            //tilstand; Fremragende, God, Acceptabel, Dårlig, Meget dårlig
            return repository.GetGroundPrice(boligType, grundAreal, boligAreal, byggedato)*grundAreal;
        }
    }
}
