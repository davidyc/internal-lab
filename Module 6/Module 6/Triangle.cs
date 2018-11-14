using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    public class Triangle : GeometricFigures
    {
        double sideA;
        double sideB;
        double sideC;

        public Triangle(double sidea, double sideb, double sidec)
        {
            sideA = sidea;
            sideB = sideb;
            sideC = sidec;            
        }

        /// <summary>
        /// Create Triangle with random sides
        /// </summary>
        /// <returns></returns>
        public override GeometricFigures Create()
        {
            Random rnd = new Random();
            return new Triangle(rnd.Next(1, 5), rnd.Next(1, 5), rnd.Next(5, 10));
        }


        /// <summary>
        /// Canculate the Perimetr of a Triangle
        /// </summary>
        /// <returns>Perimetr</returns>
        public override double Area()
        {
            double halfPer = Perimeter() / 2;
            double tmp = halfPer * (halfPer - sideA) * (halfPer - sideB) * (halfPer - sideC);
            return Math.Sqrt(tmp);
        }

        /// <summary>
        /// Canculate the Square of a Triangle
        /// </summary>
        /// <returns></returns>
        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
