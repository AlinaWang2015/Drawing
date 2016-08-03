using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryPainter;
using Charts;
using System.Windows.Forms;

namespace TestLibraryC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Canvas canvas = new Canvas();
            //Style style = new Style();
            //PieChart piechart = new PieChart();
            //ChartPainter.DrawPieChart(canvas, style, piechart);

            Graphics ghs = this.CreateGraphics();
            Pen mypen = new Pen(Color.Black, 3);
            ghs.DrawPie(mypen, 50, 50, 100, 100, 80, 50);
            ghs.DrawEllipse(mypen, 50, 50, 100, 100);
        }
    }
}
