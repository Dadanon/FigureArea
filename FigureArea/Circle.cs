using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace FigureArea
{
    public class Circle : IShape
    {
        private readonly double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
