using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    public class Rectangle : GeometricFigures
    {
        double shotSide;
        double longSide;

        public Rectangle(double shortside, double longside)
        {
            shotSide = shortside;
            longSide = longside;
        }


        /// <summary>
        /// Canculate the Perimetr of a Rectangle
        /// </summary>
        /// <returns>Perimetr</returns>
        public override double Perimeter()
        {
            return (shotSide + longSide) * 2;
        }

        /// <summary>
        /// Canculate the Area of a Rectangle
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
         
            return shotSide * longSide;
        }

      
    }
}
