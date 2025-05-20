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
    public partial class salgSide : UserControl
    {
        public enum Mode { Mine, Alle }
        public salgSide(Mode mode)
        {
            InitializeComponent();
            SetMode(mode);
        }
        private void SetMode(Mode _mode)
        {
            switch (_mode)
            {
                case Mode.Mine:
                    salgLabel.Text = "Mine Salg";
                    break;
                case Mode.Alle:
                    salgLabel.Text = "Alle Salg";
                    break;
            }
        }
    }
}
