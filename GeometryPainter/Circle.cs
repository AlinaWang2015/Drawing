using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Circle:Geometry
    {
        private Vertex center;
        private float radius;

        internal Circle () { }

        public Vertex Center
        {
            get { return center; }

            set { center = value; }
        }

        public float Radius
        {
            get { return radius; }

            set { radius = value; }
        }

        public Circle( List<Vertex> center, List<float> radius)
        {
            this.VertexBox = center;
            

        }

        public Circle(Vertex center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }
    }
}
