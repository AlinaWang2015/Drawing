using System.Drawing;

namespace GeometryPainter
{
    public class Style
    {
        private Color penColor ;
        private float penWidth ;
        private bool isFill ;
        private bool isSolidLine;

        public Style()
        {
            PenColor = Color.Red;
            BrushWidth = 10;
            IsFill = false;
            IsSolidLine = true;
        }

        public Style(Color penColor, float penWidth, bool isFill)
        {
            PenColor = penColor;
            BrushWidth = penWidth;
            IsFill = isFill;
            IsSolidLine = true;
        }

        public Style(Color penColor, float penWidth, bool isFill, bool isSolidLine)
        {
            this.penColor = penColor;
            this.penWidth = penWidth;
            this.isFill = isFill;
            this.isSolidLine = isSolidLine;
        }

        public Color PenColor
        {
            get { return penColor; }
            private set { penColor = value; }
        }

        public float BrushWidth
        {
            get { return penWidth; }
            private set { penWidth = value; }
        }

        public bool IsFill
        {
            get { return isFill; }
            private set { isFill = value; }
        }

        public bool IsSolidLine
        {
            get { return isSolidLine; }

            set { isSolidLine = value; }
        }
    }
}
