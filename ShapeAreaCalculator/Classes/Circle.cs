using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Classes
{
    class Circle : IRoundedShapes
    {
        public double Radius { get; set; }
        //public bool IsPiThree { get; set; } = true;

        public double CalculateArea()
        {
            return Math.Round((Math.PI * Math.Pow(Radius, 2)),2);
            //return IsPiThree ? 3 * Math.Pow(Radius, 2) : Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateCircumference()
        {
            return Math.Round((2 * Math.PI * Radius),2);
            //return IsPiThree ? 2 * 3 * Radius : 2 * Math.PI * Radius;
        }
    }
}
