using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    internal class Box
    {
        private int length;
        private int width;
        private int height;

        public int FrontSurface {
            get {return length * height;}
        }
        public int Volume {
            get
            {
                return length * width * height;
            } 
        }

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;

        }

        public void DisplayInfo()
        {
            Console.WriteLine($"The height of the box is {height}, length is {length}, width is {width}, and volume is {length * height * width} ");
        }
    }
}
