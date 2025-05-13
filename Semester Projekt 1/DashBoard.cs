namespace Semester_Projekt_1
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        private void closeMenu(FlowLayoutPanel menu)
        {
            menu.Height = menu.MinimumSize.Height;
        }
        private void startDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Forside";
            closeMenu(boligDBPanel);
            closeMenu(personDBPanel);
            closeMenu(s�lgerDBPanel);
            closeMenu(k�berDBPanel);
            closeMenu(salgDBPanel);
        }

        private void boligDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Boliger";
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
                s�lgerDBPanel.Height = s�lgerDBPanel.MinimumSize.Height;
                k�berDBPanel.Height = k�berDBPanel.MinimumSize.Height;
            }
        }

        private void s�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "S�lgere";
            var max = s�lgerDBPanel.MaximumSize.Height;
            var min = s�lgerDBPanel.MinimumSize.Height;
            var dif = max - min;
            if (s�lgerDBPanel.Height == max)
            {
                personDBPanel.Height -= dif;
                s�lgerDBPanel.Height = min;
            }
            else if (s�lgerDBPanel.Height == min)
            {
                personDBPanel.Height += dif;
                s�lgerDBPanel.Height = max;
            }
        }

        private void k�berDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "K�bere";
            var max = k�berDBPanel.MaximumSize.Height;
            var min = k�berDBPanel.MinimumSize.Height;
            var dif = max - min;
            if (k�berDBPanel.Height == max)
            {
                personDBPanel.Height -= dif;
                k�berDBPanel.Height = min;
            }
            else if (k�berDBPanel.Height == min)
            {
                personDBPanel.Height += dif;
                k�berDBPanel.Height = max;
            }
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
        }

        private void m�glerDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "M�glere";
        }

        private void mineS�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine S�lgere";
        }

        private void alleS�lgereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle S�lgere";
        }

        private void registrerDBKnap_Click(object sender, EventArgs e)
        {

        }

        private void mineK�bereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine K�bere";
        }

        private void alleK�bereDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle K�bere";
        }

        private void registrerK�berDBKnap_Click(object sender, EventArgs e)
        {

        }

        private void mineSalgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Salg";
        }

        private void alleSalgDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Salg";
        }

        private void salgRegistrerDBKnap_Click(object sender, EventArgs e)
        {

        }

        private void mineBoligerDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Mine Boliger";
        }

        private void alleBolgierDBKnap_Click(object sender, EventArgs e)
        {
            pageLabel.Text = "Alle Boliger";
        }
    }
}
