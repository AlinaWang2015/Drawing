using System.Drawing;

namespace GeometryPainter
{
    public class Canvas
    {
        private float width ;
        private float higth ;
        private Color background ;

        public Canvas()
        {
            Width = 400;
            Higth = 400;
            Background = Color.White;
        }

        public Canvas(Color background)
        {
            Width = 400;
            Higth = 400;
            Background = background;
        }

        public Canvas(float width, float higth)
        {
            Width = width;
            Higth = higth;
            Background = Color.White;
        }

        public Canvas(float width, float higth, Color background)
        {
            Width = width;
            Higth = Higth;
            Background = background;
        }

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

    }
}
