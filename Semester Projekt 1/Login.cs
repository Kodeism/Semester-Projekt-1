using BusineesLogic;

namespace Semester_Projekt_1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e) // dette er selve formen
        {
            // if user allerede er loggede ind så send automatisk brugeren hen til forsiden
            // if (user == loggedin) { frontPage.Show();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            UsernameTextBox.BackColor = Color.White;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            PasswordTextBox.BackColor = Color.White;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        { // Basale verifikationer af data bare for fjerne input som med guaranti ikke gør noget
            bool validInput = true;
            if (UsernameTextBox.Text == "")
            {
                UsernameTextBox.BackColor = Color.Red;
                LoginErrorLabelUsername.Text = "Username cant be empty!";
                validInput = false;
            } else if (UsernameTextBox.Text.Contains(" "))
            {
                UsernameTextBox.BackColor = Color.Red;
                LoginErrorLabelUsername.Text = "Username must not contain spaces!";
                validInput = false;
            } else
            {
                LoginErrorLabelUsername.Text = "";
            }
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.BackColor = Color.Red;
                LoginErrorLabelPassword.Text = "Password cant be empty!";
                validInput = false;
            } else if (PasswordTextBox.Text.Contains(" "))
            {
                PasswordTextBox.BackColor = Color.Red;
                LoginErrorLabelPassword.Text = "Password must not contain spaces!";
                validInput = false;
            } else
            {
                LoginErrorLabelPassword.Text = "";
            }

            if (validInput)
            {
                var loginHandler = new TryLogin();
                bool loginSuccess = loginHandler.login(UsernameTextBox.Text, PasswordTextBox.Text);

                if (loginSuccess)
                {
                    SaleRegistration saleRegistration = new SaleRegistration();
                    saleRegistration.Show(); // Dette skal skiftes om til forsiden når den bliver lavet
                    this.Hide();
                }
            }

        }

    }
}
