using GeometryPainter;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charts
{
    public class RaderChart:Chart
    {
        private int maxRadiu;
        private int maxData;
        private int minData;
        private int circleCount;
        private List<string> series;
        private List<int> data;

        public RaderChart(int x, int y, int maxRadiu,int maxData, int minData, int circleCount, List<string> series, List<int> data)
        {
            X = x;
            Y = y;
            this.maxRadiu = maxRadiu;
            MaxData = maxData;
            MinData = minData;
            CircleCount = circleCount;
            Series = series;
            Data = data;
        }

        public int MaxRadiu
        {
            get { return maxRadiu; } 
            set { maxRadiu = value; }
        }

        public List<string> Series
        {
            get { return series; } 
            set { series = value; }
        }

        public int CircleCount
        {
            get { return circleCount; } 
            set { circleCount = value; }
        }

        public int MaxData
        {
            get { return maxData; } 
            set { maxData = value; }
        }

        public int MinData
        {
            get { return minData; } 
            set { minData = value; }
        }

        public void DrawRadarChart(Bitmap bitmap)
        {
            DrawConcentricCircles(bitmap);
            DrawSeries(bitmap);
            DrawDataLines(bitmap);
        }

        private void DrawConcentricCircles(Bitmap bitmap)
        {
            Style style = new Style();
            style.StyleColor = Color.Black;
            style.PenWidth = 1;
            int perRaius = MaxRadiu / circleCount;
            int temRadius = MaxRadiu;
            Vertex center1 = new Vertex(X, Y);
            for (int i = 0; i < CircleCount; i++)
            {
                CircleGeometry circle = new CircleGeometry("0", center1, temRadius);
                Painter.DrawCircle(style, bitmap, circle);
                temRadius -= perRaius;
            }
        }

        private void DrawSeries(Bitmap bitmap)
        {
            //Canvas canvas = new Canvas();
            Style style = new Style(Color.FromArgb(127,64,49));
            style.PenWidth = 2;

            Vertex startPoint = new Vertex(X, Y);

            float angle = 0;
            float perAngle = 360 / Series.Count;

            for (int i = 0; i < Series.Count; i++)
            {
                int temX = (int)(MaxRadiu * Math.Cos(angle * Math.PI / 180) + X);
                int temY = (int)(MaxRadiu * Math.Sin(angle * Math.PI / 180) + Y);
                Vertex endPoint = new Vertex(temX, temY);
                Vertex textPoint = endPoint;
                Painter.DrawPolyline(style, bitmap, startPoint, textPoint);

                if (angle == 270)
                {
                    textPoint.Y -= TextRenderer.MeasureText(Series[i], new Font("Tahoma", 12)).Height;
                    Painter.DrawText(style, bitmap, Series[i], textPoint);
                }
                else if (angle < 270 && angle > 90)
                {
                    textPoint.X -= TextRenderer.MeasureText(Series[i], new Font("Tahoma", 12)).Width;
                    Painter.DrawText(style, bitmap, Series[i], textPoint);
                }
                else
                {
                    textPoint.X += 8;
                    Painter.DrawText(style, bitmap, Series[i], textPoint);
                }
                angle += perAngle;
                angle %= 360;

            }
        }

        private void DrawDataLines(Bitmap bitmap)
        {
            PolygonGeometry polygon = new PolygonGeometry("1");
            float angle = 0;
            float perAngle = 360 / Data.Count;
            Vertex temPoint = new Vertex();

            for (int i = 0; i < Data.Count; i++)
            {

                double r = MaxRadiu * (Data[i] - MinData) / (MaxData - MinData);
                int temX = (int)(r * Math.Cos(angle * Math.PI / 180) + X);
                int temY = (int)(r * Math.Sin(angle * Math.PI / 180) + Y);
                Vertex point = new Vertex(temX, temY);
                if (i == 0)
                {
                    temPoint = point;
                }
                angle += perAngle;
                angle %= 360;
                polygon.GetVertexBox.Add(point);
            }
            polygon.GetPartsBox.Add(6);
            Style style = new Style(Color.Green,3,true, Color.FromArgb(162,180,132,77));
            Painter.DrawPolygon(style, bitmap, polygon);
        }
    }
}
