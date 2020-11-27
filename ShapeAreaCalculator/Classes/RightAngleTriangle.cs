using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    class RightAngleTriangle : IShapesWithAngles
    {
        public double Side { get ; set ; }
        public double Height { get ; set ; }
        public double Width { get ; set ; }
        public double Length { get; set; }

        public double CalculateArea()
        {
            return Length * Height / 2;
        }

        public double CalculateCircumference()
        {
            double hypo = Math.Round((Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Length, 2))),2);

            return hypo + Height + Length;
        }
    }
}
