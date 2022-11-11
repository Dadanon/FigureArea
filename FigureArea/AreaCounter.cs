using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureArea
{
    public static class AreaCounter
    {
        public static double GetShapeArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
