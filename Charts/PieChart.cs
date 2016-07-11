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
        private int radius;
        private PieGeometry pie;
        private List<int> data;
        private List<int> showData;

        public PieChart(string name, int radius, List<int> data)
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

        public int Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public List<int> Data
        {
            get { return data; }
            private set { data = value; }
        }

       //public bool IsEmphasis()
       // {
       //     if()
       // }

        public float GetStartAngle()
        {
            float sumData=0;
            float startAngle = 0;
            foreach(var itemData in data)
            {
                sumData += itemData;
            }

            for(int i=0;i<data.Count;i++)
            {
                startAngle = Convert.ToSingle(data[i] / sumData * 360);
            }

            return startAngle;
        }
    }
}
