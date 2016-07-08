using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class CircleGeometry:Geometry
    {
        private Vertex center;
        private double radius;

        public CircleGeometry()
        {
            Vertex center = new Vertex(0, 0);
            Id = "0";
            Center = center;
            Radius = 0;
        }

        public CircleGeometry(string id, Vertex center, double radius)
        {
            Id = id;
            Center = center;
            Radius = radius;
        }

        public Vertex Center
        {
            get { return center; }

            set { center = value; }
        }

        public double Radius
        {
            get { return radius; }

            set { radius = value; }
        }   
    }
}
