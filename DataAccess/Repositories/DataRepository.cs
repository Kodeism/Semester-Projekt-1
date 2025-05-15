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
            var sql = """
                    SELECT *
                    FROM Bolig
                    WHERE 1=1
                """;
            // insert into sql for each filled data in list, if value is empty then dont add
            // Pris
            //if (boligFilter.PrisMin != null)
            //{
            //    sql += " AND Pris >= @minPris";
            //    command.Parameters.AddWithValue("@minPris", boligFilter.PrisMin);
            //}
            //if (boligFilter.PrisMax != null)
            //{
            //    sql += " AND Pris <= @maxPris";
            //    command.Parameters.AddWithValue("@maxPris", boligFilter.PrisMax);
            //}
            if (int.TryParse(boligFilter.PrisMin, out int prisMin))
            {
                sql += " AND Pris >= @minPris";
                command.Parameters.AddWithValue("@minPris", prisMin);
            }

            if (int.TryParse(boligFilter.PrisMax, out int prisMax))
            {
                sql += " AND Pris <= @maxPris";
                command.Parameters.AddWithValue("@maxPris", prisMax);
            }

            //// BoligAreal
            //if (boligFilter.BoligArealMin != null)
            //{
            //    sql += " AND BoligAreal >= @minBoligAreal";
            //    command.Parameters.AddWithValue("@minBoligAreal", boligFilter.BoligArealMin);
            //}
            //if (boligFilter.BoligArealMax != null)
            //{
            //    sql += " AND BoligAreal <= @maxBoligAreal";
            //    command.Parameters.AddWithValue("@maxBoligAreal", boligFilter.BoligArealMax);
            //}

            //// GrundStørrelse
            //if (boligFilter.GrundStørrelseMin != null)
            //{
            //    sql += " AND GrundStørrelse >= @minGrundAreal";
            //    command.Parameters.AddWithValue("@minGrundAreal", boligFilter.GrundStørrelseMin);
            //}
            //if (boligFilter.GrundStørrelseMax != null)
            //{
            //    sql += " AND GrundStørrelse <= @maxGrundAreal";
            //    command.Parameters.AddWithValue("@maxGrundAreal", boligFilter.GrundStørrelseMax);
            //}

            //// Adresse
            //if (!string.IsNullOrWhiteSpace(boligFilter.Adresse))
            //{
            //    sql += " AND Adresse LIKE @adresse";
            //    command.Parameters.AddWithValue("@adresse", $"%{boligFilter.Adresse}%");
            //}

            //// Postnummer
            //if (boligFilter.Postnummer != null)
            //{
            //    sql += " AND Postnummer = @postnr";
            //    command.Parameters.AddWithValue("@postnr", boligFilter.Postnummer);
            //}

            //// ByNavn
            //if (!string.IsNullOrWhiteSpace(boligFilter.ByNavn))
            //{
            //    sql += " AND ByNavn LIKE @bynavn";
            //    command.Parameters.AddWithValue("@bynavn", $"%{boligFilter.ByNavn}%");
            //}

            //// Type
            //if (!string.IsNullOrWhiteSpace(boligFilter.Type))
            //{
            //    sql += " AND Type = @type";
            //    command.Parameters.AddWithValue("@type", boligFilter.Type);
            //}

            //// ByggeDato
            ////if (boligFilter.ByggeDato != null)
            ////{
            ////    sql += " AND ByggeDato = @byggeDato";
            ////    command.Parameters.AddWithValue("@byggeDato", boligFilter.ByggeDato);
            ////}

            //// EjendomsmæglerID
            //if (boligFilter.EjendomsmæglerID != null)
            //{
            //    sql += " AND EjendomsmæglerID = @realtorID";
            //    command.Parameters.AddWithValue("@realtorID", boligFilter.EjendomsmæglerID);
            //}

            //// SælgerID
            //if (boligFilter.SælgerID != null)
            //{
            //    sql += " AND SælgerID = @sælgerID";
            //    command.Parameters.AddWithValue("@sælgerID", boligFilter.SælgerID);
            //}

            //// EnergiMærke
            //if (!string.IsNullOrWhiteSpace(boligFilter.EnergiMærke))
            //{
            //    sql += " AND EnergiMærke = @energimærke";
            //    command.Parameters.AddWithValue("@energimærke", boligFilter.EnergiMærke);
            //}

            //// Værelser
            //if (boligFilter.VærelserMin != null)
            //{
            //    sql += " AND Værelser >= @værelserMin";
            //    command.Parameters.AddWithValue("@værelserMin", boligFilter.VærelserMin);
            //}
            //if (boligFilter.VærelserMax != null)
            //{
            //    sql += " AND Værelser <= @værelserMax";
            //    command.Parameters.AddWithValue("@værelserMax", boligFilter.VærelserMax);
            //}


            command.CommandText = sql;

            connection.Open();
            var reader = command.ExecuteReader();


            while (reader.Read())
            {
                var bolig = new Bolig
                {
                    Pris = reader.GetInt32(reader.GetOrdinal("Pris")),
                    Adresse = reader.GetString(reader.GetOrdinal("Adresse")),
                    PostNummer = reader.GetInt32(reader.GetOrdinal("PostNummer")),
                    ByNavn = reader.GetString(reader.GetOrdinal("ByNavn")),
                    Type = reader.GetString(reader.GetOrdinal("BoligType")),
                    BoligAreal = reader.GetInt32(reader.GetOrdinal("BoligAreal")),
                    Værelser = reader.GetInt32(reader.GetOrdinal("Værelser")),
                    //ByggeDato = reader.GetDateTime(reader.GetOrdinal("ByggeDato")),
                    GrundStørrelse = reader.GetInt32(reader.GetOrdinal("GrundStørrelse")),
                    EnergiMærke = reader.IsDBNull(reader.GetOrdinal("EnergiMærke"))
                    ? null
                    : reader.GetString(reader.GetOrdinal("EnergiMærke")),
                    EjendomsmæglerID = reader.GetInt32(reader.GetOrdinal("EjendomsmæglerID")),
                    SælgerID = reader.GetInt32(reader.GetOrdinal("SælgerID"))
                };

                boligList.Add(bolig);

                // Læs alle kolonner dynamisk
                var rowData = "";
                for (int i = 0; i < reader.FieldCount; i++)
                {

                    rowData += $"{reader.GetName(i)}: {reader.GetValue(i)} | ";
                }

                Debug.WriteLine(rowData);

            }
            foreach (var item in boligList)
            {
                Debug.WriteLine(item.Pris);
            }

            connection.Close();

            return boligList;
        }
    }
}
