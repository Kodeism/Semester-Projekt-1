using System;
using DataAccess.Repositories;
using Microsoft.VisualBasic;
using Models;

namespace BusineesLogic
{
    public class SælgerFunktioner
    {
        public void TilføjSælger(string navn, string efternavn, string tlfNummer, string email, string cprNr, string adresse)
        {
            Sælger sælger = new Sælger(navn, efternavn, tlfNummer, email, cprNr, adresse);

            DataRepository testDR = new DataRepository();
            testDR.TilføjSælger(sælger);
        }

    }
    public class KøberFunktioner
    {
        public void TilføjKøber(string navn, string efternavn, string adresse, string tlfNummer, string cprNr, string email, string søgeområde, int prisklasse, string boligtype, int? boligStørrelse, int? grundStørrelse, int? værelser, string køberinfo)
        {
            Køber køber = new Køber(navn, efternavn, tlfNummer, email, prisklasse, boligtype, søgeområde, cprNr, adresse, køberinfo, grundStørrelse, boligStørrelse, værelser);

            DataRepository testDR = new DataRepository();
            testDR.CreateKøber(køber);
        }
    }
    public class ForsideLogic
    {
        private readonly DataRepository testDR = new DataRepository();
        public Dictionary<string, List<object>> Data { get; set; }
        public ForsideLogic()
        {
            Data = testDR.GetForsideData();
        }
    }

    public class SolgtFunktion
    {
        public void ErklærSolgt(string køberCPR, string adresse, DateTime dato, int beløb,string sælgerCPR)
        {
            DataRepository testDR = new DataRepository();
            //Opretter ny solgt bolig i Solgt tabellen i databasen:
            Salg salg = new Salg(testDR.HentKøberIDDB(køberCPR), testDR.HentBoligIDDB(adresse),testDR.HentSælgerIDDB(sælgerCPR), dato, beløb);
            testDR.TilføjSalg(salg);
            //Opdaterer boligens status i bolig tabellen i databasen:
            testDR.MarkerBoligSolgt(testDR.HentBoligIDDB(adresse));
        }

        public List <string> SælgerCprTilAdresse(string sælgerCPR)
        {
            DataRepository testDR = new DataRepository();
            //Skal bruge hentsælgeriddb
            
            return testDR.HentSælgersBoliger(testDR.HentSælgerIDDB(sælgerCPR));
        }

    }

    public class EksportLogik
    {
        public string eksportData(string data, string sortBy, string condition = "")
        {
            string skriveBord = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mappesti = Path.Combine(skriveBord, "MineEksports");
            Directory.CreateDirectory(mappesti);
            string filnavn = $"{data}";
            string filtype = ".json";
            string filsti = Path.Combine(mappesti, $"{filnavn}{filtype}");
            int tæller = 1;
            while(File.Exists(filsti))
            {
                filsti = Path.Combine(mappesti, $"{filnavn}({tæller}){filtype}");
                tæller++;
            }
            DataRepository repository = new DataRepository();
            repository.EksportData(data, sortBy, filsti);
            return $"Data fil: {filnavn+tæller.ToString()+filtype} - nu gemt i Mappe: {mappesti}";
        }
    }
    public class EksporterText
    {
        public void EksporterBoligSælgerText(string bynavn)
        {
            DataRepository testDR = new DataRepository();
            var listeTilEksportering = testDR.EksporterBoligSælgerListe(bynavn);
            String downloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string path = Path.Combine(downloads, "BoligSælgerInfo.txt");



            using (StreamWriter writer = new StreamWriter(path)) 
            {
                {
                    writer.WriteLine("Adresse : Bynavn : Fornavn : Efternavn : Email : Tlfnummer");
                    foreach (var bolig in listeTilEksportering)
                    {
                        writer.WriteLine($"{bolig.Adresse} : {bolig.Bynavn} : {bolig.Fornavn} : {bolig.Efternavn} :  {bolig.Email} : {bolig.Tlfnummer}");
                    }


                }

            }

        }
       public void EksporterBoligerTilSalgText(string sorteringsstring)
        {
            DataRepository testDR = new DataRepository();
            var listeTilEksportering = testDR.EksporterBoligerIkkeSolgt(sorteringsstring);
            String downloads = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
            string path = Path.Combine(downloads, "BoligerTilSalg.txt");

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine("Pris : Adresse : Postnummer : ByNavn : BoligType : BoligAreal : Værelser : ByggeDato : GrundStørrelse : EnergiMærke");   
                foreach (var bolig in listeTilEksportering)
                {
                    writer.WriteLine($"{bolig.Pris} : {bolig.Adresse} : {bolig.PostNummer} : {bolig.ByNavn} : {bolig.Type} : {bolig.BoligAreal} : {bolig.Værelser} : {bolig.ByggeDato} : {bolig.GrundStørrelse} : {bolig.EnergiMærke}");
                }

            }
        }



    }



}


