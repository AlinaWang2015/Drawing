using System.Drawing;

namespace GeometryPainter
{
    public class Canvas
    {
        private int width ;
        private int higth ;
        private Color background ;

        public Canvas()
        {
            Width = 400;
            Higth = 400;
            Background = Color.GreenYellow;
        }

        public Canvas(Color background)
        {
            Width = 400;
            Higth = 400;
            Background = background;
        }

        public Canvas(int width, int higth)
        {
            Width = width;
            Higth = higth;
            Background = Color.White;
        }

        public Canvas(int width, float higth, Color background)
        {
            Width = width;
            Higth = Higth;
            Background = background;
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Higth
        {
            get { return higth; }
            set { higth = value; }
        }

        public Color Background
        {
            get { return background; }
            set { background = value; }
        }

        public Bitmap GetCanvas()
        {
            //show the canvas
            Bitmap originImg = new Bitmap(Width, Higth);
            Graphics graphics = Graphics.FromImage(originImg);
            //set the canvas background   
            graphics.Clear(Background);
            //Image finishImg = (Image)originImg.Clone();
            //originImg.Save(@"c:\1\2.jpg");
            return originImg;
        }
    }
}
