using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FigureArea
{
    public class Triangle : IShape
    {
        private readonly double sideOne;
        private readonly double sideTwo;
        private readonly double sideThree;
        private readonly double semiPerimeter;
        public Triangle(double sideOne, double sideTwo, double sideThree)
        {
            this.sideOne = sideOne;
            this.sideTwo = sideTwo;
            this.sideThree = sideThree;
            semiPerimeter = (sideOne + sideTwo + sideThree) / 2;
        }
        public double GetArea()
        {
            return Math.Sqrt(semiPerimeter * 
                (semiPerimeter - sideOne) * 
                (semiPerimeter - sideTwo) * 
                (semiPerimeter - sideThree));
        }
        public bool IsRectangular()
        {
            List<double> sides = new() { sideOne, sideTwo, sideThree };
            sides.Sort();
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
