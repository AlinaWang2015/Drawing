using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Painter
    {
        public Painter () { }

        protected void DrawPoint(Style style, Canvas canvas, List<Point> points)
        {
            Graphics gc = null;
            foreach (var point in points)
            {
                po
            }
        }

        protected void DrawPolyline(Style style, Canvas canvas, List<Point> points)
        {
            Graphics gc = null;

            foreach (var point in points)
            {
               point.X = (float)((point.X - pg.HBoundingBox[0]) / (pg.HBoundingBox[2] - pg.HBoundingBox[0]) * this.panel.Width);
               point.Y = (float)((pg.HBoundingBox[3] - point.Y) / (pg.HBoundingBox[3] - pg.HBoundingBox[1]) * this.panel.Height);
            }

            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            Point[] temPoints = points.ToArray();
            gc.DrawPolygon(pen,temPoints);
        }

        public void draw(Style style,Canvas canvas, Geometry geometry)
        {
            switch(geometry.GeometryType)
            {
                case 1:
                    break;
                case 3:
                    DrawPolyline(style,canvas,geometry.Points);
                    break;

            }
        }
    }
}
