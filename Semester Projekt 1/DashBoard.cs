using Models;

namespace Semester_Projekt_1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            this.FormClosed += Close_Program;
            openPage(new Forside());
            brugerNavnLabel.Text = SessionManager.FuldeNavn;
        }
        private void Close_Program(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        internal void openPage(UserControl page)
        {
            screenDBPanel.Controls.Clear();
            screenDBPanel.Controls.Add(page);
            page.Dock = DockStyle.Fill;
        }
        private void startDBKnap_Click(object sender, EventArgs e)
        {
            openPage(new Forside());
            pageLabel.Text = "Forside";
        }

        internal void boligDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Boliger";
            openPage(new duoForside(duoForside.Mode.Boliger));
            var max = boligDBKnap.Height + mineBoligerDBKnap.Height + alleBolgierDBKnap.Height + boligerRegistrerDBKnap.Height;
            var min = boligDBKnap.Height;
            if (boligDBPanel.Height != max)
            {
                boligDBPanel.Height = max;
            }
            else if (boligDBPanel.Height == max)
            {
                boligDBPanel.Height = min;
            }
        }

        private void personDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Personer";
            var min = personDBKnap.Height;
            var maxunder = min + mæglerDBKnap.Height + sælgereDBKnap.Height + køberDBKnap.Height;
            if (personDBPanel.Height == min)
            {
                personDBPanel.Height = maxunder;
            }
            else if (personDBPanel.Height <= maxunder)
            {
                personDBPanel.Height = min;
            }
            else if (personDBPanel.Height > maxunder)
            {
                personDBPanel.Height = min;
                sælgerDBPanel.Height = sælgereDBKnap.Height;
                køberDBPanel.Height = køberDBKnap.Height;
            }
            openPage(new PersonForside());
        }

        private void sælgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Sælgere";
            var max = sælgereDBKnap.Height + mineSælgereDBKnap.Height + alleSælgereDBKnap.Height + registrerDBKnap.Height;
            var min = sælgereDBKnap.Height;
            var dif = max - min;
            if (sælgerDBPanel.Height == max)
            {
                sælgerDBPanel.Height = min;
                personDBPanel.Height -= dif;
            }
            else if (sælgerDBPanel.Height == min)
            {
                sælgerDBPanel.Height = max;
                personDBPanel.Height += dif;
            }
            openPage(new duoForside(duoForside.Mode.Sælgere));
        }

        private void køberDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Købere";
            var max = køberDBKnap.Height + mineKøbereDBKnap.Height + alleKøbereDBKnap.Height + registrerKøberDBKnap.Height;
            var min = køberDBKnap.Height;
            var dif = max - min;
            if (køberDBPanel.Height == max)
            {
                køberDBPanel.Height = min;
                personDBPanel.Height -= dif;
            }
            else if (køberDBPanel.Height == min)
            {
                køberDBPanel.Height = max;
                personDBPanel.Height += dif;
            }
            openPage(new duoForside(duoForside.Mode.Købere));
        }

        private void salgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Salg";
            var max = salgDBKnap.Height + mineSalgDBKnap.Height + alleSalgDBKnap.Height + salgRegistrerDBKnap.Height;
            var min = salgDBKnap.Height;
            if (salgDBPanel.Height != max)
            {
                salgDBPanel.Height = max;
            }
            else if (salgDBPanel.Height == max)
            {
                salgDBPanel.Height = min;
            }
            openPage(new duoForside(duoForside.Mode.Salg));
        }

        private void mæglerDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mæglere";
            openPage(new MæglerSide());
        }

        private void mineSælgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Sælgere";
            openPage(new UniForside(UniForside.Mode.MineS));
        }

        private void alleSælgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Sælgere";
            openPage(new UniForside(UniForside.Mode.AlleS));
        }

        private void registrerDBKnap_Click(object sender, EventArgs e)
        {
            FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
            formTilføjSælger.ShowDialog();
        }

        private void mineKøbereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Købere";
            openPage(new UniForside(UniForside.Mode.MineK));
        }

        private void alleKøbereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Købere";
            openPage(new UniForside(UniForside.Mode.AlleK));
        }

        private void registrerKøberDBKnap_Click(object sender, EventArgs e)
        {
            TilføjKøber tilKøber = new TilføjKøber();
            tilKøber.ShowDialog();
        }

        private void mineSalgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Salg";
            openPage(new salgSide(salgSide.Mode.Mine));
        }

        private void alleSalgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Salg";
            openPage(new salgSide(salgSide.Mode.Alle));
        }

        private void salgRegistrerDBKnap_Click(object sender, EventArgs e)
        {
            SaleRegistration saleRegistration = new SaleRegistration();
            saleRegistration.ShowDialog();
        }

        private void mineBoligerDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Boliger";
            openPage(new UniForside(UniForside.Mode.MineB));
        }

        private void alleBolgierDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Boliger";
            openPage(new UniForside(UniForside.Mode.AlleB));
        }

        private void logUdDBKnap_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            SessionManager.Clear();
        }

        private void boligerRegistrerDBKnap_Click(object sender, EventArgs e)
        {
            BoligRegistration boligRegistration = new BoligRegistration();
            boligRegistration.ShowDialog();
        }

        private void exportData_Click(object sender, EventArgs e)
        {

        }
    }
}



