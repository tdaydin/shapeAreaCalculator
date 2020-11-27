using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    class Square : IShapesWithAngles
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Side * Side;
        }

        public double CalculateCircumference()
        {
            return Math.Round((4 * Side),2);
        }
    }
}
