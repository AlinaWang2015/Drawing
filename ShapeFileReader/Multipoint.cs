using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class Multipoint:Geometry
    {
        public Multipoint() { }

        public Multipoint(List<Point> points)
        {
            this.Points = points;
        }
    }
}
