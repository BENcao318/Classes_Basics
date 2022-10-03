using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Basics
{
    internal class Box
    {
        // member variables
        private int length;
        public int height;
        public int width;
        public int volume;

        // Setter
        public void SetLength(int length)
        {
            this.length = length;
        }

        // Getter
        public int GetLength()
        {
            return this.length;
        }


        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and heigth is {1} and width is {2} and volume is {3}", length, height, width, volume = length * height * width);
        }
    }
}
