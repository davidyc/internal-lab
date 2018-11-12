using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6_task_3
{
    public class Polynomial
    {
        int degree;
        double[] array;

        public Polynomial(int degree)
        {
            if (degree >= 1)
            {
                this.degree = degree;
            }
            else
            {
                degree = 1;
            }

           array = new double[degree];
        }

        /// <summary>
        /// polynomial indexer
        /// </summary>
        /// <param name="index">Index</param>
        /// <returns></returns>
        public double this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }

        /// <summary>
        /// Convert Polynomial to string
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            StringBuilder tmp = new StringBuilder();

            for (int i = array.Length-1; i > 0; i--) 
            {
                if (degree > 0)
                {
                    if (array[i] > 0 && i != array.Length-1) 
                    {
                         tmp.Append("+");
                    }

                    tmp.Append(array[i] + "x^" + i);                  
                } 
            }

            if (array[0] != 0) // для последней ячейки если не ноль
            {
                if (array[0] > 0) // если больше 0
                {
                    tmp.Append("+" + array[0]); // записывваем с полюсом
                }
                else
                {
                    tmp.Append(array[0]);// записываем в виде числа
                }
            }

            return tmp.ToString();
        }

        /// <summary>
        /// checks the polynomial equality
        /// </summary>
        /// <param name="obj">object for Equals</param>
        /// <returns></returns>           
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            Polynomial tmp = (Polynomial)obj;
            return this == tmp;
        }

        /// <summary>
        /// overload == for polynomials
        /// </summary>
        /// <param name="first">polynomial</param>
        /// <param name="second">polynomial</param>
        /// <returns></returns>
        public static bool operator ==(Polynomial first, Polynomial second)
        {
            if (first.degree != second.degree) 
            {
                return false;
            }
            else
            {
                for (int i = 0; i < first.array.Length; i++)
                {
                    // значения не равны 
                    if (first[i] != second[i]) return false;
                }
            }
            return true; // иначе true
        }

        /// <summary>
        /// overload != for polynomials
        /// </summary>
        /// <param name="first">polynomial</param>
        /// <param name="second">polynomial</param>
        /// <returns></returns>
        public static bool operator !=(Polynomial first, Polynomial second)
        {
            return first == second ? false : true;
        }

        /// <summary>
        /// overloaded operator +
        /// </summary>
        /// <param name="first">Polynomial 1</param>
        /// <param name="second">Polynomial 2</param>
        /// <returns></returns>
        public static Polynomial operator +(Polynomial first, Polynomial second)
        {          
            Polynomial tmp ;

            if (first.degree >= second.degree)
            {
              
                tmp = new Polynomial(first.degree);

                for (int i = 0; i < tmp.degree; i++)
                {
                    if (second.degree - 1 < i)
                    {                   
                        tmp[i] = first[i];
                    }
                    else
                    {
                        tmp[i] = first[i] + second[i];
                    }
                }
            }
            else
            {
                tmp = new Polynomial(second.degree);

                for (int i = 0; i < tmp.degree; i++) 
                {
                    if (first.degree - 1 < i) 
                    {                       
                        tmp[i] = second[i];
                    }
                    else
                    {                      
                        tmp[i] = first[i] + second[i];
                    }
                }
            }

            return tmp;
        }

        /// <summary>
        /// Overrided operator - 
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static Polynomial operator -(Polynomial first, Polynomial second)
        {

            Polynomial tmp;

            if (first.degree >= second.degree)
            {

                tmp = new Polynomial(first.degree);

                for (int i = 0; i < tmp.degree; i++)
                {
                    if (second.degree - 1 < i)
                    {
                        tmp[i] = first[i];
                    }
                    else
                    {
                        tmp[i] = first[i] - second[i];
                    }
                }
            }
            else
            {
                tmp = new Polynomial(second.degree);

                for (int i = 0; i < tmp.degree; i++)
                {
                    if (first.degree - 1 < i)
                    {
                        tmp[i] = second[i];
                    }
                    else
                    {
                        tmp[i] = first[i] - second[i];
                    }
                }
            }

            return tmp;
        }

        public static Polynomial operator *(Polynomial first, Polynomial second)
        {
            int size = first.degree + second.degree - 1;

            Polynomial tmp = new Polynomial(size); 

            for (int i = 0; i < first.degree; ++i)
            {
                for (int j = 0; j < second.degree; ++j)
                {
                    tmp[i + j] += first[i] * second[j];
                }
                    
            }
                
            return tmp;
        }



    }

}
