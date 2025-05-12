using Models;
using DataAccess;
namespace BusineesLogic
{
    public class SælgerFunktioner
    {
        public void TilføjSælger(string navn, string efternavn, int tlfNummer, string email)
        {
            Sælger tempSælger = new Sælger (navn, efternavn,tlfNummer, email);

            SælgerDatabase db = new SælgerDatabase();
            db.TilføjSælgerDB(tempSælger);
        }


    }



}
