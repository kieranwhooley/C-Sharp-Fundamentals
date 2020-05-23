using System;
using System.Collections.Generic;
using System.Text;

namespace Section6
{
    class Square
    {
        public Square(double sideLength)
        {
            this.SideLength = sideLength;
            SquareArea = CalculateArea(this.SideLength);
        }

        private double CalculateArea(double length)
        {
            return length * length;
        }

        public double SideLength { get; }

        public double SquareArea { get; }

    }
}
