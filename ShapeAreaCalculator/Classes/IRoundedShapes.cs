using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    interface IRoundedShapes
    {
        double Radius { get; set; }
        double CalculateArea();
        double CalculateCircumference();


    }
}
