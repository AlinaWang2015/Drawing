using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charts
{
    public class Chart
    {
        private int type;
        private string name;
        private List<int> data;
        private int x;
        private int y;

        public Chart() { }

        public Chart(int type, string name, List<int> data, int x,int y)
        {
            this.type = type;
            this.name = name;
            this.data = data;
            X = x;
            Y = y;
        }

        public int Type
        {
            get { return type; } 
            set { type = value; }
        }

        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        public List<int> Data
        {
            get { return data; } 
            set { data = value; }
        }

        public int X
        {
            get { return x; } 
            set { x = value; }
        }

        public int Y
        {
            get { return y; } 
            set { y = value; }
        }

        protected void DrawIllustration( )
        {
            //graphics.DrawRectangle(new Pen(style.PenColor, 2), 200, 300, 199, 99);
            //graphics.DrawString("图表说明", new Font("Tahoma", 12), Brushes.Black, new PointF(7, 35));
        }

        protected Color GetItemColor(int item)
        {
            Color select = Color.Gold;
            switch (item)
            {
                case 0:
                    select = Color.Aqua;
                    break;
                case 1:
                    select = Color.Red;
                    break;
                case 2:
                    select = Color.Blue;
                    break;
                case 3:
                    select = Color.Yellow;
                    break;
                case 4:
                    select = Color.Green;
                    break;
                case 5:
                    select = Color.BurlyWood;
                    break;
                case 6:
                    select = Color.Pink;
                    break;
                case 7:
                    select = Color.Plum;
                    break;
                case 8:
                    select = Color.YellowGreen;
                    break;
                case 9:
                    select = Color.WhiteSmoke;
                    break;
                case 10:
                    select = Color.OrangeRed;
                    break;
            }
            return select;
        }
    }
}
