using System;
using GeometryPainter;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training
{
    public partial class DrawingBoard : Form
    {
        public DrawingBoard()
        {
            InitializeComponent();
        }

        public void Draw()
        {
            Painter painter = new Painter();
            Canvas canvas = new Canvas();
            Style style = new Style();

            painter.draw()

        }
    }
}
