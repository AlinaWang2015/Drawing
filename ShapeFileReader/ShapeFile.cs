using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeFileReader
{
    public class ShapeFile
    {
        private string filepath;
        private double[] box = new double[4];
        private int fileLength;
        private int version;
        private int shapeType;

        public string FilePath
        {
            get { return filepath; }

            set { filepath = value; }
        }

        public double[] Box
        {
            get { return box; }

            private set { box = value;}
        }

        public int FileLength
        {
            get { return fileLength; }

            private set { fileLength = value; }
        }

        public int Version
        {
            get { return version; }

            private set { version = value; }
        }

        public int ShapeType
        {
            get { return shapeType; }

            private set { shapeType = value; }
        }

        public ShapeFile() { }

        public ShapeFile(string path)
        {
            this.FilePath = path;
        }

        public bool IsValidPath()
        {
            string extention = System.IO.Path.GetExtension(FilePath);
            string filenameNoExtension = System.IO.Path.GetFileNameWithoutExtension(FilePath);

            if (extention == "" || extention == ".shp" || extention == ".SHP" || extention == ".shx" || extention == ".SHX")
            {
                string directory = System.IO.Path.GetDirectoryName(FilePath);
                if (Directory.Exists(directory))
                {
                    string[] allMathingFiles = Directory.GetFiles(directory, filenameNoExtension + ".*");
                    string[] allMathingExtentions = new string[allMathingFiles.Length];
                    for (int i = 0; i < allMathingFiles.Length; i++)
                    {
                        allMathingExtentions[i] = System.IO.Path.GetExtension(allMathingFiles[i]);
                    }
                    if (allMathingExtentions.Contains(".shp") && allMathingExtentions.Contains(".shx"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public void LoadFileFeature()
        {
            string filepath = System.IO.Path.HasExtension(FilePath) ? FilePath.Substring(0, FilePath.Length - (System.IO.Path.GetExtension(FilePath).Length)) : FilePath;
            string shpfilepath = filepath + ".shp";

            if (!IsValidPath())
            {
                Console.WriteLine("Missing shapefile components at " + FilePath);
            }
            else
            {
                FileStream fs = new FileStream(shpfilepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryFile = new BinaryReader(fs);
                //open the   binary file
                binaryFile = new BinaryReader(fs);
                binaryFile.BaseStream.Seek(24, SeekOrigin.Current);

                FileLength = binaryFile.ReadInt32();
                Version = binaryFile.ReadInt32();
                ShapeType = binaryFile.ReadInt32();
                for (int i = 0; i < 4; i++)
                {
                    Box[i] = binaryFile.ReadDouble();
                }

                binaryFile.Close();
                fs.Close();
            }
        }

        public void ChangeRecordsToGeometry()
        {
            string filepath = System.IO.Path.HasExtension(FilePath) ? FilePath.Substring(0, FilePath.Length - (System.IO.Path.GetExtension(FilePath).Length)) : FilePath;
            string shpfilepath = filepath + ".shp";
            StringBuilder str = new StringBuilder();
            FileStream fs = new FileStream(shpfilepath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fs);
            binaryReader.BaseStream.Seek(100, SeekOrigin.Current);
            MainFile mainFile = new MainFile(shpfilepath);
            List<Polyline> polylines = new List<Polyline>();

            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                mainFile.RecordNumber = ChangbyteOrder(binaryReader.ReadInt32());
                mainFile.ContentLength = ChangbyteOrder(binaryReader.ReadInt32());
                mainFile.ContentShape = binaryReader.ReadInt32();
                mainFile.RecordBox[0] = binaryReader.ReadDouble();
                mainFile.RecordBox[1] = binaryReader.ReadDouble();
                mainFile.RecordBox[2] = binaryReader.ReadDouble();
                mainFile.RecordBox[3] = binaryReader.ReadDouble();
                int numParts = binaryReader.ReadInt32();
                int numPoints = binaryReader.ReadInt32();
                
                switch(mainFile.ContentShape)
                {
                    case 3:
                        for (int i = 0; i < numParts; i++)
                        {
                            mainFile.Parts.Add(binaryReader.ReadInt32());
                        }

                        for (int i = 0; i < numPoints; i++)
                        {
                            float x = (float)binaryReader.ReadDouble();
                            float y = (float)binaryReader.ReadDouble();
                            Point point = new Point(x, y);
                            mainFile.Points.Add(point);
                        }
                        Polyline polyline = new Polyline(mainFile.Parts, mainFile.Points);
                        
                        polylines.Add(polyline);
                        break;
                    default:
                        break;
                }



            }
        }

        private int ChangbyteOrder(int i)
        {
            int k;

            byte[] bytes = System.BitConverter.GetBytes(i);
            Array.Reverse(bytes);
            k = BitConverter.ToInt32(bytes,0);

            return k;
        }
    }
}
