using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Projekt_1
{
    public partial class UniForside : UserControl
    {
        private Mode mode_;
        public enum Mode { AlleS, MineS, AlleK, MineK, AlleB, MineB }
        public UniForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
            mode_ = mode;
        }
        public void SetMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.AlleS:
                    uniLabel.Text = "Alle Sælgere";
                    uniSøgeFelt.PlaceholderText = "Søg Navn...";
                    break;
                case Mode.MineS:
                    uniLabel.Text = "Mine Sælgere";
                    uniSøgeFelt.PlaceholderText = "Søg Navn...";
                    break;
                case Mode.AlleK:
                    uniLabel.Text = "Alle Købere";
                    uniSøgeFelt.PlaceholderText = "Søg Navn...";
                    break;
                case Mode.MineK:
                    uniLabel.Text = "Mine Købere";
                    uniSøgeFelt.PlaceholderText = "Søg Navn...";
                    break;
                case Mode.AlleB:
                    uniLabel.Text = "Alle Boliger";
                    uniSøgeFelt.PlaceholderText = "Søg Adresse...";
                    break;
                case Mode.MineB:
                    uniLabel.Text = "Mine Boliger";
                    uniSøgeFelt.PlaceholderText = "Søg Adresse...";
                    break;
            }
        }

        private void uniRegistrerKnap_Click(object sender, EventArgs e)
        {
            if(mode_==Mode.AlleS||mode_==Mode.MineS)
            {
                SaleRegistration saleRegistration = new SaleRegistration();
                saleRegistration.ShowDialog();
            }
            else if (mode_ == Mode.AlleK || mode_ == Mode.MineK)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            else if (mode_ == Mode.AlleB || mode_ == Mode.MineB)
            {
                BoligRegistration tilBolig = new BoligRegistration();
                tilBolig.ShowDialog();
            }
        }
    }
}
