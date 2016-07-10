using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryPainter
{
    public class PieArc
    {
        private Vertex center;
        private float width;
        private float height;
        private float startAngle;
        private float sweepAngle;

        public PieArc()
        {
            this.center = new Vertex(); ;
            this.width = 0;
            this.height = 0;
            this.startAngle = 0;
            this.sweepAngle = 0;
        }

        public PieArc(Vertex center, float width, float height, float startAngle, float sweepAngle)
        {
            this.center = center;
            this.width = width;
            this.height = height;
            this.startAngle = startAngle;
            this.sweepAngle = sweepAngle;
        }

        public float Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public float Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public float StartAngle
        {
            get
            {
                return startAngle;
            }

            set
            {
                startAngle = value;
            }
        }

        public float SweepAngle
        {
            get
            {
                return sweepAngle;
            }

            set
            {
                sweepAngle = value;
            }
        }

        public Vertex Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }
    }
}
