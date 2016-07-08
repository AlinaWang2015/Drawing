using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryPainter;

namespace Charts
{
    public class PieChart
    {
        private string name;
        private int type;
        private double radius;
        private List<int> data;

        public PieChart(string name, double radius, List<int> data)
        {
            this.Name = name;
            this.Radius = radius;
            this.Data = data;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Type
        {
            get { return type; }
            private set { type = value; }
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public List<int> Data
        {
            get { return data; }
            private set { data = value; }
        }

       
    }
}
