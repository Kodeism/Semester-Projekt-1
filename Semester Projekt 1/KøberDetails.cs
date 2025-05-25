using Models;
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
    public partial class KøberDetails : Form
    {
        private DataTable Køber;
        private int KøberID;
        public KøberDetails(DataTable data)
        {
            InitializeComponent();
            Køber = data;
            if (SessionManager.AdgangsNiveau != 2)
            {
                redigerButton.Enabled = false;
                gemÆndringerButton.Enabled = false;
                createSaleButton.Enabled = false;
            }
            KøberID = Convert.ToInt32(Køber.Rows[0]["KøberID"]);
        }

        private void KøberDetails_Load(object sender, EventArgs e)
        {
            køberInfoLabel.Text = $"Køber:[{KøberID.ToString()}] Info";
            forNavnTextBox.Text = Køber.Rows[0]["Fornavn"].ToString();
            efterNavnTextBox.Text = Køber.Rows[0]["EfterNavn"].ToString();
            emailTextBox.Text = Køber.Rows[0]["Email"].ToString();
            tlfNummerTextBox.Text = Køber.Rows[0]["TlfNummer"].ToString();
            prisKlasseTextBox.Text = Køber.Rows[0]["PrisKlasse"].ToString();
            adresseTextBox.Text = Køber.Rows[0]["Adresse"].ToString();
            søgeOmrådeTextBox.Text = Køber.Rows[0]["SøgeOmråde"].ToString();
            boligTypeTextBox.Text = Køber.Rows[0]["BoligType"].ToString();
            noterTextBox.Text = Køber.Rows[0]["Noter"].ToString();
            ønsketGrundStørrelseTextBox.Text = Køber.Rows[0]["ØnsketGrundStørrelse"].ToString();
            ønsketBoligStørrelseTextBox.Text = Køber.Rows[0]["ØnsketBoligStørrelse"].ToString();
            ønsketVærelserTextBox.Text = Køber.Rows[0]["ØnsketVærelser"].ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
