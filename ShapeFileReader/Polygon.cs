using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class Polygon:Geometry
    {
        public Polygon() { }

        public Polygon(List<int> parts, List<Point> points)
        {
            this.Parts = parts;
            this.Points = points;
        }
    }
}
