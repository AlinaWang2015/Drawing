using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Polyline : Geometry
    {
        internal Polyline() { }

        public Polyline(string id, List<Vertex> verticesBox, List<int> partsBox)
        {
            this.Id = id;
            this.VertexBox = verticesBox;
            this.PartsBox = partsBox;
        }
    }
}
