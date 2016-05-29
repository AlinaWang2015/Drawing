using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class Polyline:Geometry
    {
        public Polyline() { }

        public Polyline(List<int> parts, List<Point> points)
        {
            this.Parts = parts;
            this.Points = points;
        }
    }
}
