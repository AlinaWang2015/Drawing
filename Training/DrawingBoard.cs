using System;
using GeometryPainter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class DrawingBoard : Form
    {
        public DrawingBoard()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Painter painter = new Painter();
            Canvas canvas = new Canvas();
            Style style = new Style();

            //painter.draw(style,canvas,shapetype,points);

        }

        // draw the point
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = this.CreateGraphics();
            Painter painter = new Painter();
            Canvas canvas = new Canvas();
            Style style = new Style();
            Geometry shapetype = new Geometry();
            //shapetype.GeometryType = 1;
                
           // painter.draw(style, canvas, shapetype, points);
        }
    }
}
