using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeometryPainter
{
    public static class Painter
    {
        public static Pen SetPen(Style style)
        {
            //set the pen
            Pen pen = new Pen(style.PenColor, style.BrushWidth);
            pen.DashStyle = DashStyle.Custom;
            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;
            return pen;
        }

        public static void DrawPoint( Canvas canvas,Style style, PointGeometry point)
        {
            //Bitmap originImg = new Bitmap(canvas.Width, canvas.Higth);
            Graphics graphics = canvas.GetCanvas();
            Pen pen = SetPen(style);
            for (int i=0;i<point.GetPartsBox.Count;i++)
            {
                for(int j=0;j<point.GetPartsBox[i];j++)
                {
                    double x = point.GetVertexBox[j].X;
                    double y = point.GetVertexBox[j].Y;
                    PointF tempoint =new PointF((int)x, (int)y);

                    graphics.DrawLine(pen, tempoint, tempoint);
                }
            }
            
        }

        public static void DrawPolyline(Canvas canvas, Style style, PolylineGeometry polyline)
        {
            Graphics graphics = canvas.GetCanvas();
            Pen pen = SetPen(style);
            for (int i = 0; i < polyline.GetPartsBox.Count; i++)
            {
                PointF[] tempoints = new PointF[polyline.GetPartsBox[i]];
                for (int j = 0; j < polyline.GetPartsBox[i]; j++)
                {
                    PointF tempoint = new PointF((int)polyline.GetVertexBox[j].X, (int)polyline.GetVertexBox[j].Y);
                    tempoints[j] = tempoint;
                }

                graphics.DrawLines(pen,tempoints);
            }
            
        }

        public static void DrawPolygon(Canvas canvas, Style style, PolygonGeometry polygon)
        {
            Graphics graphics = canvas.GetCanvas();
            Pen pen = SetPen(style);
            for (int i = 0; i < polygon.GetPartsBox.Count; i++)
            {
                PointF[] tempoints = new PointF[polygon.GetPartsBox[i]];
                for (int j = 0; j < polygon.GetPartsBox[i]; j++)
                {
                    PointF tempoint = new PointF((int)polygon.GetVertexBox[j].X, (int)polygon.GetVertexBox[j].Y);
                    tempoints[j] = tempoint;
                }

                graphics.DrawPolygon (pen, tempoints);
            }
        }

        public static void DrawCircle(Canvas canvas, Style style, CircleGeometry circle)
        {
            Graphics graphics = canvas.GetCanvas();
            Pen pen = SetPen(style);
            PointF center = new PointF((int)circle.Center.X, (int)circle.Center.Y);
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * circle.Radius, 2 * circle.Radius);
            
        }

        public static void DrawPie(Canvas canvas, Style style, PieArc pie)
        {
            Graphics graphics = canvas.GetCanvas();
            Pen pen = SetPen(style);
            graphics.DrawPie(pen,pie.Center.X,pie.Center.Y,pie.Width,pie.Height,pie.StartAngle,pie.SweepAngle);
        }

    }
}
