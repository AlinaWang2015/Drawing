using System.Drawing;
using System.Drawing.Drawing2D;

namespace GeometryPainter
{
    public static class Painter
    {
        public static Image CreateCanvas(Canvas canvas)
        {
            //show the canvas
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap originImg = new Bitmap(width, high);
            Graphics graphics = Graphics.FromImage(originImg);
            //set the canvas background   
            graphics.Clear(canvas.Background);
            Image finishImg = (Image)originImg.Clone();
            
            return finishImg;
        }

        public static Pen SetPen(Style style)
        {
            //set the pen
            Pen pen = new Pen(style.PenColor, style.BrushWidth);
            pen.DashStyle = DashStyle.Custom;
            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;

            return pen;
        }

        public static void DrawPoint( Pen pen, Image image, PointGeometry point)
        {
            Graphics graphics = Graphics.FromImage(image);
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

        public static void DrawPolyline(Pen pen, Image image, PolylineGeometry polyline)
        {
            Graphics graphics = Graphics.FromImage(image);
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

        public static void DrawPolygon(Pen pen, Image image, PolygonGeometry polygon)
        {
            Graphics graphics = Graphics.FromImage(image);
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

        public static void DrawCircle(Pen pen, Image image, CircleGeometry circle)
        {
            Graphics graphics = Graphics.FromImage(image);
            PointF center = new PointF((int)circle.Center.X, (int)circle.Center.Y);
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * circle.Radius, 2 * circle.Radius);
            
        }

        public static void DrawGeometry(Pen pen, Image image, Geometry geo)
        {
            
        }

    }
}
