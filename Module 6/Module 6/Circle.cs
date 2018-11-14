using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    /// <summary>
    /// Class describes a circle
    /// </summary>
    public class Circle : GeometricFigures
    {
        double radius; 

        public Circle(double radius)
        {
            this.radius = radius;
        }    

        /// <summary>
        /// calculation of the Perimeter of ​​a circle
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// calculation of the Area of ​​a circle
        /// </summary>
        /// <returns>Square circle</returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(radius,2);
        }
    }
}
