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
        public void ErklærSolgt(string køberCPR, string adresse, DateOnly dato, int beløb,string sælgerCPR)
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

}

