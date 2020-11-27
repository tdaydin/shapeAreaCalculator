using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    class TriangleShape : IShapesWithAngles
    {
        public double Side { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return (Math.Sqrt(3) / 4) * Math.Pow(Length, 2);
        }

        public double CalculateCircumference()
        {
            return 3 * Length;
        }
    }
}
