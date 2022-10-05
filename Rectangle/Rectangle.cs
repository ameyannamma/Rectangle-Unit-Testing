using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rectangle
{
    public class RectangleTesting
    {
        // Declaring private integers
        private static int setlength;
        private static int setwidth;
        

        public RectangleTesting()
        {
            setlength = 1;
            setwidth = 1;
           
        }

        public RectangleTesting(int length, int width)
        {
            setlength = length;
            setwidth = width;
        }

        public int Length { 
            set { setlength = value; }
            get { return setlength; } 
        }

        public int Width
        {
            set { setwidth = value; }
            get { return setwidth; }
        }

        public static int GetCurrentLength() {
            return setlength; }
        public static int GetCurrentWidth() { return setwidth; }
        public static int SetNewLength(int length) { 
            setlength = length;
            return setlength; 
        }
        public static int SetNewWidth(int width) {
            setwidth = width;
            return setwidth;
        }
        public static int GetPerimeter() { return ((2 * setlength) + (2 * setwidth)); }
        public static int GetArea() { return (setwidth * setlength); }
    }
}
