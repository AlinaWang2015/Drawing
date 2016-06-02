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

        protected void DrawPoint(Style style, Bitmap canvas, PointF point)
        {
            
            Graphics gc = Graphics.FromImage(bitmap);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);

            gc.DrawLine(pen, point, point);
        }

        protected void DrawPoint (Style style, Canvas canvas, float x,float y)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            PointF point = new PointF (x,y);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);

            gc.DrawLine(pen, point, point);
        }

        protected void DrawPolyline(Style style, Canvas canvas, List<Point> points)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            PointF startpoint = new PointF(points[0].X, points[0].Y);
            PointF endpoint = new PointF(points[1].X, points[1].Y);

            gc.DrawLine(pen, startpoint, endpoint);
        }

        protected void DrawPolyline(Style style, Canvas canvas, float x1, float y1, float x2, float y2)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            
            gc.DrawLine(pen,x1,y1,x2,y2);
        }

        protected void DrawPolygon(Style style, Canvas canvas, List<Point> points)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            PointF[] tempoint = new PointF[points.Count];
            for(int i=0; i<points.Count; i++)
            {
                tempoint[i] = new PointF(points[i].X,points[i].Y);
            }
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            
            gc.DrawPolygon(pen, tempoint);
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

        protected void DrawCircle(Style style, Canvas canvas, List<Point> points)
        {
            int width = (int)canvas.Width;
            int high = (int)canvas.Higth;
            Bitmap bitmap = new Bitmap(width, high);
            Graphics gc = Graphics.FromImage(bitmap);
            PointF center = new PointF(points[0].X, points[0].Y);
            float temX = (center.X - points[1].X) * (center.X - points[1].X);
            float temY = (center.Y - points[1].Y) * (center.Y - points[1].Y);
            float radius =(float) Math.Sqrt(temX + temY);
            Pen pen = new Pen(style.BurushColor, style.BrushWidth);
            
            gc.DrawEllipse(pen, center.X, center.Y, 2 * radius, 2 * radius);
        }

        public void Draw(Style style,Canvas canvas, Geometry geometry)
        {
            switch(typeof())
            {
                case 1:
                    PointF point = new PointF(geometry.VertexBox[0].X, geometry.VertexBox[0].Y);
                    DrawPoint(style, canvas, point);
                    break;
                case 3:
                    DrawPolyline(style,canvas, geometry.VertexBox);
                    break;
                case 5:
                    DrawPolygon(style, canvas, geometry.VertexBox);
                    break;
                case 6:
                    DrawCircle(style, canvas, geometry.VertexBox);
                    break;
                default:
                    break;
            }
        }
    }
}
