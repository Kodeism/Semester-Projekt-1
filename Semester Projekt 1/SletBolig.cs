using Microsoft.Data.SqlClient;

namespace Semester_Projekt_1
{
    public partial class SletBolig : Form
    {
        public SletBolig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; TrustServerCertificate = True;";

            if (int.TryParse(idTextbox.Text.Trim(), out int boligIdToDelete))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Bolig WHERE BoligID = @BoligID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@BoligID", boligIdToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Bolig slettet succesfuldt.");
                        }
                        else
                        {
                            MessageBox.Show("Ingen bolig fundet med det ID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fejl: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Venligst indtast gyldigt BoligID.");
            }
        }
    }
}
