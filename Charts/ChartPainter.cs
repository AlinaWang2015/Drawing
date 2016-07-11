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

        public static void DrawPieChart(PieChart piechart)
        {
            Canvas canvas = new Canvas();
            Style style = new Style();
            Vertex center = new Vertex(300, 300);

            float sumData = 0;
            float currentAngle = 0;
            float totalAngle = 0;
            foreach (var itemData in piechart.Data)
            {
                sumData += itemData;
            }

            for (int i = 0; i < piechart.Data.Count; i++)
            {
                currentAngle = Convert.ToSingle(piechart.Data[i] / sumData * 360);
                PieGeometry pie = new PieGeometry(center, 400, 400, totalAngle, currentAngle);
                totalAngle += currentAngle;
                Painter.Drawpie(style, canvas, pie);
            }


        }
    }
}
