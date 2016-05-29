using System;
using ShapeFileReader;
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
            string show = ShowFile(shapefile);

            txtshow.Text = show;
        }
    }
}
