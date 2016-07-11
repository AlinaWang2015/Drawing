using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeometryPainter
{
    public static class Painter
    {
        //public static Image CreateCanvas(Canvas canvas)
        //{
        //    //show the canvas
        //    int width = (int)canvas.Width;
        //    int high = (int)canvas.Higth;
        //    Bitmap originImg = new Bitmap(width, high);
        //    Graphics graphics = Graphics.FromImage(originImg);
        //    //set the canvas background   
        //    graphics.Clear(canvas.Background);
        //    Image finishImg = (Image)originImg.Clone();
            
        //    return finishImg;
        //}

        public static Pen SetPen(Style style)
        {
            //set the pen
            Pen pen = new Pen(style.PenColor, style.BrushWidth);
            pen.DashStyle = DashStyle.Custom;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
            return pen;
        }

        public static void DrawPoint(Style style, Canvas canvas, PointGeometry point)
        {
            Image image = canvas.GetCanvas();
            Graphics graphics = Graphics.FromImage(image);
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

        public static void DrawPolyline(Style style, Canvas canvas, PolylineGeometry polyline)
        {
            Bitmap image = canvas.GetCanvas();
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = SetPen(style);
            for (int i = 0; i < polyline.GetPartsBox.Count; i++)
            {
                PointF[] tempoints = new PointF[polyline.GetPartsBox[i]];
                for (int j = 0; j < polyline.GetPartsBox[i]; j++)
                {
                    PointF tempoint = new PointF(polyline.GetVertexBox[j].X, polyline.GetVertexBox[j].Y);
                    tempoints[j] = tempoint;
                }
                graphics.DrawLines(pen,tempoints);
            }
            
        }

        public static void DrawPolygon(Style style, Canvas canvas, PolygonGeometry polygon)
        {
            Image image = canvas.GetCanvas();
            Graphics graphics = Graphics.FromImage(image);
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

        public static void DrawCircle(Style style, Canvas canvas, CircleGeometry circle)
        {
            Bitmap image = canvas.GetCanvas();
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = new Pen (Color.Red);
            PointF center = new PointF(circle.Center.X, circle.Center.Y);
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * circle.Radius, 2 * circle.Radius);
            
        }

        public static void Drawpie(Style style, Canvas canvas, PieGeometry pie)
        {
            Image image = canvas.GetCanvas();
            Graphics graphics = Graphics.FromImage(image);
            Pen pen = SetPen(style);
            graphics.DrawPie(pen, pie.Center.X, pie.Center.Y, pie.Width, pie.Height, pie.StartAngle, pie.SweepAngle);
        }


    }
}
