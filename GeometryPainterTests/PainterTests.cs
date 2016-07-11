using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryPainter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace GeometryPainter.Tests
{
    [TestClass()]
    public class PainterTests
    {
    //    [TestMethod()]
    //    public void CreateCanvasTest()
    //    {
            
    //        Canvas canvas = new Canvas();
    //        Image g = Painter.CreateCanvas(canvas);

    //        Assert.AreEqual(300, g.Height);
    //       // Assert.AreEqual(Color.Red,g.)
    //    }

        [TestMethod()]
        public void SetPenTest()
        {
            Style style = new Style();
            Pen t = Painter.SetPen(style);

            Assert.AreEqual(Color.Black, t.Color);
        }

        [TestMethod()]
        public void DrawPointTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawPolylineTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawPolygonTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DrawCircleTest()
        {
            Assert.Fail();
        }
    }
}