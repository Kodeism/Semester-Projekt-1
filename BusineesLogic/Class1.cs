using DataAccess.Repositories;
using Models;

namespace BusineesLogic
{
    public class SælgerFunktioner
    {
        public void TilføjSælger(string navn, string efternavn, int tlfNummer, string email, string cprNr, string adresse)
        {
            Sælger sælger = new Sælger(navn, efternavn, tlfNummer, email, cprNr, adresse);

            DataRepository testDR = new DataRepository();
            testDR.TilføjSælger(sælger);
        }


    }
    public class KøberFunktioner
    {
        public void TilføjKøber(string navn, string efternavn, string adresse, int tlfNummer, string cprNr, string email, string søgeområde, int prisklasse, string boligtype, int? boligStørrelse, int? grundStørrelse, int? værelser, string køberinfo)
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

}
