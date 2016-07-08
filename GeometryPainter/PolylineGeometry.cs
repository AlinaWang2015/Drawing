using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class PolylineGeometry : Geometry
    {
        public PolylineGeometry()
        {
            Id = "0";
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }

        public PolylineGeometry(string id)
        {
            Id = id;
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }
    }
}
