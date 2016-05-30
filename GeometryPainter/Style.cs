using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryPainter
{
    public class Style
    {
        private Color burushColor = Color.Black;
        private float brushWidth = 100;
        private bool isFill = false;

        public Color BurushColor
        {
            get { return burushColor; }

            set { burushColor = value; }
        }

        public float BrushWidth
        {
            get
            {
                return brushWidth;
            }

            set
            {
                brushWidth = value;
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
            this.burushColor = burushColor;
            this.brushWidth = brushWidth;
            this.isFill = isFill;
        }
    }
}
