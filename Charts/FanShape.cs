using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GeometryPainter;
using System.Threading.Tasks;
using System.Drawing;

namespace Charts
{
    public class FanShape
    {
        private int x;
        private int y;
        private float width;
        private float height;
        private float startAngle;
        private float sweepAngle;

        public FanShape()
        {
            X = 0;
            Y = 0;
            this.width = 0;
            this.height = 0;
            this.startAngle = 0;
            this.sweepAngle = 0;
        }
        

        public FanShape(int x, int y, float width, float height, float startAngle, float sweepAngle)
        {
            X = x;
            Y = y;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        public float Height
        {
            get { return height; }
            set { height = value; }
        }

        public float StartAngle
        {
            get { return startAngle; }
            set { startAngle = value; }
        }

        public float SweepAngle
        {
            get { return sweepAngle; }
            set { sweepAngle = value; }
        }

        public void DrawFanShaped(Bitmap bitmap,Style style)
        {
            Vertex center1 = new Vertex(X, Y);
            PieGeometry pie = new PieGeometry(center1, Width, Height, startAngle, SweepAngle);
            Painter.Drawpie(style, bitmap, pie);
        }
    }
}
