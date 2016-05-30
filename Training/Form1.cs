using System;
using ShapeFileReader;
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
    public partial class Form1 : Form
    {
        private string filepath;

 
        public Form1()
        {
            InitializeComponent();
        }

        public string ShowFile( ShapeFile shapefile)
        {
            StringBuilder str = new StringBuilder();
            string s = string.Format("输出文件头：");
            str.AppendLine(s);
            s = string.Format("文件长度：{0}", shapefile.FileLength);
            str.AppendLine(s);
            s = string.Format("版本：{0}", shapefile.Version);
            str.AppendLine(s);
            s = string.Format("shape类型：{0}", shapefile.ShapeType);
            str.AppendLine(s);
            s = string.Format("头文件的边界盒(Xmin,Ymin,Xmax,Ymax)：({0},{1},{2},{3})", shapefile.Box[0], shapefile.Box[1], shapefile.Box[2], shapefile.Box[3]);
            str.AppendLine(s);
            return str.ToString();
        }

        public string ShowGeometry(ShapeFile shapefile)
        {
            var geos = shapefile.ChangeRecordsToGeometry();
            StringBuilder str = new StringBuilder();
            string s = string.Format("");
            s = string.Format("输出geometry的属性：");
            str.AppendLine(s);
            foreach(var geo in geos)
            {
                s = string.Format("geometry的编号：{0}", geo.Id);
                str.AppendLine(s);
                s = string.Format("几何类型：{0}", geo.GeometryType);
                str.AppendLine(s);
                s = string.Format("geometry的部分的数目：{0}", geo.Parts.Count);
                str.AppendLine(s);
                s = string.Format("geometry的点的总数目：{0}", geo.Points.Count);
                str.AppendLine(s);
                foreach(var point in geo.Points)
                {
                    s = string.Format("顶点坐标为：({0},{1})", point.X,point.Y);
                    str.AppendLine(s);
                }
            }
            
            return str.ToString();
        }

        public void DrawGeometry(ShapeFile shapefile)
        {
            var geos = shapefile.ChangeRecordsToGeometry();
            Painter painter = new Painter();
           // Pen pen = new 

            foreach (var geo in geos)
            {
                switch(geo.GeometryType)
                {
                    case 1:
                        break;
                    case 3:
                        break;
                }
            }
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openflg = new OpenFileDialog();
            openflg.Filter = "*.shp|*.SHP";
            openflg.Multiselect = false;
            if (openflg.ShowDialog() == DialogResult.OK)
            {
                filepath = openflg.FileName;
                txtaddress.Text = filepath;
            }
            ShapeFile shapefile = new ShapeFile(filepath);
            shapefile.LoadFileFeature();
            string showFile = ShowFile(shapefile);
            string showGeometry = ShowGeometry(shapefile);

            txtshow.Text = showFile + showGeometry;
        }
    }
}
