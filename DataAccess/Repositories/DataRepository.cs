using System.Xml.Serialization;
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



        public List <string> HentSælgersBoliger(int sælgerID)
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

        public void MarkerBoligSolgt (int boligID)
        { //Opdatering af status på bolig i boligdatabase
            string query = "UPDATE Bolig SET Status = 'Solgt' WHERE BoligID = @BoligID";

            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;
            
            command.Parameters.AddWithValue("@BoligID", boligID);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }




    }

    }

        
    
    
    
    
    
    
    
    
    
    

