using BusineesLogic;
using System;
using Models;
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
    public partial class MæglerDetails : Form
    {
        private DataTable Mægler;
        private List<int> boligIDListe = new List<int>();
        private List<int> køberIDListe = new List<int>();
        private List<int> sælgerIDListe = new List<int>();
        private List<string> boligListe = new List<string>();
        private List<string> køberListe = new List<string>();
        private List<string> sælgerListe = new List<string>();
        private BoligLogic boligLogic = new BoligLogic();
        public MæglerDetails(DataTable data)
        {
            InitializeComponent();
            Mægler = data;
            if (SessionManager.AdgangsNiveau != 2)
            {
                redigerButton.Enabled = false;
                gemÆndringerButton.Enabled = false;
                createSaleButton.Enabled = false;
            }
        }
        private void MæglerDetails_Load(object sender, EventArgs e)
        {
            forNavnTextBox.Text = Mægler.Rows[0]["Fornavn"].ToString();
            efterNavnTextBox.Text = Mægler.Rows[0]["EfterNavn"].ToString();
            tlfNummerTextBox.Text = Mægler.Rows[0]["TlfNummer"].ToString();
            emailTextBox.Text = Mægler.Rows[0]["Email"].ToString();
            mæglerInfoLabel.Text = $"Mægler:[{Mægler.Rows[0]["EjendomsmæglerID"]}] Info";
            if (Mægler.Rows[0]["Sælger"].ToString().Any(c => c != '.' && c != ',' && !char.IsWhiteSpace(c)))
            {
                string[] sælgere = Mægler.Rows[0]["Sælger"].ToString().Split(',');
                foreach (string sælger in sælgere)
                {
                    if (string.IsNullOrWhiteSpace(sælger))
                        continue;
                    string[] ar = sælger.Split('.');
                    sælgerListe.Add(ar[1]);
                    sælgerIDListe.Add(Convert.ToInt32(ar[0]));
                }
                sælgereDataGridView.DataSource = sælgerListe.Select(b => new { Sælger = b }).ToList();
            }
            if (Mægler.Rows[0]["Køber"].ToString().Any(c => c != '.' && c != ',' && !char.IsWhiteSpace(c)))
            {
                string[] købere = Mægler.Rows[0]["Køber"].ToString().Split(',');
                foreach (string køber in købere)
                {
                    string[] ar = køber.Split('.');
                    køberListe.Add(ar[1]);
                    køberIDListe.Add(Convert.ToInt32(ar[0]));
                }
                købereDataGridView.DataSource = køberListe.Select(b => new { Køber = b }).ToList();
            }
            if (Mægler.Rows[0]["Boliger"].ToString().Any(c => c != '.' && c != ',' && !char.IsWhiteSpace(c)))
            {
                string[] boliger = Mægler.Rows[0]["Boliger"].ToString().Split(',');
                foreach (string bolig in boliger)
                {
                    string[] ar = bolig.Split('.');
                    boligListe.Add(ar[1]);
                    boligIDListe.Add(Convert.ToInt32(ar[0]));
                }
                boligerDataGridView.DataSource = boligListe.Select(b => new { Bolig = b }).ToList();
            }

        }

        private void sælgereDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            SælgerDetails sd = new SælgerDetails(boligLogic.GetDetails(sælgerIDListe[index], "Sælger"));
            sd.ShowDialog();
        }
        private void købereDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            KøberDetails kd = new KøberDetails(boligLogic.GetDetails(køberIDListe[index], "Køber"));
            kd.ShowDialog();
        }

        private void boligerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            BoligDetaljer bd = new BoligDetaljer(boligLogic.GetDetails(boligIDListe[index], "Bolig"));
            bd.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
