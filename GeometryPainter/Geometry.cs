using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Geometry
    {
        private string id;
        private List<Vertex> vertexBox = new List<Vertex>();
        private List<int> partsBox = new List<int>();

        public string Id
        {
            get { return id; }

            protected set { id = value; }
        }

        public List<Vertex> VertexBox
        {
            get { return vertexBox; }

            protected set { vertexBox = value; }
        }

        public List<int> PartsBox
        {
            get { return partsBox; }

            protected set { partsBox = value; }
        }

        public Geometry() { }

        public Geometry(string id )
        {
            this.id = id;
            
        }

        public Geometry( string id, List<Vertex> verticesBox, List<int> partsBox)
        {
            this.Id = id;
            this.vertexBox = verticesBox;
            this.partsBox = partsBox;
        }
    }
}
