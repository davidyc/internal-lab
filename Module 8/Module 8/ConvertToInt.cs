using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8
{
    public class ConvertToInt
    {
        /// <summary>
        /// Convert string to int
        /// </summary>
        /// <param name="strNumber"></param>
        /// <param name="number"></param>
        public static void MyParseToInt(string strNumber , out int number)
        {
            number = 0;
            bool isNegative = false;
            int end = 0;

            List<int> ListNumeral = new List<int>();
            try
            {
                if (strNumber[0] == '-')
                {
                    isNegative = true;
                    end++;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);             
            }
           

            try
            {
                for (int i = strNumber.Length - 1; i >= end; i--)
                {
                    if (strNumber[i] > 47 && strNumber[i] <= 57)
                    {
                        ListNumeral.Add(strNumber[i]);                        
                    }
                    else
                    {
                        throw new Exception("No correct symbol");                        
                    }
                }

                number = ListToInt(ListNumeral, isNegative);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }

           
        }

        /// <summary>
        /// Convert list int to int
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static int ListToInt(List<int> list, bool isnegative)
        {
            int tmp = 0;
            try
            {              
                if (list.Count == 0)
                {
                    return 0;
                }
                checked
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        switch (list[i])
                        {
                            case 48: tmp += (int)Math.Pow(10, i) * 0; break;
                            case 49: tmp += (int)Math.Pow(10, i) * 1; break;
                            case 50: tmp += (int)Math.Pow(10, i) * 2; break;
                            case 51: tmp += (int)Math.Pow(10, i) * 3; break;
                            case 52: tmp += (int)Math.Pow(10, i) * 4; break;
                            case 53: tmp += (int)Math.Pow(10, i) * 5; break;
                            case 54: tmp += (int)Math.Pow(10, i) * 6; break;
                            case 55: tmp += (int)Math.Pow(10, i) * 7; break;
                            case 56: tmp += (int)Math.Pow(10, i) * 8; break;
                            case 57: tmp += (int)Math.Pow(10, i) * 9; break;
                        }
                    }
                    if (isnegative == true)
                    {
                        tmp*= -1;
                    }
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                tmp = 0;
            }

            return tmp;
        }
    


    }
}
