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
        public static List<Bolig> SøgMedFilter(SqlConnection connection, BoligFilter boligFilter)
        {
            List<Bolig> boligList = new List<Bolig>();

            SqlCommand command = connection.CreateCommand();
            // tager ejendomsmægler og sælgers navn i stedet for ID eftersom id nok ikke er det vigtigste for ejendomsmægler at vide
            // WHERE 1=1 var bare måden jeg kunne sikrer mig at queryen virkede selv hvis ingen andre ting var tilføjet
            var sql = """
                SELECT BoligID, Pris, Adresse, 
                Postnummer, ByNavn, BoligType, 
                BoligAreal, Værelser, ByggeDato, 
                GrundStørrelse, EnergiMærke, 
                (dbo.Ejendomsmægler.Fornavn + ' ' + dbo.Ejendomsmægler.EfterNavn) AS Ejendomsmægler, 
                (dbo.Sælger.Fornavn + ' ' + dbo.Sælger.EfterNavn) AS Sælger, Status
                FROM dbo.Bolig
                INNER JOIN Ejendomsmægler ON Bolig.EjendomsmæglerID = Ejendomsmægler.EjendomsmæglerID
                INNER JOIN Sælger ON Bolig.SælgerID = Sælger.SælgerID
                WHERE 1=1
                """;


            // Pris
            if (boligFilter.PrisMin > 0)
            {
                sql += " AND Pris >= @minPris";
                command.Parameters.AddWithValue("@minPris", boligFilter.PrisMin);
            }
            if (boligFilter.PrisMax > 0)
            {
                sql += " AND Pris <= @maxPris";
                command.Parameters.AddWithValue("@maxPris", boligFilter.PrisMax);
            }

            // BoligAreal
            if (boligFilter.BoligArealMin > 0)
            {
                sql += " AND BoligAreal >= @minBoligAreal";
                command.Parameters.AddWithValue("@minBoligAreal", boligFilter.BoligArealMin);
            }
            if (boligFilter.BoligArealMax > 0)
            {
                sql += " AND BoligAreal <= @maxBoligAreal";
                command.Parameters.AddWithValue("@maxBoligAreal", boligFilter.BoligArealMax);
            }

            // GrundStørrelse
            if (boligFilter.GrundStørrelseMin > 0)
            {
                sql += " AND GrundStørrelse >= @minGrundAreal";
                command.Parameters.AddWithValue("@minGrundAreal", boligFilter.GrundStørrelseMin);
            }
            if (boligFilter.GrundStørrelseMax > 0)
            {
                sql += " AND GrundStørrelse <= @maxGrundAreal";
                command.Parameters.AddWithValue("@maxGrundAreal", boligFilter.GrundStørrelseMax);
            }

            // Værelser
            if (boligFilter.VærelserMin > 0)
            {
                sql += " AND Værelser >= @værelserMin";
                command.Parameters.AddWithValue("@værelserMin", boligFilter.VærelserMin);
            }
            if (boligFilter.VærelserMax > 0)
            {
                sql += " AND Værelser <= @værelserMax";
                command.Parameters.AddWithValue("@værelserMax", boligFilter.VærelserMax);
            }

            // Adresse
            if (!string.IsNullOrWhiteSpace(boligFilter.Adresse))
            {
                sql += " AND Adresse LIKE @adresse";
                command.Parameters.AddWithValue("@adresse", $"%{boligFilter.Adresse}%");
            }

            // Postnummer
            if (boligFilter.Postnummer > 0)
            {
                sql += " AND Postnummer = @postnr";
                command.Parameters.AddWithValue("@postnr", boligFilter.Postnummer);
            }

            // ByNavn
            if (!string.IsNullOrWhiteSpace(boligFilter.ByNavn))
            {
                sql += " AND ByNavn LIKE @bynavn";
                command.Parameters.AddWithValue("@bynavn", $"%{boligFilter.ByNavn}%");
            }

            // Type
            if (!string.IsNullOrWhiteSpace(boligFilter.Type))
            {
                sql += " AND BoligType = @type";
                command.Parameters.AddWithValue("@type", boligFilter.Type);
            }

            //// ByggeDato // Mangler at blive tilføjet
            ////if (boligFilter.ByggeDato != null)
            ////{
            ////    sql += " AND ByggeDato = @byggeDato";
            ////    command.Parameters.AddWithValue("@byggeDato", boligFilter.ByggeDato);
            ////}

            // Filtrer på ejendomsmæglerens fulde navn
            if (boligFilter.EjendomsmæglerNavn != null)
            {
                sql += " AND LOWER(Ejendomsmægler.Fornavn + ' ' + Ejendomsmægler.EfterNavn) LIKE LOWER(@ejendomsmægler)";
                command.Parameters.AddWithValue("@ejendomsmægler", "%" + boligFilter.EjendomsmæglerNavn + "%");
            }

            // SælgerID
            if (boligFilter.SælgerNavn != null)
            {
                sql += " AND LOWER(Sælger.Fornavn + ' ' + Sælger.EfterNavn) LIKE LOWER(@sælger)";
                command.Parameters.AddWithValue("@sælger", "%" + boligFilter.SælgerNavn + "%");
            }

            // EnergiMærke
            if (!string.IsNullOrWhiteSpace(boligFilter.EnergiMærke))
            {
                sql += " AND EnergiMærke = @energimærke";
                command.Parameters.AddWithValue("@energimærke", boligFilter.EnergiMærke);
            }

            // Status
            if (!string.IsNullOrWhiteSpace(boligFilter.Status))
            {
                sql += " AND Status = @status";
                command.Parameters.AddWithValue("@status", boligFilter.Status);
            }

            command.CommandText = sql;

            connection.Open();
            var reader = command.ExecuteReader();


            while (reader.Read())
            {
                var bolig = new Bolig
                {
                    BoligID = reader.GetInt32(reader.GetOrdinal("BoligID")),
                    Pris = reader.GetInt32(reader.GetOrdinal("Pris")),
                    Adresse = reader.GetString(reader.GetOrdinal("Adresse")),
                    PostNummer = reader.GetInt32(reader.GetOrdinal("PostNummer")),
                    ByNavn = reader.GetString(reader.GetOrdinal("ByNavn")),
                    Type = reader.GetString(reader.GetOrdinal("BoligType")),
                    BoligAreal = reader.GetInt32(reader.GetOrdinal("BoligAreal")),
                    Værelser = reader.GetInt32(reader.GetOrdinal("Værelser")),
                    ByggeDato = reader.GetDateTime(reader.GetOrdinal("ByggeDato")),
                    GrundStørrelse = reader.GetInt32(reader.GetOrdinal("GrundStørrelse")),
                    EnergiMærke = reader.IsDBNull(reader.GetOrdinal("EnergiMærke"))
                    ? null
                    : reader.GetString(reader.GetOrdinal("EnergiMærke")),
                    EjendomsmæglerNavn = reader.GetString(reader.GetOrdinal("Ejendomsmægler")),
                    SælgerNavn = reader.GetString(reader.GetOrdinal("Sælger")),
                    Status = reader.GetString(reader.GetOrdinal("Status"))
                };

                boligList.Add(bolig);

            }

            connection.Close();

            return boligList; // Tager data fra query og giver den tilbage,
                              // Hermed kan det bruges til at udfylde en datagridview eksempelvis
                              // Dette kan ses i test siden BoligFilterTest
        }
    }
}
