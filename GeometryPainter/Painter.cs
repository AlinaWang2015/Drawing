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
            //pen.StartCap = LineCap.Round;
            //pen.EndCap = LineCap.Round;

            return pen;
        }

        public static void DrawPoint( Pen pen, Image image, Point point)
        {
            Graphics graphics = Graphics.FromImage(image);
            for (int i=0;i<point.PartsBox.Count;i++)
            {
                for(int j=0;j<point.PartsBox[i];j++)
                {
                    float x = point.VertexBox[j].X;
                    float y = point.VertexBox[j].Y;
                    PointF tempoint =new PointF(x,y);

                    graphics.DrawLine(pen, tempoint, tempoint);
                }
            }
            
        }

        public static void DrawPolyline(Pen pen, Image image, Polyline polyline)
        {
            Graphics graphics = Graphics.FromImage(image);
            for (int i = 0; i < polyline.PartsBox.Count; i++)
            {
                PointF[] tempoints = new PointF[polyline.PartsBox[i]];
                for (int j = 0; j < polyline.PartsBox[i]; j++)
                {
                    PointF tempoint = new PointF(polyline.VertexBox[j].X, polyline.VertexBox[j].Y);
                    tempoints[j] = tempoint;
                }

                graphics.DrawLines(pen,tempoints);
            }
            
        }

        public static void DrawPolygon(Pen pen, Image image, Polygon polygon)
        {
            Graphics graphics = Graphics.FromImage(image);
            for (int i = 0; i < polygon.PartsBox.Count; i++)
            {
                PointF[] tempoints = new PointF[polygon.PartsBox[i]];
                for (int j = 0; j < polygon.PartsBox[i]; j++)
                {
                    PointF tempoint = new PointF(polygon.VertexBox[j].X, polygon.VertexBox[j].Y);
                    tempoints[j] = tempoint;
                }

                graphics.DrawPolygon (pen, tempoints);
            }
        }

        public static void DrawCircle(Pen pen, Image image, Circle circle)
        {
            Graphics graphics = Graphics.FromImage(image);
            PointF center = new PointF(circle.Center.X, circle.Center.Y);
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * circle.Radius, 2 * circle.Radius);
            
        }

        public static void DrawGeometry(Pen pen, Image image, Geometry geo)
        {
            
        }

    }
}
