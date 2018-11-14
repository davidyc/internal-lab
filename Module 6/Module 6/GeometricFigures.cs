using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    /// <summary>
    /// class describes all the geometric shapes
    /// </summary>
    public abstract class GeometricFigures
    {
        public abstract double Area();
        public abstract double Perimeter();
        public abstract GeometricFigures Create();
    }
}
