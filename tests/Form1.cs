using System;
using GeometryPainter;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace tests
{
    public partial class Form1 : Form
    {
        Canvas canvas = new Canvas();
        Style style = new Style();
        Image g;
        Pen p;

        public Form1()
        {
            InitializeComponent();
            Canvas canvas = new Canvas();
            //g = Painter.CreateCanvas(canvas);
            p = Painter.SetPen(style);
            pictureBox1.Image = g;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Vertex> verticesBox = new List<Vertex>();
            var v1 = new Vertex(102, 101);
            var v2 = new Vertex(0, 214);
            var v3 = new Vertex(27, 21);
            verticesBox.Add(v1); verticesBox.Add(v2); verticesBox.Add(v3);

            List<int> partsBox = new List<int>();
            partsBox.Add(3);



            GeometryPainter.PolylineGeometry polyline = new GeometryPainter.PolylineGeometry("1");
            polyline.GetVertexBox.Add(v1); polyline.GetVertexBox.Add(v2); polyline.GetVertexBox.Add(v3);
            
            //Painter.DrawPolyline(p, g, polyline);
            g.Save(@"c：\1\2.png");
        }
    }
}
