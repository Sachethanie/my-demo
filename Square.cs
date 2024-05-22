using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDemo
{
    public class Square
    {
        public double length;
       

        public Square(double length)
        {

            this.length = length;
           
        } 
    
        public double CalculationsArea()

        {
           double CalculationAreaS = this.length * this.length;
            return CalculationAreaS;

        }

        public double CalculationsPerimeter()
        {
            double CalculationPerimeterS = 4 * this.length;
            return CalculationPerimeterS;

        }

    }


}
