using BusineesLogic;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Projekt_1
{
    public partial class SælgerDetails : Form
    {
        private DataTable Sælger;
        private List<string> boligListe = new List<string>();
        private List<int> boligIDListe = new List<int>();
        private List<string> køberListe = new List<string>();
        private List<int> køberIDListe = new List<int>();
        public SælgerDetails(DataTable data)
        {
            InitializeComponent();
            Sælger = data;
            if (SessionManager.AdgangsNiveau != 2)
            {
                redigerButton.Enabled = false;
                gemÆndringerButton.Enabled = false;
                createSaleButton.Enabled = false;
            }
        }

        private void SælgerDetails_Load(object sender, EventArgs e)
        {
            if (Sælger.Rows[0]["Boliger"].ToString().Any(c => c != '.' && c != ',' && !char.IsWhiteSpace(c)))
            {
                string[] strings = Sælger.Rows[0]["Boliger"].ToString().Split(',');
                foreach (string str in strings)
                {
                    string[] ar = str.Split('.');
                    boligListe.Add(ar[1]);
                    boligIDListe.Add(Convert.ToInt32(ar[0]));
                }
                boligerDataGridView.DataSource = boligListe.Select(b => new { Bolig = b }).ToList();
            }
            if (Sælger.Rows[0]["Købere"].ToString().Any(c => c != '.' && c != ',' && !char.IsWhiteSpace(c)))
            {
                string[] strings = Sælger.Rows[0]["Købere"].ToString().Split(',');
                foreach (string str in strings)
                {
                    string[] ar = str.Split('.');
                    køberListe.Add(ar[1]);
                    køberIDListe.Add(Convert.ToInt32(ar[0]));
                }
                købereDataGridView.DataSource = køberListe.Select(b => new { Køber = b }).ToList();
            }
            forNavnTextBox.Text = Sælger.Rows[0]["Fornavn"].ToString();
            efterNavnTextBox.Text = Sælger.Rows[0]["EfterNavn"].ToString();
            emailTextBox.Text = Sælger.Rows[0]["Email"].ToString();
            tlfNummerTextBox.Text = Sælger.Rows[0]["TlfNummer"].ToString();
            adresseTextBox.Text = Sælger.Rows[0]["Adresse"].ToString();
            antalBoligerTextBox.Text = boligListe.Count.ToString();
            sælgerInfoLabel.Text = $"Sælger:[{Sælger.Rows[0]["SælgerID"]}] Info";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boligerDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            BoligLogic boligLogic = new BoligLogic();
            DataTable datas = boligLogic.GetDetails(boligIDListe[index], "Bolig");
            BoligDetaljer bd = new BoligDetaljer(datas);
            bd.Show();
        }

        private void købereDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            int index = e.RowIndex;
            BoligLogic boligLogic = new BoligLogic();
            DataTable datas = boligLogic.GetDetails(køberIDListe[index], "Køber");
            KøberDetails kd = new KøberDetails(datas);
            kd.Show();
        }
    }
}
