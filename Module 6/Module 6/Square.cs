using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    public class Square : GeometricFigures
    {
        double side;

        public Square(double side)
        {
            this.side = side;
        }
                
        /// <summary>
        /// Canculate the Perimetr of a Square
        /// </summary>
        /// <returns>Perimetr</returns>
        public override double Perimeter()
        {
            return side * 4;
        }

        /// <summary>
        /// Canculate the Square of a Square
        /// </summary>
        /// <returns>Area</returns>
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
    }
}
