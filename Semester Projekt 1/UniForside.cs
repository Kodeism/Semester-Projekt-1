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
        public enum Mode { AlleS, MineS, AlleK, MineK, AlleB, MineB }
        public UniForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
        }
        public void SetMode(Mode mode)
        {
            switch(mode)
            {
                case Mode.AlleS:
                    uniLabel.Text = "Alle Sælgere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.MineS:
                    uniLabel.Text = "Mine Sælgere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.AlleK:
                    uniLabel.Text = "Alle Købere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.MineK:
                    uniLabel.Text = "Mine Købere";
                    uniSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.AlleB:
                    uniLabel.Text = "Alle Boliger";
                    uniSøgeFelt.Text = "Søg Adresse...";
                    break;
                case Mode.MineB:
                    uniLabel.Text = "Mine Boliger";
                    uniSøgeFelt.Text = "Søg Adresse...";
                    break;
            }
        }
    }
}
