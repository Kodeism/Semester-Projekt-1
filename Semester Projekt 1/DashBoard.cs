namespace Semester_Projekt_1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            openPage(new Forside());
        }
        private void closeMenu(FlowLayoutPanel menu)
        {
            menu.Height = menu.MinimumSize.Height;
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
            closeMenu(boligDBPanel);
            closeMenu(personDBPanel);
            closeMenu(sælgerDBPanel);
            closeMenu(køberDBPanel);
            closeMenu(salgDBPanel);
        }

        internal void boligDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Boliger";
            openPage(new duoForside(duoForside.Mode.Boliger));
            var max = boligDBPanel.MaximumSize.Height;
            var min = boligDBPanel.MinimumSize.Height;
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
            if (personDBPanel.Height == personDBPanel.MinimumSize.Height)
            {
                personDBPanel.Height = 141;
            }
            else if (personDBPanel.Height <= 141)
            {
                personDBPanel.Height = personDBPanel.MinimumSize.Height;
            }
            else if (personDBPanel.Height > 141)
            {
                personDBPanel.Height = personDBPanel.MinimumSize.Height;
                sælgerDBPanel.Height = sælgerDBPanel.MinimumSize.Height;
                køberDBPanel.Height = køberDBPanel.MinimumSize.Height;
            }
            openPage(new PersonForside());
        }

        private void sælgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Sælgere";
            var max = sælgerDBPanel.MaximumSize.Height;
            var min = sælgerDBPanel.MinimumSize.Height;
            var dif = max - min;
            if (sælgerDBPanel.Height == max)
            {
                personDBPanel.Height -= dif;
                sælgerDBPanel.Height = min;
            }
            else if (sælgerDBPanel.Height == min)
            {
                personDBPanel.Height += dif;
                sælgerDBPanel.Height = max;
            }
            openPage(new duoForside(duoForside.Mode.Sælgere));
        }

        private void køberDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Købere";
            var max = køberDBPanel.MaximumSize.Height;
            var min = køberDBPanel.MinimumSize.Height;
            var dif = max - min;
            if (køberDBPanel.Height == max)
            {
                personDBPanel.Height -= dif;
                køberDBPanel.Height = min;
            }
            else if (køberDBPanel.Height == min)
            {
                personDBPanel.Height += dif;
                køberDBPanel.Height = max;
            }
            openPage(new duoForside(duoForside.Mode.Købere));
        }

        private void salgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Salg";
            var max = salgDBPanel.MaximumSize.Height;
            var min = salgDBPanel.MinimumSize.Height;
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
    }
}



