using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
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

        public int CountRows(string tabelname, string condition="")
        {
            string query = $"Select Count(*) From [{tabelname}]";
            if (condition != "")
                query += " "+condition;
            using(SqlCommand cmd = new SqlCommand(query, connection))
            {
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                connection.Close();
                return count;
            }
        }
        public string GetString(string query)
        {
            using (SqlCommand cmd = new SqlCommand(query,connection))
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
        public Dictionary<string,List<object>> GetForsideData()
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
                {GetTable("select top 20 * from Bolig order by BoligID desc")},
                {GetTable("select top 20 * from Køber order by KøberID desc")}
            };
            Dictionary<string, List<object>> data = new(){
                {"pie",piedata},
                {"bar",bardata},
                {"label",labeldata},
                {"tabel",tabeldata}
            };
            return data;
        }
    }
}
