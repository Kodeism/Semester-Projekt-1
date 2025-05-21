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
            var maxunder = min + m�glerDBKnap.Height + s�lgereDBKnap.Height + k�berDBKnap.Height;
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
                s�lgerDBPanel.Height = s�lgereDBKnap.Height;
                k�berDBPanel.Height = k�berDBKnap.Height;
            }
            openPage(new PersonForside());
        }

        private void s�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "S�lgere";
            var max = s�lgereDBKnap.Height + mineS�lgereDBKnap.Height + alleS�lgereDBKnap.Height + registrerDBKnap.Height;
            var min = s�lgereDBKnap.Height;
            var dif = max - min;
            if (s�lgerDBPanel.Height == max)
            {
                s�lgerDBPanel.Height = min;
                personDBPanel.Height -= dif;
            }
            else if (s�lgerDBPanel.Height == min)
            {
                s�lgerDBPanel.Height = max;
                personDBPanel.Height += dif;
            }
            openPage(new duoForside(duoForside.Mode.S�lgere));
        }

        private void k�berDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "K�bere";
            var max = k�berDBKnap.Height + mineK�bereDBKnap.Height + alleK�bereDBKnap.Height + registrerK�berDBKnap.Height;
            var min = k�berDBKnap.Height;
            var dif = max - min;
            if (k�berDBPanel.Height == max)
            {
                k�berDBPanel.Height = min;
                personDBPanel.Height -= dif;
            }
            else if (k�berDBPanel.Height == min)
            {
                k�berDBPanel.Height = max;
                personDBPanel.Height += dif;
            }
            openPage(new duoForside(duoForside.Mode.K�bere));
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

        private void m�glerDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "M�glere";
            openPage(new M�glerSide());
        }

        private void mineS�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine S�lgere";
            openPage(new UniForside(UniForside.Mode.MineS));
        }

        private void alleS�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle S�lgere";
            openPage(new UniForside(UniForside.Mode.AlleS));
        }

        private void registrerDBKnap_Click(object sender, EventArgs e)
        {
            FormTilf�jS�lger formTilf�jS�lger = new FormTilf�jS�lger();
            formTilf�jS�lger.ShowDialog();
        }

        private void mineK�bereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine K�bere";
            openPage(new UniForside(UniForside.Mode.MineK));
        }

        private void alleK�bereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle K�bere";
            openPage(new UniForside(UniForside.Mode.AlleK));
        }

        private void registrerK�berDBKnap_Click(object sender, EventArgs e)
        {
            Tilf�jK�ber tilK�ber = new Tilf�jK�ber();
            tilK�ber.ShowDialog();
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



