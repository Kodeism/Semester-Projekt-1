using DataAccess.Repositories;
using Microsoft.VisualBasic;
using Models;
using System;
using System.Data;
using System.Text.Encodings.Web;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public string EksporterBoligSælgerText(string bynavn, string status, string orderby)
        {
            DataRepository testDR = new DataRepository();
            var listeTilEksportering = testDR.EksporterBoligSælgerListe(bynavn, status, orderby);
            if(listeTilEksportering == null || listeTilEksportering.Rows.Count == 0)
            {
                return "Ingen boliger fundet med det bynavn";
            }
            string skriveBord = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string mappesti = Path.Combine(skriveBord, "MineEksports");
            Directory.CreateDirectory(mappesti);
            string filnavn = $"Bolig"+ " " + bynavn;
            string filtype = ".json";
            string filsti = Path.Combine(mappesti, $"{filnavn}{filtype}");
            int tæller = 1;
            while (File.Exists(filsti))
            {
                filsti = Path.Combine(mappesti, $"{filnavn}({tæller}){filtype}");
                tæller++;
            }
            var rækker = new List<Dictionary<string, object>>();
            foreach (DataRow row in listeTilEksportering.Rows)
            {
                var rækkeData = new Dictionary<string, object>();
                foreach (DataColumn column in listeTilEksportering.Columns)
                {
                    rækkeData[column.ColumnName] = row[column];
                }
                rækker.Add(rækkeData);
            }
            var json = JsonSerializer.Serialize(rækker, new JsonSerializerOptions { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
            File.WriteAllText(filsti, json);
            return $"Data fil: {filnavn + tæller.ToString() + filtype} - nu gemt i Mappe: {mappesti}";
        }



    }



}


