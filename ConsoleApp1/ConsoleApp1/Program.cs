using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IArithmetic<T>
    {
        T Add(T a, T b);
        T Multiply(T a, T b);
        T Subtract(T a, T b);
        T Divide(T a, T b);
    }
    class S<Data> where Data : IArithmetic<Data>
    {
        public T Add(T a, T b) { return a + b; }
        public T Multiply(T a, T b) { return a * b; }
        public T Subtract(T a, T b) { return a - b; }
        public T Divide(T a, T b) { return a / b; }
    }
    class Program
    {
        static void Main()
        {
            S<int> XS = new S<int>();
            Console.WriteLine(XS.Add(4, 9));
            Console.ReadKey();
        }
    }
}
