using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryPainter
{
    public class ArcGeometer
    {
        private Vertex center;
        private int radius;
        private int startAngle;
        private int endAngle;

        public ArcGeometer ()
        {
            center = new Vertex();
            radius = 0;
            startAngle = 0;
            endAngle = 0;
        }

        public ArcGeometer(Vertex center, int radius, int startPoint, int endPoint)
        {
            this.center = center;
            this.radius = radius;
            this.startAngle = startPoint;
            this.endAngle = endPoint;
        }

        public Vertex Center
        {
            get { return center; }
            set { center = value; }
        }

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public int StartAngle
        {
            get { return startAngle; }
            set { startAngle = value; }
        }

        public int EndAngle
        {
            get { return endAngle; }
            set { endAngle = value; }
        }
    }
}
