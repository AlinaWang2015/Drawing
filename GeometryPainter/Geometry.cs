using System.Collections.Generic;

namespace GeometryPainter
{
    public class Geometry
    {
        private string id;
        protected List<Vertex> vertexBox ;
        protected List<int> partsBox ;
        
        public Geometry()
        {
            Id = "0";
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }

        public Geometry(string id)
        {
            Id = id;
            partsBox = new List<int>();
            vertexBox = new List<Vertex>();
        }

        public string Id
        {
            get { return id; }
            protected set { id = value; }
        }

        public List<Vertex> GetVertexBox
        {
            get { return vertexBox; }
        }

        public List<int> GetPartsBox
        {
            get { return partsBox; }
        }
    }
}
