using System;
using System.Security.Principal;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO.Pipes;
using Microsoft.Identity.Client;
using Models;
namespace DataAccess
{
    public class AdgangDatabase
    {
        public SqlConnection connection;
        public string connectionsstring = "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; TrustServerCertificate=True;";

        public SqlConnection ÅbnDatabaseConnection()
        {//Åbner connection til database
            connection = new SqlConnection(connectionsstring);
            connection.Open();
            return connection;
        }

        public void LukDatabaseConnection()
        {

            connection.Close();
        }

    }

    public class SælgerDatabase
    {
        public void TilføjSælgerDB (Sælger tempSælger)
        {
            AdgangDatabase db1 = new AdgangDatabase();
            SqlConnection dbConnection = db1.ÅbnDatabaseConnection();
            string query = "INSERT INTO Sælger (Fornavn, Efternavn, Email, TlfNummer) VALUES (@Navn, @Efternavn, @Email, @TlfNummer)";
            
            
            SqlCommand command = new SqlCommand(query, dbConnection);
            command.Parameters.AddWithValue("@Navn", tempSælger.Navn);
            command.Parameters.AddWithValue("@Efternavn", tempSælger.Efternavn);
            command.Parameters.AddWithValue("@Email", tempSælger.Email);
            command.Parameters.AddWithValue("@TlfNummer", tempSælger.TlfNummer);
  
            command.ExecuteNonQuery();
            db1.LukDatabaseConnection();
        }
    }


}
