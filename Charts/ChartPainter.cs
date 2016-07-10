using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryPainter;
using static System.Net.Mime.MediaTypeNames;

namespace Charts
{
    public static class ChartPainter
    {
        public static void DrawPieChart(Canvas canvas, Style style, PieChart piechart)
        {
            
            //Pen pen = Painter.SetPen(style);
            Vertex center = new Vertex(300, 300);
            //CircleGeometry circle = new CircleGeometry("1",center, piechart.Radius);
            //CircleGeometry innerCircle = new CircleGeometry("2",center,piechart.Radius-20);
            PieArc pie = new PieArc(center, 50, 50, 100, 100);
            Painter.DrawPie(canvas, style, pie);
            //Painter.DrawCircle( pen, tu, innerCircle);
            //Painter.DrawCircle( pen, tu, circle);
        }
    }
}
