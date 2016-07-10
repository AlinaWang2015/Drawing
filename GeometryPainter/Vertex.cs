using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeometryPainter
{
    public struct Vertex
    {
        private int x;
        private int y;

        public Vertex(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        public int Y
        {
            get { return y; }
            private set { y = value; }
        }

        public override int GetHashCode()
        {
            return (int)X ^ (int)Y;
        }

        public override bool Equals(object obj)
        {
            Vertex otherVertex = (Vertex)obj;
            if (otherVertex.X == X && otherVertex.Y == Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Vertex v1, Vertex v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Vertex v1, Vertex v2)
        {
            return !v1.Equals(v2);
        }

        public override string ToString()
        {
            return ToString("G");
        }

        public string ToString(string format)
        {
            if (string.IsNullOrEmpty(format))
                format = "G";

            switch(format.ToUpperInvariant())
            {
                case "G":
                    return string.Format("this vertex's coordinate is '{0}' and '{1}' ", x, y);
                case "D":
                    return string.Format("this vertex's coordinate is '{0}' and '{1}' ", x.ToString("D"), y.ToString("D"));
                case "F":
                    return string.Format("this vertex's coordinate is '{0}' and '{1}' ", x.ToString("F"), y.ToString("F"));
                default:
                    string message = string.Format("'{0}' is an invalid format string", format);
                    throw new ArgumentException(message);
            }
        }
    }
}
