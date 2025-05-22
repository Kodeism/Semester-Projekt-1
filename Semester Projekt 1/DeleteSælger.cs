using Microsoft.Data.SqlClient;

namespace Semester_Projekt_1
{
    public partial class DeleteSælger : Form
    {
        private int sælgerID;
        public DeleteSælger()
        {
            InitializeComponent();
        }
        public DeleteSælger(int sælgerID)
        {
            InitializeComponent();
            sælgerID = sælgerID;
            sælgerIDTextBox.Text = sælgerID.ToString();
        }

        private void annullerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sletsælgerButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Server = localhost; Database = Semester projekt gruppe 1; User ID = sa; Password = 1234; TrustServerCertificate = True;";

            if (int.TryParse(sælgerIDTextBox.Text.Trim(), out int userIdToDelete))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Sælger WHERE SælgerID = @SælgerID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SælgerID", userIdToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Sælger slettet succesfuldt.");
                        }
                        else
                        {
                            MessageBox.Show("Ingen sælgere fundet med det ID.");
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
                MessageBox.Show("Venligst indtast gyldigt sælger ID.");
            }
        }
    }
}
