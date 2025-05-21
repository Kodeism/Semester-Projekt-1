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
    public partial class duoForside : UserControl
    {
        public enum Mode { Salg, Boliger, Købere, Sælgere }
        private Mode _mode;
        public duoForside(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
            _mode = mode;
        }
        public void SetMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Salg:
                    mineLabel.Text = "Mine Salg";
                    alleLabel.Text = "Alle Salg";
                    mineSøgeFelt.Text = "Søg Adresse...";
                    alleSøgeFelt.Text = "Søg Adresse...";
                    break;
                case Mode.Sælgere:
                    mineLabel.Text = "Mine Sælgere";
                    alleLabel.Text = "Alle Sælgere";
                    mineSøgeFelt.Text = "Søg Navn...";
                    alleSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.Købere:
                    mineLabel.Text = "Mine Købere";
                    alleLabel.Text = "Alle Købere";
                    mineSøgeFelt.Text = "Søg Navn...";
                    alleSøgeFelt.Text = "Søg Navn...";
                    break;
                case Mode.Boliger:
                    mineLabel.Text = "Mine Boliger";
                    alleLabel.Text = "Alle Boliger";
                    mineSøgeFelt.Text = "Søg Adresse...";
                    alleSøgeFelt.Text = "Søg Adresse...";
                    break;
            }
        }

        private void mineRegistrerKnap_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Salg)
            {
                SaleRegistration salg = new SaleRegistration();
                salg.ShowDialog();
            }
            if (_mode == Mode.Sælgere)
            {
                FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
                formTilføjSælger.ShowDialog();
            }
            if (_mode == Mode.Købere)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            if (_mode == Mode.Boliger)
            {
                BoligRegistration formTilføjBolig = new BoligRegistration();
                formTilføjBolig.ShowDialog();
            }
        }

        private void alleRegistrerKnap_Click(object sender, EventArgs e)
        {
            if (_mode == Mode.Salg)
            {
                SaleRegistration salg = new SaleRegistration();
                salg.ShowDialog();
            }
            if (_mode == Mode.Sælgere)
            {
                FormTilføjSælger formTilføjSælger = new FormTilføjSælger();
                formTilføjSælger.ShowDialog();
            }
            if (_mode == Mode.Købere)
            {
                TilføjKøber tilKøber = new TilføjKøber();
                tilKøber.ShowDialog();
            }
            if (_mode == Mode.Boliger)
            {
                BoligRegistration formTilføjBolig = new BoligRegistration();
                formTilføjBolig.ShowDialog();
            }
        }
    }
}
