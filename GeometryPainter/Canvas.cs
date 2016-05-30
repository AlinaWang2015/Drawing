using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Canvas
    {
        private float width = 800;
        private float higth = 700;
        private Color background = Color.White;

        public float Width
        {
            get { return width; }

            set { width = value; }
        }

        public float Higth
        {
            get { return higth; }

            set { higth = value; }
        }

        public Color Background
        {
            get { return background; }

            set { background = value; }
        }

        public Canvas() { }

        public Canvas(Color background)
        {
            this.Background = background;
        }

        public Canvas(float width, float higth)
        {
            this.Width = width;
            this.Higth = Higth;
        }

        public Canvas(float width, float higth, Color background)
        {
            this.width = width;
            this.higth = higth;
            this.background = background;
        }
    }
}
