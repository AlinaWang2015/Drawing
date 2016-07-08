using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class PolygonGeometry : Geometry
    {
        public PolygonGeometry()
        {
            Id = "0";
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }

        public PolygonGeometry (string id)
        {
            Id = id;
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }
    }
}
