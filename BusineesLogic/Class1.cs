using DataAccess.Repositories;
using Models;

namespace BusineesLogic
{
    public class SælgerFunktioner
    {
        public void TilføjSælger(string navn, string efternavn, int tlfNummer, string email, string cprNr, string adresse)
        {
            Sælger sælger = new Sælger(navn, efternavn, tlfNummer, email, cprNr, adresse);

            DataRepository testDR = new DataRepository("Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; TrustServerCertificate = True;");
            testDR.TilføjSælger(sælger);
        }


    }
    public class KøberFunktioner
    {
        public void TilføjKøber(string navn, string efternavn, string adresse, int tlfNummer, string cprNr, string email, string søgeområde, int prisklasse, string boligtype)
        {
            Køber køber = new Køber(navn, efternavn, tlfNummer, email, cprNr, adresse, prisklasse, boligtype, søgeområde);

            DataRepository testDR = new DataRepository("Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; TrustServerCertificate = True;");
            testDR.CreateKøber(køber);
        }
    }
}
