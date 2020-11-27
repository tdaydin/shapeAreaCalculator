using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    interface IShapesWithAngles
    {
        double Side { get; set; }
        double Height { get; set; }
        double Width { get; set; }
        double Length { get; set; }

        double CalculateArea();
        double CalculateCircumference();
    }
}
