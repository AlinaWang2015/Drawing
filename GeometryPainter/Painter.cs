using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public static class Painter
    {
        public static void DrawPoint( Style style, Canvas canvas, Point point)
        {

            //show the canvas
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap originImg = new Bitmap(width, high);
            Graphics graphics = Graphics.FromImage(originImg);

            //set the canvas background   
            graphics.Clear(canvas.Background);
            Image finishImg = (Image)originImg.Clone();

            //set the pen
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            for(int i=0;i<point.PartsBox.Count;i++)
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

        public static void DrawPolyline(Style style, Canvas canvas, Polyline polyline)
        {
            //show the canvas
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap originImg = new Bitmap(width, high);
            Graphics graphics = Graphics.FromImage(originImg);

            //set the canvas background   
            graphics.Clear(canvas.Background);
           // Image finishImg = (Image)originImg.Clone();

            //set the pen
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

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

        public static void DrawPolygon(Style style, Canvas canvas, Polygon polygon)
        {
            //show the canvas
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap originImg = new Bitmap(width, high);
            Graphics graphics = Graphics.FromImage(originImg);

            //set the canvas background   
            graphics.Clear(canvas.Background);
            Image finishImg = (Image)originImg.Clone();

            //set the pen
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;


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

        public static void DrawCircle(Style style, Canvas canvas, Circle circle)
        {
            //show the canvas
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap originImg = new Bitmap(width, high);
            Graphics graphics = Graphics.FromImage(originImg);

            //set the canvas background   
            graphics.Clear(canvas.Background);
            Image finishImg = (Image)originImg.Clone();

            //set the pen
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;

            PointF center = new PointF(circle.Center.X, circle.Center.Y);
            //float temX = (center.X - points[1].X) * (center.X - points[1].X);
            //float temY = (center.Y - points[1].Y) * (center.Y - points[1].Y);
            //float radius = (float)Math.Sqrt(temX + temY);
            
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * circle.Radius, 2 * circle.Radius);
            
        }



    }
}
