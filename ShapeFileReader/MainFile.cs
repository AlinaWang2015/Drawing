using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class MainFile
    {
        private int recordNumber;
        private int contentLength;
        private int contentShapeType;
        private double[] recordBox = new double[4];
        private List<int> parts = new List<int> ();
        private List<Point> points = new List<Point> ();
        private string mainFilePath;

        public int RecordNumber
        {
            get { return recordNumber; }

            set { recordNumber = value; }
        }

        public int ContentLength
        {
            get { return contentLength; }

            set { contentLength = value; }
        }

        public int ContentShape
        {
            get { return contentShapeType; }

            set {  contentShapeType = value; }
        }

        public string MainFilePath
        {
            get { return mainFilePath; }

            set { mainFilePath = value; }
        }

        public double[] RecordBox
        {
            get { return recordBox; }

            set { recordBox = value; }
        }

        public List<int> Parts
        {
            get {  return parts;  }

            set { parts = value; }
        }

        public List<Point> Points
        {
            get {  return points; }

            set { points = value; }
        }

        public MainFile() { }

        public MainFile(string filepath)
        {
            this.MainFilePath = filepath;
        }
    }
}
