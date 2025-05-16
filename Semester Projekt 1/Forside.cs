using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot;
using ScottPlot.Colormaps;
using ScottPlot.Plottables;
using ScottPlot.WinForms;
using Semester_Projekt_1;

namespace Semester_Projekt_1
{
    public partial class Forside : Form
    {
        public Forside()
        {
            InitializeComponent();
        }

        private void statBoxesLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadPieKøber()
        {
            List<PieSlice> slices = [
                new PieSlice() {Value=2, FillColor = Colors.Red,LegendText = "Villa"},
                new PieSlice() {Value=4, FillColor = Colors.Green,LegendText = "Lejlighed"},
                new PieSlice() {Value=14, FillColor = Colors.Black,LegendText = "Rækkehus"},
                new PieSlice() {Value=1, FillColor = Colors.Blue,LegendText = "Andelsbolig"},
                new PieSlice() {Value=12, FillColor = Colors.Brown,LegendText = "Ejerlejlighed"},
                new PieSlice() {Value=6, FillColor = Colors.Aqua,LegendText = "Sommerhus"},
                new PieSlice() {Value=5, FillColor = Colors.Purple,LegendText = "Ungdomsbolig"},
                new PieSlice() {Value=9, FillColor = Colors.Maroon,LegendText = "Ældrebolig"},
                new PieSlice() {Value=8, FillColor = Colors.Indigo,LegendText = "Kolonihavehus"},
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
                new() {Position=1,ValueBase=0,FillColor = Colors.Red,Value=1},
                new() {Position=2,ValueBase=0,FillColor = Colors.Green,Value=2},
                new() {Position=3,ValueBase=0,FillColor = Colors.Black,Value=3},
                new() {Position=4,ValueBase=0,FillColor = Colors.Blue,Value=4},
                new() {Position=5,ValueBase=0,FillColor = Colors.Brown,Value=5},
                new() {Position=6,ValueBase=0,FillColor = Colors.Aqua,Value=6},
                new() {Position=7,ValueBase=0,FillColor = Colors.Purple,Value=7},
                new() {Position=8,ValueBase=0,FillColor = Colors.Maroon,Value=8},
                new() {Position=9,ValueBase=0,FillColor = Colors.Indigo,Value=9}
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
            boligerBoligTypePlot.Plot.Title("Usolgte Boliger Fodelt på BoligTypen");
            boligerBoligTypePlot.Refresh();
        }
        
        private void Forside_Load(object sender, EventArgs e)
        {
            loadPieKøber();
            loadBar();
        }

        private void Forside_Resize(object sender, EventArgs e)
        {
            køberBoligTypePlot.Plot.Axes.AutoScale();
            boligerBoligTypePlot.Plot.Axes.AutoScale();
        }
    }
}