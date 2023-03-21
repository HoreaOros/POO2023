using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rectangle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void RectangleConstructionTest1()
        {
            // Arrange
            Rectangle r = new Rectangle(2, 7, 2, 1);
            // Act
            string? actual = r.ToString();
            string? expected = "[(2, 7), Width = 2, Height = 1]";
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void RectangleConstructionTest2()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            string? actual = r.ToString();
            string? expected = "[(2, 7), Width = 2, Height = 1]";
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void PerimeterTest()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            int expected = 6;
            int actual = r.Perimeter();
            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AreaTest()
        {
            // Arrange
            Rectangle r = new Rectangle(new Point(2, 6), new Point(4, 7));
            // Act
            int expected = 2;
            int actual = r.Area();
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}