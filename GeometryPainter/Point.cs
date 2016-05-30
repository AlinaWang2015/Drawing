using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Point : Geometry
    {
        private float x;
        private float y;

        public float X
        {
            get { return x; }

            set { x = value; }
        }

        public float Y
        {
            get { return y; }

            set { y = value; }
        }

        public Point() { }

        public Point(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

    }
}
