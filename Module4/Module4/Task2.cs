using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    public class Task2
    {
        /// <summary>
        /// Search GCD by Efklid
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static int GCD(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0 || firstNumber == 0) 
            {
                if (secondNumber == 0) return firstNumber;
                else return secondNumber; 
            }
            else
            {
                if (firstNumber < secondNumber) 
                    return GCD(firstNumber, secondNumber % firstNumber);
                else
                    return GCD(secondNumber, firstNumber % secondNumber);
            }
        }

        /// <summary>
        /// Search GCD by Efklid with 3  and more parametrs
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int GCD(params int[] array)
        {
            int minDel = array[0]; 
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                    int tmp = GCD(array[j], array[i]); 
                    if (tmp < minDel)
                    {
                        minDel = tmp; 
                    }
                }
            }
            return minDel; 
        }

        /// <summary>
        /// Search GCD by Stein 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int BinaryGCD(int first, int second)
        {
            if (first == second)
            {
                return first; 
            }
            if (first == 0) 
            {
                return second; 
            }
            if (second == 0) 
            {
                return first; 
            }

            if (first % 2 == 0) 
            {
                if (second % 2 == 1) 
                {
                    return BinaryGCD(first >> 1, second);
                }
                else 
                {
                    return BinaryGCD(first >> 1, second >> 1) << 1;
                }
            }

            if (second % 2 == 0) 
            {
                return BinaryGCD(first, second >> 1);
            }
            if (first > second) 
            {
                return BinaryGCD((first - second) >> 1, second);
            }
            return BinaryGCD((second - first) >> 1, first); 
        }

        /// <summary>
        /// Search GCD by Efklid with 3  and more parametrs
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int BinaryGCD(params int[] array)
        {
            int minDel = array[0]; 
            for (int j = 0; j < array.Length; j++)
            {
                for (int i = j + 1; i < array.Length; i++)
                {
                       
                    int tmp = BinaryGCD(array[j], array[i]);
                    if (tmp < minDel)
                    {
                        minDel = tmp; 
                    }
                }
            }
            return minDel;
        }

      
        public static void TimeMethodEuclidean(int f, int s)
        {    
            Stopwatch watch = new Stopwatch();
            watch.Start(); 
            GCD(f, s);
            watch.Stop();        
            Console.WriteLine("Time GCD = {0},{1} = {2} ticks", f, s, watch.ElapsedTicks);
            Console.WriteLine("Time GCD = {0},{1} = {2} Milliseconds", f, s, watch.ElapsedMilliseconds);
        }    

        public static void TimeMethodStein(int f, int s)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            BinaryGCD(f, s);
            watch.Stop();
            Console.WriteLine("Time BinaryGCD {0},{1} = {2} ticks", f, s, watch.ElapsedTicks);
            Console.WriteLine("Time GCD = {0},{1} = {2} Milliseconds", f, s, watch.ElapsedMilliseconds);
        }    
       

    }

}
