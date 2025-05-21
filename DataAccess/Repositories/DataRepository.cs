using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
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
        public DataRepository()
        {
            ///special case for Ruben
            //connectionString = "Server = DESKTOP-LKSSI4H\\SQLEXPRESS; Database = Semester projekt gruppe 1;Trusted_Connection = True; TrustServerCertificate = True;";

            /// normal connection string
            connectionString = "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; Trusted_Connection = True; TrustServerCertificate = True;";

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

        public Bolig GetSingleBolig(int boligID)
        {
            SqlCommand sqlCommand = connection.CreateCommand();
            var sql = """
                SELECT Bolig.BoligID, Bolig.Pris, Bolig.Adresse, 
                Bolig.Postnummer, Bolig.ByNavn, Bolig.BoligType, 
                Bolig.BoligAreal, Bolig.Værelser, Bolig.ByggeDato, 
                Bolig.GrundStørrelse, Bolig.EnergiMærke,
                (dbo.Ejendomsmægler.Fornavn + ' ' + dbo.Ejendomsmægler.EfterNavn) AS Ejendomsmægler, 
                (dbo.Sælger.Fornavn + ' ' + dbo.Sælger.EfterNavn) AS Sælger, Status
                FROM Bolig
                INNER JOIN Ejendomsmægler ON Bolig.EjendomsmæglerID = Ejendomsmægler.EjendomsmæglerID
                INNER JOIN Sælger ON Bolig.SælgerID = Sælger.SælgerID
                WHERE BoligID = @BoligID
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
                            reader.GetString(reader.GetOrdinal("Ejendomsmægler")), //Ejendomsmægler
                            reader.GetString(reader.GetOrdinal("Sælger")), //["@SælgerID"]
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
                BoligType,
                Noter,
                ØnsketGrundStørrelse,
                ØnsketBoligStørrelse,
                ØnsketVærelser
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
                @BoligType,
                @Noter,
                @ØnsketGrundStørrelse,
                @ØnsketBoligStørrelse,
                @ØnsketVærelser
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
            command.Parameters.AddWithValue("@ØnsketVærelser", køber.Værelser);

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



        public void TilføjSalg(Salg salg)
        {
            //Oprettelse af salg i Database
            string query = "INSERT INTO Salg (KøberID, BoligID, SælgerID, Dato, Beløb) VALUES (@KøberID, @BoligID, @SælgerID,@Dato, @Beløb)";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KøberID", salg.KøberID);
            command.Parameters.AddWithValue("@BoligID", salg.BoligID);
            command.Parameters.AddWithValue("@SælgerID", salg.SælgerID);
            command.Parameters.AddWithValue("@Dato", salg.Dato);
            command.Parameters.AddWithValue("@Beløb", salg.Beløb);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public int HentKøberIDDB(string køberCPR)
        {
            int køberID = -1;
            string query = "SELECT KøberID FROM Køber WHERE CprNr = @KøberCPR";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@KøberCPR", køberCPR);


            connection.Open();
            object placeholdKøberID = command.ExecuteScalar();

            try
            {
                køberID = Convert.ToInt32(placeholdKøberID);
            }
            catch
            {
                connection.Close();
                throw new Exception("Intet matchende CPR-NR for køber fundet");
            }

            connection.Close();
            return køberID;
        }
        public int HentSælgerIDDB(string CprNummer)
        {
            int sælgerID = -1;
            string query = "SELECT SælgerID FROM Sælger WHERE CprNummer = @CprNummer";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@CprNummer", CprNummer);


            connection.Open();
            object placeholdSælgerID = command.ExecuteScalar();

            try
            {
                sælgerID = Convert.ToInt32(placeholdSælgerID);
            }
            catch
            {
                connection.Close();
                throw new Exception("Intet matchende CPR-NR for sælger fundet.");
            }

            connection.Close();
            return sælgerID;
        }
        public int HentBoligIDDB(string adresse)
        {
            int boligID = -1;
            string query = "SELECT BoligID FROM Bolig WHERE Adresse = @Adresse";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Adresse", adresse);


            connection.Open();
            object placeholdBoligID = command.ExecuteScalar();

            try
            {
                boligID = Convert.ToInt32(placeholdBoligID);
            }
            catch
            {
                connection.Close();
                throw new Exception("Ingen adresse fundet");
            }

            connection.Close();
            return boligID;
        }



        public List<string> HentSælgersBoliger(int sælgerID)
        {

            List<string> søgeResultater = new List<string>();


            string query = "SELECT Adresse FROM Bolig WHERE SælgerID = @SælgerId";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@SælgerID", sælgerID);


            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                søgeResultater.Add(reader["Adresse"].ToString());
            }

            connection.Close();
            return søgeResultater;


        }

        public void MarkerBoligSolgt(int boligID)
        { //Opdatering af status på bolig i boligdatabase
            string query = "UPDATE Bolig SET Status = 'Solgt' WHERE BoligID = @BoligID";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.AddWithValue("@BoligID", boligID);
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
                SELECT Bolig.BoligID, Bolig.Pris, Bolig.Adresse, 
                Bolig.Postnummer, Bolig.ByNavn, Bolig.BoligType, 
                Bolig.BoligAreal, Bolig.Værelser, Bolig.ByggeDato, 
                Bolig.GrundStørrelse, Bolig.EnergiMærke, 
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
                sql += " AND Bolig.Pris >= @minPris";
                command.Parameters.AddWithValue("@minPris", boligFilter.PrisMin);
            }
            if (boligFilter.PrisMax > 0)
            {
                sql += " AND Bolig.Pris <= @maxPris";
                command.Parameters.AddWithValue("@maxPris", boligFilter.PrisMax);
            }

            // BoligAreal
            if (boligFilter.BoligArealMin > 0)
            {
                sql += " AND Bolig.BoligAreal >= @minBoligAreal";
                command.Parameters.AddWithValue("@minBoligAreal", boligFilter.BoligArealMin);
            }
            if (boligFilter.BoligArealMax > 0)
            {
                sql += " AND Bolig.BoligAreal <= @maxBoligAreal";
                command.Parameters.AddWithValue("@maxBoligAreal", boligFilter.BoligArealMax);
            }

            // GrundStørrelse
            if (boligFilter.GrundStørrelseMin > 0)
            {
                sql += " AND Bolig.GrundStørrelse >= @minGrundAreal";
                command.Parameters.AddWithValue("@minGrundAreal", boligFilter.GrundStørrelseMin);
            }
            if (boligFilter.GrundStørrelseMax > 0)
            {
                sql += " AND Bolig.GrundStørrelse <= @maxGrundAreal";
                command.Parameters.AddWithValue("@maxGrundAreal", boligFilter.GrundStørrelseMax);
            }

            // Værelser
            if (boligFilter.VærelserMin > 0)
            {
                sql += " AND Bolig.Værelser >= @værelserMin";
                command.Parameters.AddWithValue("@værelserMin", boligFilter.VærelserMin);
            }
            if (boligFilter.VærelserMax > 0)
            {
                sql += " AND Bolig.Værelser <= @værelserMax";
                command.Parameters.AddWithValue("@værelserMax", boligFilter.VærelserMax);
            }

            // Adresse
            if (!string.IsNullOrWhiteSpace(boligFilter.Adresse))
            {
                sql += " AND Bolig.Adresse LIKE @adresse";
                command.Parameters.AddWithValue("@adresse", $"%{boligFilter.Adresse}%");
            }

            // Postnummer
            if (boligFilter.Postnummer > 0)
            {
                sql += " AND Bolig.Postnummer = @postnr";
                command.Parameters.AddWithValue("@postnr", boligFilter.Postnummer);
            }

            // ByNavn
            if (!string.IsNullOrWhiteSpace(boligFilter.ByNavn))
            {
                sql += " AND Bolig.ByNavn LIKE @bynavn";
                command.Parameters.AddWithValue("@bynavn", $"%{boligFilter.ByNavn}%");
            }

            // Type
            if (!string.IsNullOrWhiteSpace(boligFilter.Type))
            {
                sql += " AND Bolig.BoligType = @type";
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
                sql += " AND Bolig.EnergiMærke = @energimærke";
                command.Parameters.AddWithValue("@energimærke", boligFilter.EnergiMærke);
            }

            // Status
            if (!string.IsNullOrWhiteSpace(boligFilter.Status))
            {
                sql += " AND Bolig.Status = @status";
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

        public int CountRows(string tabelname, string condition = "")
        {
            string query = $"Select Count(*) From [{tabelname}]";
            if (condition != "")
                query += " " + condition;
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                connection.Close();
                return count;
            }
        }
        public string GetString(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                object str = cmd.ExecuteScalar();
                connection.Close();
                return str?.ToString() ?? "N/A";
            }
        }
        public Int64 SendQuery(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                object num = cmd.ExecuteScalar();
                connection.Close();
                return num != DBNull.Value ? Convert.ToInt64(num) : 0L;
            }
        }
        public DataTable GetTable(string query)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(dataTable);
            }
            return dataTable;
        }
        public Dictionary<string, List<object>> GetForsideData()
        {
            List<object> piedata = new List<object>()
            {
                CountRows("Køber","where BoligType = 'Villa'"),
                CountRows("Køber","WHERE BoligType = 'Lejlighed'"),
                CountRows("Køber","WHERE BoligType = 'Rækkehus'"),
                CountRows("Køber","WHERE BoligType = 'Andelsbolig'"),
                CountRows("Køber","WHERE BoligType = 'Ejerlejlighed'"),
                CountRows("Køber","WHERE BoligType = 'Sommerhus'"),
                CountRows("Køber","WHERE BoligType = 'Ungdomsbolig'"),
                CountRows("Køber","WHERE BoligType = 'Ældrebolig'"),
                CountRows("Køber","WHERE BoligType = 'Kolonihavehus'")
            };
            List<object> bardata = new List<object>()
            {
                CountRows("Bolig","where BoligType = 'Villa'"),
                CountRows("Bolig","WHERE BoligType = 'Lejlighed'"),
                CountRows("Bolig","WHERE BoligType = 'Rækkehus'"),
                CountRows("Bolig","WHERE BoligType = 'Andelsbolig'"),
                CountRows("Bolig","WHERE BoligType = 'Ejerlejlighed'"),
                CountRows("Bolig","WHERE BoligType = 'Sommerhus'"),
                CountRows("Bolig","WHERE BoligType = 'Ungdomsbolig'"),
                CountRows("Bolig","WHERE BoligType = 'Ældrebolig'"),
                CountRows("Bolig","WHERE BoligType = 'Kolonihavehus'")
            };
            List<object> labeldata = new List<object>()
            {
                CountRows("Bolig"),
                CountRows("Bolig","WHERE Status = 'Til Salg'"),
                CountRows("Køber"),
                GetString("select TOP 1 BoligType from Køber group by BoligType order by count(*) desc;"),
                CountRows("Sælger"),
                GetString("select TOP 1 BoligType from Bolig where Status = 'Til Salg' group by BoligType order by count(*) desc"),
                CountRows("Salg"),
                SendQuery("select sum(cast(Beløb as bigint)) from Salg")
            };
            List<object> tabeldata = new List<object>()
            {
                {GetTable("select top 20 ByNavn, BoligType, Værelser, ByggeDato, Pris from Bolig where Status = 'Til Salg' order by BoligID desc")},
                {GetTable("select top 20 (Fornavn+' '+EfterNavn) as Navn, SøgeOmråde, BoligType, PrisKlasse from Køber order by KøberID desc")}
            };
            Dictionary<string, List<object>> data = new(){
                {"pie",piedata},
                {"bar",bardata},
                {"label",labeldata},
                {"tabel",tabeldata}
            };
            return data;
        }
        public static void EjendomsmæglerLogin(SqlConnection connection, string username, string password)
        {

            SqlCommand command = connection.CreateCommand();
            var sql = """
            SELECT Ejendomsmægler.EjendomsmæglerID, 
            Ejendomsmægler.Fornavn, Ejendomsmægler.EfterNavn, 
            Ejendomsmægler.Email, Ejendomsmægler.TlfNummer, 
            Ejendomsmægler.Brugernavn, Ejendomsmægler.Adgangsniveau
            FROM dbo.Ejendomsmægler
            WHERE Ejendomsmægler.Brugernavn = @brugernavn
            AND Ejendomsmægler.Password = @password
            """;
            command.CommandText = sql;
            command.Parameters.AddWithValue("@brugernavn", username);
            command.Parameters.AddWithValue("@password", password);



            connection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                SessionManager.EjendomsmæglerId = reader.GetInt32(reader.GetOrdinal("EjendomsmæglerID"));
                SessionManager.Brugernavn = reader.GetString(reader.GetOrdinal("Brugernavn"));
                SessionManager.AdgangsNiveau = reader.GetInt32(reader.GetOrdinal("Adgangsniveau"));
                SessionManager.Fornavn = reader.GetString(reader.GetOrdinal("Fornavn"));
                SessionManager.Efternavn = reader.GetString(reader.GetOrdinal("Efternavn"));
                SessionManager.FuldeNavn = SessionManager.Fornavn + " " + SessionManager.Efternavn;
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    string columnName = reader.GetName(i);
                    object value = reader.GetValue(i);
                    Debug.WriteLine($"{columnName}: {value}");
                }
            }

            connection.Close();
        }
        public int GetGroundPrice(string boligtype, int grundStørrelse, int boligAreal, int byggeDato)
        {
            //string query = "Select Top(100) sum(S.Beløb/B.GrundStørrelse)/count(*) " +
            //    "from Bolig B left join Salg S on B.BoligID = S.BoligID where B.GrundStørrelse between" +
            //    $" {grundStørrelse} - 200 and {grundStørrelse} + 200 " +
            //    $"and B.BoligType = '{boligtype}'" +
            //    $" AND YEAR(B.ByggeDato) between {byggeDato} - 20 and {byggeDato} + 20" +
            //    $" and B.BoligAreal between {boligAreal} - 60 and {boligAreal} + 60";
            string query = @"select sum(S.Beløb/B.GrundStørrelse)/count(*)
                           from Bolig B
                           left join Salg S ON B.BoligID = S.BoligID
                           where B.GrundStørrelse between @grundStørrelseMin AND @grundStørrelseMax
                           and B.BoligType = @boligType
                           and YEAR(B.ByggeDato) between @byggeDatoMin and @byggeDatoMax
                           and B.BoligAreal between @boligArealMin and @boligArealMax;";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@grundStørrelseMin", grundStørrelse - 200);
                cmd.Parameters.AddWithValue("@grundStørrelseMax", grundStørrelse + 200);
                cmd.Parameters.AddWithValue("@boligType", boligtype);
                cmd.Parameters.AddWithValue("@byggeDatoMin", byggeDato - 10);
                cmd.Parameters.AddWithValue("@byggeDatoMax", byggeDato + 10);
                cmd.Parameters.AddWithValue("@boligArealMin", boligAreal - 60);
                cmd.Parameters.AddWithValue("@boligArealMax", boligAreal + 60);
                connection.Open();
                object result = cmd.ExecuteScalar();
                connection.Close();

                if (result == DBNull.Value || result == null)
                {
                    query = @"select sum(S.Beløb/B.GrundStørrelse)/count(*)
                           from Bolig B
                           left join Salg S ON B.BoligID = S.BoligID
                           and B.BoligType = @boligType1
                           where B.GrundStørrelse between @grundStørrelseMin1 AND @grundStørrelseMax1;";
                    cmd.Parameters.AddWithValue("@boligType1", boligtype);
                    cmd.Parameters.AddWithValue("@grundStørrelseMin1", grundStørrelse - 300);
                    cmd.Parameters.AddWithValue("@grundStørrelseMax1", grundStørrelse + 300);
                    connection.Open();
                    result = cmd.ExecuteScalar();
                    connection.Close();
                    if(result == DBNull.Value || result == null)
                    {
                        return 0;
                    }
                }
                return Convert.ToInt32(result);
            }
        }
    }
}
//// ByNavn
//if (!string.IsNullOrWhiteSpace(boligFilter.ByNavn))
//{
//    sql += " AND ByNavn LIKE @bynavn";
//    command.Parameters.AddWithValue("@bynavn", $"%{boligFilter.ByNavn}%");
//}

//// Type
//if (!string.IsNullOrWhiteSpace(boligFilter.Type))
//{
//    sql += " AND BoligType = @type";
//    command.Parameters.AddWithValue("@type", boligFilter.Type);
//}

