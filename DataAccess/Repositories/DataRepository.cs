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
            SqlCommand command = connection.CreateCommand();
            var sql = """
                    INSERT INTO Bolig (
                	    Pris,
                        Adresse,
                        Postnummer,
                        ByNavn,
                        BoligType,
                        BoligAreal,
                        Værelser,
                        ByggeDato,
                        GrundStørrelse,
                        EnergiMærke,
                        EjendomsmæglerID,
                        SælgerID,
                        Status
                    )
                    VALUES (
                	    @Pris,
                        @Adresse,
                        @Postnummer,
                        @ByNavn,
                        @BoligType,
                        @BoligAreal,
                        @Værelser,
                        @ByggeDato,
                        @GrundStørrelse,
                        @EnergiMærke,
                        @EjendomsmæglerID,
                        @SælgerID,
                        @Status
                    );
                """;

            command.CommandText = sql;
            command.Parameters.AddWithValue("@Pris", bolig.Pris);
            command.Parameters.AddWithValue("@Adresse", bolig.Adresse);
            command.Parameters.AddWithValue("@Postnummer", bolig.PostNummer);
            command.Parameters.AddWithValue("@ByNavn", bolig.ByNavn);
            command.Parameters.AddWithValue("@BoligType", bolig.Type);
            command.Parameters.AddWithValue("@BoligAreal", bolig.BoligAreal);
            command.Parameters.AddWithValue("@Værelser", bolig.Værelser);
            command.Parameters.AddWithValue("@ByggeDato", bolig.ByggeDato);
            command.Parameters.AddWithValue("@GrundStørrelse", bolig.GrundStørrelse);
            command.Parameters.AddWithValue("@EnergiMærke", bolig.EnergiMærke);
            command.Parameters.AddWithValue("@EjendomsmæglerID", bolig.EjendomsmæglerID);
            command.Parameters.AddWithValue("@SælgerID", bolig.SælgerID);
            command.Parameters.AddWithValue("@Status", bolig.Status);


            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            
            return bolig;
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

        public void UpdatePris(int boligId, int nyPris)
        {
            SqlCommand command = connection.CreateCommand();
            var sql = """
                    UPDATE Bolig
                    SET Pris = @Pris
                    WHERE BoligID = @BoligID;
                """;

            command.CommandText = sql;
            command.Parameters.AddWithValue("@Pris", nyPris);
            command.Parameters.AddWithValue("@BoligID", boligId);

            connection.Open(); 
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
