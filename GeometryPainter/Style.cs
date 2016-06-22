using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Style
    {
        private Color penColor = Color.Black;
        private float penWidth = 100;
        private bool isFill = false;

        public Color PenColor
        {
            get { return penColor; }

            set { penColor = value; }
        }

        public float BrushWidth
        {
            get
            {
                return penWidth;
            }

            set
            {
                penWidth = value;
            }
        }

        public bool IsFill
        {
            get
            {
                return isFill;
            }

            set
            {
                isFill = value;
            }
        }

        public Style () { }

        public Style(Color burushColor, float brushWidth, bool isFill)
        {
            this.penColor = burushColor;
            this.penWidth = brushWidth;
            this.isFill = isFill;
        }
    }
}
