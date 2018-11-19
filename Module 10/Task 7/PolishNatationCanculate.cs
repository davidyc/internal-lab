using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class PolishNatationCanculate
    {

        public static double PolishNatationCanculete(string str)
        {
            Stack<double> stack = new Stack<double>();

            double tmp;
            bool numeral;

            string[] tmpArray = str.Split(' ');

            try
            {
                for (int i = 0; i < tmpArray.Length; i++)
                {
                    numeral = double.TryParse(tmpArray[i], out tmp);
                    if (numeral == true)
                    {
                        stack.Push(tmp);
                    }
                    else
                    {
                        switch (tmpArray[i])
                        {
                            case "+": stack.Push(stack.Pop() + stack.Pop()); break;
                            case "-":
                                double f = stack.Pop();
                                double s = stack.Pop();
                                stack.Push(s - f); break;
                            case "*": stack.Push(stack.Pop() * stack.Pop()); break;
                            case "/":
                                double fe = stack.Pop();
                                if (fe == 0)
                                    throw new DivideByZeroException();
                                double se = stack.Pop();
                                stack.Push(se / fe); break;
                            default:
                                throw new Exception("No correct symbol");
                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            return stack.Pop();
        }
    }
}
