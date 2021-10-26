using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_UnitTest
{
    public class Rectangle
    {
        private int length;
        private int width;
        private int height;
        private int v;

        public Rectangle()
        {
            length = 1;
            width = 1;
            height = 1;
        }

        public Rectangle(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public Rectangle(int v)
        {
            this.v = v;
        }

        public int Getlength()
        {
            return length;
        }

        public int Setlength(int length)
        {
            this.length = length;
            return this.length;
        }

        public int Getwidth()
        {
            return width;
        }

        public int Setwidth(int width)
        {
            return width;
        }


        public int Getheight()
        {
            return height;
        }


        public int Setheight(int width)
        {
            return height;
        }


        public int GetVolume()
        {
            return length * width * height;
        }

    }
}
