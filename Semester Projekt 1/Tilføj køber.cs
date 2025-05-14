using BusineesLogic;

namespace Semester_Projekt_1
{
    public partial class TilføjKøberDesign : Form
    {
        public TilføjKøberDesign()
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

        }

        private void opretButton_Click(object sender, EventArgs e)
        {
            string navn = navnTextbox.Text;
            string efternavn = efternavnTextbox.Text;
            string adresse = adresseTextbox.Text;
            //Giver error message, og highlighter box med rød, hvis der indtastes andet end tal i til tlfnummer.
            int tlfNummer = 0;
            try
            {
                tlfNummer = int.Parse(telefonnummerTextbox.Text);
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
            string søgeområde = søgeområdeTextbox.Text;
            string cprNummer = cprnummerTextbox.Text;

            string email = emailTextbox.Text;
            if (!email.Contains('@') || !email.Contains('.'))
            {
                emailTextbox.BackColor = Color.Red;
                MessageBox.Show("Indtast en gyldig email");
            }
            else
            {
                KøberFunktioner køberFunktion = new KøberFunktioner();
                køberFunktion.TilføjKøber(navn, efternavn, adresse, tlfNummer, cprNummer, email, søgeområde, prisklasse, boligtype);
            }
        }
    }
}
