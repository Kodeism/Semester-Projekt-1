using DataAccess.Repositories.Contracts;
using Microsoft.Data.SqlClient;
using Models;

namespace DataAccess.Repositories
{
    public class DataRepository : IDataRepository
    {
        private readonly string connectionString;
        private readonly SqlConnection connection;
        public DataRepository(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }
        public Bolig CreateBolig(Bolig bolig)
        {
            throw new NotImplementedException();
        }

        public Ejendomsmægler CreateEjendomsmægler(Ejendomsmægler ejendomsmægler)
        {
            throw new NotImplementedException();
        }
        public Køber CreateKøber()
        {
            Køber køber = new Køber("Johannes Cæsar", "Melton", 21956839, "johannescj@gmail.com", 3250000, "Odense", "Villa");
            SqlCommand command = connection.CreateCommand();
            string sql = "INSERT INTO Køber (ForNavn, EfterNavn, TlfNummer, Email, PrisKlasse, SøgeOmråde, BoligType)" +
                " VALUES (@ForNavn, @EfterNavn, @TlfNummer, @Email, @PrisKlasse, @Søgeområde, @BoligType)";

            command.CommandText = sql;
            command.Parameters.AddWithValue("@ForNavn", køber.Navn);
            command.Parameters.AddWithValue("@EfterNavn", køber.Efternavn);
            command.Parameters.AddWithValue("@TlfNummer", køber.TlfNummer);
            command.Parameters.AddWithValue("@Email", køber.Email);
            command.Parameters.AddWithValue("@PrisKlasse", køber.PrisKlasse);
            command.Parameters.AddWithValue("@SøgeOmråde", køber.SøgeOmråde);
            command.Parameters.AddWithValue("@BoligType", køber.BoligType);
            //command.Parameters.AddWithValue("@Noter", køber.KøberInfo);
            //command.Parameters.AddWithValue("@ØnsketGrundStørrelse", køber.GrundStørrelse);
            //command.Parameters.AddWithValue("@ØnsketBoligStørrelse", køber.Boligstørrelse);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            return køber;
        }
    }
}
