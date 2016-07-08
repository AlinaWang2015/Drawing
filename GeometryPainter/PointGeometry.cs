using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class PointGeometry : Geometry
    {
        public PointGeometry()
        {
            Id = "0";
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }

        public PointGeometry(string id)
        {

            Geometry geo = new Geometry(id);
        }

    }
}
