using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryPainter
{
    public class Vertex
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

        public Vertex() { }

        public Vertex(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
