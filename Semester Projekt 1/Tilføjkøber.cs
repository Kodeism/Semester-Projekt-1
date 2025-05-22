using BusineesLogic;

namespace Semester_Projekt_1
{
    public partial class TilføjKøber : Form
    {
        private int boligID;

        public TilføjKøber(int boligID)
        {
            InitializeComponent();
            this.boligID = boligID;
            Console.Write(boligID);
        }
        public TilføjKøber()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anullerButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void opretButton_Click(object sender, EventArgs e)
        {
            string navn = navnTextbox.Text;
            navn = navn.Trim();
            if (string.IsNullOrEmpty(navn))
            {
                navnTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst fornavn");
            }
            
            string efternavn = efternavnTextbox.Text;
            efternavn = efternavn.Trim();
            if (string.IsNullOrEmpty(efternavn))
            {
                efternavnTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst efternavn");
            }

            string adresse = adresseTextbox.Text;
            adresse = adresse.Trim();
            if (string.IsNullOrEmpty(adresse))
            {
                adresseTextbox.BackColor= Color.Red;
                MessageBox.Show("Indtast venligst adresse");
            }
            //Giver error message, og highlighter box med rød, hvis der indtastes andet end tal i til tlfnummer.
            string tlfNummer = "0";
            try
            {
                tlfNummer = telefonnummerTextbox.Text;
            }
            catch
            {
                telefonnummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i telefonnummerboxen");
                return;
            }
            int prisklasse = 0;
            try
            {
                prisklasse = int.Parse(prisklasseTextbox.Text);
            }
            catch
            {
                prisklasseTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i Prisklasseboksen");
            }
            string boligtype = boligtypeCombobox.Text;
            boligtype.Trim();
            string søgeområde = søgeområdeTextbox.Text;
            søgeområde.Trim();
            string cprNummer = cprnummerTextbox.Text;

            cprNummer.Trim();
            if (string.IsNullOrEmpty(cprNummer))
            {
                cprnummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast venligst sælgers CPR-NR");
            }
            else if (cprNummer.Length > 11 || cprNummer.Length < 11)
            {
                cprnummerTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast CPR med format DDMMÅÅ-****");
            }


            string yderligereInfo = yderligereinfoTextBox.Text;
            int boligStørrelse = 0;
            try
            {
                boligStørrelse = int.Parse(boligstørrelseTextbox.Text);
            }
            catch
            {
                boligstørrelseTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i Boligstørrelseboksen");
            }
            int grundStørrelse = 0;
            try
            {
                grundStørrelse = int.Parse(grundstørrelseTextbox.Text);
            }
            catch
            {
                grundstørrelseTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i Grundstørrelseboksen");
            }
            int værelser = 0;
            try
            {
                værelser = int.Parse(værelserTextbox.Text);
            }
            catch
            {
                værelserTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast kun tal i Værelserboksen");
            }

            string email = emailTextbox.Text;
            email.Trim();
            if (!email.Contains('@') || !email.Contains('.'))
            {
                emailTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast en gyldig email");
            }
            
            KøberFunktioner køberFunktion = new KøberFunktioner();
            try
            {
                køberFunktion.TilføjKøber(navn, efternavn, adresse, tlfNummer, cprNummer, email, søgeområde, prisklasse, boligtype, boligStørrelse, grundStørrelse, værelser, yderligereInfo);
                MessageBox.Show("Køber er oprettet.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Noget gik galt!");
            }

        }
    }
}
