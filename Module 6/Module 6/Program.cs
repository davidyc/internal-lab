using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    class Program
    {
        public enum Figures
        {
            Rectangle,
            Circle,
            Square,
            Triangle
        }

        static void Main(string[] args)
        {
            CommonAreaAndPerimetr(10);
          
            Console.WriteLine();
            Console.Read();
        }

        /// <summary>
        /// Cauculete common Area and Perimetrs
        /// </summary>
        /// <param name="Count">Count FIGURES</param>
        static void CommonAreaAndPerimetr(int Count)
        {
            GeometricFigures[] arrayFigeres = new GeometricFigures[Count];
            Random rnd = new Random();
            double sumArea = 0;
            double sumPetr = 0;

            for (int i = 0; i < arrayFigeres.Length; i++)
            {
                int intFig = rnd.Next(0, 3);              
                Figures fig = (Figures)rnd.Next(0,3);
                arrayFigeres[i] = ReturnFig(fig);

                sumArea += arrayFigeres[i].Area();
                sumPetr += arrayFigeres[i].Perimeter();
            }

            Console.WriteLine("Common Area = " + sumArea);
            Console.WriteLine("Common Perimeter = " + sumPetr);
        }

        /// <summary>
        /// Create figure
        /// </summary>
        /// <param name="fig">Type figure</param>
        /// <returns>new figure</returns>
        static GeometricFigures ReturnFig(Figures fig)
        {
            Random rnd = new Random();

            switch (fig)
            {
                case Figures.Circle:
                    return new Circle(rnd.Next(1, 10));
                case Figures.Rectangle:
                    return new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10));
                case Figures.Square:
                    return new Square(rnd.Next(1, 10));
                default:
                    return new Triangle(rnd.Next(5, 10), rnd.Next(5, 10), rnd.Next(1, 5));
            }

        }
    }
}
