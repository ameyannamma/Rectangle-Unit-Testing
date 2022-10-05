using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rectangle;

namespace RectangleTest
{
    [TestFixture]
    public class RectangleTest
    {
        [Test]
        public void GetCurrentLength_length10_output10()
        {
            int length = 10;
            int expected = 10;

            int actual = RectangleTesting.GetCurrentLength();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCurrentLength_length20_output20()
        {
            int length = 20;
            int expected = 20;

            int actual = RectangleTesting.GetCurrentLength();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCurrentLength_length350_output350()
        {
            int length = 350;
            int expected = 350;

            int actual = RectangleTesting.GetCurrentLength();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCurrentWidth_width20_output20()
        {
            int width = 20;
            int expected = 20;

            int actual = RectangleTesting.GetCurrentWidth();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCurrentWidth_width70_output70()
        {
            int width = 70;
            int expected = 70;

            int actual = RectangleTesting.GetCurrentWidth();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetCurrentWidth_width470_output470()
        {
            int width = 470;
            int expected = 470;

            int actual = RectangleTesting.GetCurrentWidth();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewLength_length50_output50()
        {
            int length = 50;
            int expected = 50;

            int actual = RectangleTesting.SetNewLength(length);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewLength_length100_output100()
        {
            int length = 100;
            int expected = 100;

            int actual = RectangleTesting.SetNewLength(length);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewLength_length509_output509()
        {
            int length = 509;
            int expected = 509;

            int actual = RectangleTesting.SetNewLength(length);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewWidth_width870_output870()
        {
            int width = 870;
            int expected = 870;

            int actual = RectangleTesting.SetNewWidth(width);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewWidth_width1007_output1007()
        {
            int width = 1007;
            int expected = 1007;

            int actual = RectangleTesting.SetNewWidth(width);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SetNewWidth_width1245_output1245()
        {
            int width = 1245;
            int expected = 1245;

            int actual = RectangleTesting.SetNewWidth(width);

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_length5_width10_output30()
        {
            int length = 5;
            int width = 10;

            int expected = 30;

            int actual = RectangleTesting.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_length2_width7_output18()
        {
            int length = 2;
            int width = 7;

            int expected = 18;

            int actual = RectangleTesting.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_length9_width4_output26()
        {
            int length = 9;
            int width = 4;

            int expected = 26;

            int actual = RectangleTesting.GetPerimeter();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_length11_width4_output44()
        {
            int length = 11;
            int width = 4;

            int expected = 44;

            int actual = RectangleTesting.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_length6_width3_output44()
        {
            int length = 6;
            int width = 3;

            int expected = 18;

            int actual = RectangleTesting.GetArea();

            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_length15_width2_output30()
        {
            int length = 15;
            int width = 2;

            int expected = 30;

            int actual = RectangleTesting.GetArea();

            Assert.AreEqual(expected, actual);
        }
    }
}
