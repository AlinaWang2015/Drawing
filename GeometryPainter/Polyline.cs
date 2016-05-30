using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Polyline : Geometry
    {
        private List<Point> verticesBox = new List<Point> ();
        private List<int> partsBox = new List<int> ();

        public List<Point> VerticesBox
        {
            get { return verticesBox; }

            set { verticesBox = value; }
        }

        public List<int> PartsBox
        {
            get { return partsBox; }

            set { partsBox = value; }
        }

        public Polyline() { }

        public Polyline(List<Point> verticesBox, List<int> partsBox)
        {
            this.verticesBox = verticesBox;
            this.partsBox = partsBox;
        }
    }
}
