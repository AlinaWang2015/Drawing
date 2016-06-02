using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Circle:Geometry
    {
        internal Circle () { }

        public Circle( List<Vertex> center, List<float> radius)
        {
            this.VertexBox = center;
            
            for(int i=0; i<center.Count;i++)
            {
                this.PartsBox[i] = 1;
            }
        }
    }
}
