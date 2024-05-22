using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace myDemo
{
    public class Rectangle
    {
        public double width;
        public double length;

        public Rectangle(double length, double width)
        {
            this.width = width;
            this.length = length;
        }

        public double CalculationArea()
        {
            double CalculationAreaR = this.length * this.width;
            return CalculationAreaR;
        }

        public double CalculationsPerimeter()
        {

            double CalculationPerimeterR = 2 * (this.length + this.width);
            return CalculationPerimeterR;

        }

        


    }

    

    
}
