using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusineesLogic;
using Microsoft.Data.SqlClient;
using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using Semester_Projekt_1;

namespace Semester_Projekt_1
{
    public partial class Forside : UserControl
    {
        public Dictionary<string, List<object>> Data { get; set; }
        private DashBoard main;
        private ForsideLogic logic = new();
        public Forside()
        {
            InitializeComponent();
            this.AutoScrollPosition = new Point(0, 0);
            Data = logic.Data;
            main = (DashBoard)this.FindForm();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

        }
        private void statBoxesLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadPieKøber()
        {
            List<PieSlice> slices = [
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][0]), FillColor = Colors.Red,LegendText = "Villa"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][1]), FillColor = Colors.Green,LegendText = "Lejlighed"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][2]), FillColor = Colors.Black,LegendText = "Rækkehus"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][3]), FillColor = Colors.Blue,LegendText = "Andelsbolig"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][4]), FillColor = Colors.DeepPink,LegendText = "Ejerlejlighed"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][5]), FillColor = Colors.Aqua,LegendText = "Sommerhus"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][6]), FillColor = Colors.Purple,LegendText = "Ungdomsbolig"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][7]), FillColor = Colors.Maroon,LegendText = "Ældrebolig"},
                new PieSlice() {Value=Convert.ToInt32(Data["pie"][8]), FillColor = Colors.Indigo,LegendText = "Kolonihavehus"},
                ];
            var pie = køberBoligTypePlot.Plot.Add.Pie(slices);
            double total = pie.Slices.Select(x => x.Value).Sum();
            double[] percentages = pie.Slices.Select(x => x.Value / total * 100).ToArray();
            for (int i = 0; i < pie.Slices.Count; i++)
            {
                pie.Slices[i].Label = $"{percentages[i]:0.0}%";
                pie.Slices[i].LabelFontSize = 20;
                pie.Slices[i].LabelBold = true;
                pie.Slices[i].LabelFontColor = Colors.Black.WithAlpha(.5);
            }
            pie.ExplodeFraction = .1;
            pie.SliceLabelDistance = 1.4;
            køberBoligTypePlot.Plot.Axes.Frameless();
            køberBoligTypePlot.Plot.HideGrid();
            køberBoligTypePlot.Plot.DataBackground.Color = Colors.Transparent;
            køberBoligTypePlot.Plot.FigureBackground.Color = Colors.Transparent;
            køberBoligTypePlot.Plot.Title("Søgt Boliger Fordelt På Boligtyper");
            køberBoligTypePlot.Refresh();
        }
        public void loadBar()
        {
            ScottPlot.Bar[] bars = [
                new() {Position=1,ValueBase=0,FillColor = Colors.Red,Value=Convert.ToInt32(Data["bar"][0])},
                new() {Position=2,ValueBase=0,FillColor = Colors.Green,Value=Convert.ToInt32(Data["bar"][1])},
                new() {Position=3,ValueBase=0,FillColor = Colors.Black,Value=Convert.ToInt32(Data["bar"][2])},
                new() {Position=4,ValueBase=0,FillColor = Colors.Blue,Value=Convert.ToInt32(Data["bar"][3])},
                new() {Position=5,ValueBase=0,FillColor = Colors.DeepPink,Value=Convert.ToInt32(Data["bar"][4])},
                new() {Position=6,ValueBase=0,FillColor = Colors.Aqua,Value=Convert.ToInt32(Data["bar"][5])},
                new() {Position=7,ValueBase=0,FillColor = Colors.Purple,Value=Convert.ToInt32(Data["bar"][6])},
                new() {Position=8,ValueBase=0,FillColor = Colors.Maroon,Value=Convert.ToInt32(Data["bar"][7])},
                new() {Position=9,ValueBase=0,FillColor = Colors.Indigo,Value=Convert.ToInt32(Data["bar"][8])}
                ];
            Tick[] ticks = [
                new(1,"Villa"),
                new(2,"Lejlighed"),
                new(3,"Rækkehus"),
                new(4,"Andelsbolig"),
                new(5,"Ejerlejlighed"),
                new(6,"Sommerhus"),
                new(7,"Ungdomsbolig"),
                new(8,"Ældrebolig"),
                new(9,"Kolonihavehus")
                ];
            boligerBoligTypePlot.Plot.Add.Bars(bars);
            boligerBoligTypePlot.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(ticks);
            boligerBoligTypePlot.Plot.Axes.Bottom.MajorTickStyle.Length = 0;
            boligerBoligTypePlot.Plot.Axes.Margins(bottom: 0);
            boligerBoligTypePlot.Plot.DataBackground.Color = Colors.Transparent;
            boligerBoligTypePlot.Plot.FigureBackground.Color = Colors.Transparent;
            boligerBoligTypePlot.Plot.Title("Usolgte Boliger Fordelt på BoligTypen");
            boligerBoligTypePlot.Refresh();
        }

        private void Forside_Load(object sender, EventArgs e)
        {
            loadPieKøber();
            loadBar();
            boligAntalLabel.Text = Convert.ToInt64(Data["label"][0]).ToString("N0"); ;
            antalUsolgteBoligerLabel.Text = Convert.ToInt64(Data["label"][1]).ToString("N0"); ;
            købereAntalLabel.Text = Convert.ToInt64(Data["label"][2]).ToString("N0"); ;
            boligtypeEftersøgtLabel.Text = Data["label"][3].ToString();
            sælgereAntalLabel.Text = Convert.ToInt64(Data["label"][4]).ToString("N0"); ;
            boligtypeUdbudtLabel.Text = Data["label"][5].ToString();
            antalSalgLabel.Text = Convert.ToInt64(Data["label"][6]).ToString("N0");
            sumPengeSalgLabel.Text = Convert.ToInt64(Data["label"][7]).ToString("N0") + " kr.";
            nyeBoliger.DataSource = Data["tabel"][0];
            nyeBoliger.Columns["BoligID"].Visible = false;
            nyeBoliger.Columns["Adresse"].Visible = false;
            nyeBoliger.Columns["Postnummer"].Visible = false;
            nyeBoliger.Columns["BoligAreal"].Visible = false;
            nyeBoliger.Columns["GrundStørrelse"].Visible = false;
            nyeBoliger.Columns["EnergiMærke"].Visible = false;
            nyeBoliger.Columns["EjendomsmæglerID"].Visible = false;
            nyeBoliger.Columns["SælgerID"].Visible = false;
            nyeBoliger.Columns["Status"].Visible = false;
            nyeKøbere.DataSource = Data["tabel"][1];
            boligerBoligTypePlot.UserInputProcessor.IsEnabled = false;
            køberBoligTypePlot.UserInputProcessor.IsEnabled = false;
        }

        private void Forside_Resize(object sender, EventArgs e)
        {
            køberBoligTypePlot.Plot.Axes.AutoScale();
            boligerBoligTypePlot.Plot.Axes.AutoScale();
        }

        private void boligerLayoutPanel_Click(object sender, EventArgs e)
        {

        }

        private void nyeBoliger_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            DataGridViewRow selectedRow = nyeBoliger.Rows[e.RowIndex];
            BoligLogic boligLogic = new BoligLogic();
            DataTable datas = boligLogic.GetBoligDetails(Convert.ToInt32(selectedRow.Cells["BoligID"].Value));
            BoligDetaljer bd = new BoligDetaljer(datas);
            bd.Show();
        }
    }
}