using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Painter
    {
        public Painter () { }

        protected void DrawPoint(Style style, Canvas canvas, PointF point)
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

            graphics.DrawLine(pen, point, point);
        }

        protected void DrawPolyline(Style style, Canvas canvas, List<Vertex> points)
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
            
            PointF startpoint = new PointF(points[0].X, points[0].Y);
            PointF endpoint = new PointF(points[1].X, points[1].Y);

            graphics.DrawLine(pen, startpoint, endpoint);
        }

        protected void DrawPolygon(Style style, Canvas canvas, List<Vertex> points)
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


            PointF[] tempoint = new PointF[points.Count];
            for(int i=0; i<points.Count; i++)
            {
                tempoint[i] = new PointF(points[i].X,points[i].Y);
            }
            
            graphics.DrawPolygon(pen, tempoint);
        }

        protected void DrawCircle (Style style, Canvas canvas, float x, float y, float radius)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);

            gc.DrawEllipse(pen, x, y, 2*radius, 2*radius);
        }

        protected void DrawCircle(Style style, Canvas canvas, List<Vertex> points)
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

            PointF center = new PointF(points[0].X, points[0].Y);
            float temX = (center.X - points[1].X) * (center.X - points[1].X);
            float temY = (center.Y - points[1].Y) * (center.Y - points[1].Y);
            float radius =(float) Math.Sqrt(temX + temY);
            
            
            graphics.DrawEllipse(pen, center.X, center.Y, 2 * radius, 2 * radius);
        }

        public void Draw(Style style,Canvas canvas, Geometry geometry)
        {
            

            ShapeType type = ShapeType.Point; var sht = geometry.GetType();
            ShapeType po = sht;
            
            switch (type)
            {
                case 1:
                    DrawPoint(geometry.VertexBox,geometry.PartsBox);
                    break;
                case 2:
                    DrawCircle(geometry.VertexBox);
                    break;
                case 3:
                    DrawPolyline(geometry.VertexBox);
                    break;
                case 5:
                    DrawPolygon( geometry.VertexBox);
                    break;
                
                default:
                    break;
            }
        }
    }
}
