using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Circle:Geometry
    {
        private Point center;
        private float radius;

        public Point Center
        {
            get { return center; }

            set { center = value; }
        }

        public float Radius
        {
            get { return radius; }

            set { radius = value; }
        }

        public Circle() { }

        public Circle(Point center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle(float x,float y,float radius)
        {
            Point center = new Point(x, y);
            this.center = center;
            this.radius = radius;
        }
    }
}
