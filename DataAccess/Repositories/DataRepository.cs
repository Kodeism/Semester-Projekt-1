using DataAccess.Repositories.Contracts;
using Microsoft.Data.SqlClient;
using Models;
using System.Diagnostics;

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

        public Bolig getSingleBolig(int boligID)
        {
            SqlCommand sqlCommand = connection.CreateCommand();
            var sql = """
                SELECT *
                FROM Bolig
                WHERE BoligID = @BoligID;
                """;

            sqlCommand.CommandText = sql;
            sqlCommand.Parameters.AddWithValue("@BoligID", boligID);

            connection.Open();
            Bolig bolig;
            using (var reader = sqlCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    try
                    {

                        // NOTE: Order of columns in DB and object constructor does not match perfectly.
                        //
                        // DO NOT REARRANGE
                        bolig = new Bolig(
                            reader.GetInt32(reader.GetOrdinal("BoligID")), //ID
                            reader.GetInt32(reader.GetOrdinal("Pris")), //Pris
                            reader.GetString(reader.GetOrdinal("Adresse")), //Adresse
                            reader.GetInt32(reader.GetOrdinal("Postnummer")), //["@Postnummer"]
                            reader.GetString(reader.GetOrdinal("ByNavn")), //["@ByNavn"]
                            reader.GetString(reader.GetOrdinal("BoligType")), //["@BoligType"]
                            reader.GetInt32(reader.GetOrdinal("BoligAreal")), //["@BoligAreal"]
                            reader.GetInt32(reader.GetOrdinal("Værelser")), //["@Værelser"]
                            reader.GetDateTime(reader.GetOrdinal("ByggeDato")), //["@ByggeDato"]
                            reader.GetInt32(reader.GetOrdinal("GrundStørrelse")), //["@GrundStørrelse"]
                            reader.GetInt32(reader.GetOrdinal("EjendomsmæglerID")), //["@EjendomsmæglerID"]
                            reader.GetInt32(reader.GetOrdinal("SælgerID")), //["@SælgerID"]
                            reader.GetString(reader.GetOrdinal("EnergiMærke")), //["@EnergiMærke"]
                            reader.GetString(reader.GetOrdinal("Status")) //["@Status"]
                        );

                        connection.Close();
                        return bolig;
                    }
                    catch (Exception)
                    {
                        Debug.WriteLine("Big fail in making bolig");
                        connection.Close();
                        throw;
                    }

                }
                else
                {
                    connection.Close();
                    throw new Exception("Sql reader unable to read");
                }
            }
        }

        public Ejendomsmægler CreateEjendomsmægler(Ejendomsmægler ejendomsmægler)
        {
            throw new NotImplementedException();
        }
        public Køber CreateKøber(Køber køber)
        {
            SqlCommand command = connection.CreateCommand();
            string sql = """
                
                INSERT INTO Køber (
                ForNavn,
                EfterNavn,
                TlfNummer,
                CprNr,
                Email,
                Adresse,
                PrisKlasse,
                SøgeOmråde,
                BoligType
                )
                VALUES (
                @ForNavn,
                @EfterNavn,
                @TlfNummer,
                @CprNr,
                @Email,
                @Adresse,
                @PrisKlasse,
                @Søgeområde,
                @BoligType
                );
                
                """;


            command.CommandText = sql;
            command.Parameters.AddWithValue("@ForNavn", køber.Navn);
            command.Parameters.AddWithValue("@EfterNavn", køber.Efternavn);
            command.Parameters.AddWithValue("@TlfNummer", køber.TlfNummer);
            command.Parameters.AddWithValue("@CprNr", køber.CprNr);
            command.Parameters.AddWithValue("@Email", køber.Email);
            command.Parameters.AddWithValue("@Adresse", køber.Adresse);
            command.Parameters.AddWithValue("@PrisKlasse", køber.PrisKlasse);
            command.Parameters.AddWithValue("@SøgeOmråde", køber.SøgeOmråde);
            command.Parameters.AddWithValue("@BoligType", køber.BoligType);
            command.Parameters.AddWithValue("@Noter", køber.KøberInfo);
            command.Parameters.AddWithValue("@ØnsketGrundStørrelse", køber.GrundStørrelse);
            command.Parameters.AddWithValue("@ØnsketBoligStørrelse", køber.Boligstørrelse);

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

        public void TilføjSælger(Sælger sælger)
        {

            string query = "INSERT INTO Sælger (Fornavn, Efternavn, Email, TlfNummer, Adresse, CprNummer) VALUES (@Navn, @Efternavn, @Email, @TlfNummer, @Adresse, @CprNummer)";

            
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Navn", sælger.Navn);
            command.Parameters.AddWithValue("@Efternavn", sælger.Efternavn);
            command.Parameters.AddWithValue("@Email", sælger.Email);
            command.Parameters.AddWithValue("@TlfNummer", sælger.TlfNummer);
            command.Parameters.AddWithValue("@Adresse", sælger.Adresse);
            command.Parameters.AddWithValue("@CprNummer", sælger.CprNr);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
