using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    class RectangleShape : IShapesWithAngles
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Height * Width;
        }

        public double CalculateCircumference()
        {
            return 2 * (Height + Width);
        }
    }
}
