using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Point : Geometry
    {
        internal Point() { }

        public Point(string id, List<Vertex> verticesBox, List<int> partsBox)
        {
            this.Id = id;
            this.VertexBox = verticesBox;
            this.PartsBox = partsBox;
        }

    }
}
