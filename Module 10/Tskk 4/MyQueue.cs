using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tskk_4
{

    //public class Queue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
    public class MyQueue<T> : IEnumerable<T>, IEnumerable, ICollection, IReadOnlyCollection<T>
    {           
        int size = 4;
        int countElemaent;
        T[] array = new T[4];


        public int Count { get { return countElemaent; } }

        public object SyncRoot { get; }

        public bool IsSynchronized { get; }

        /// <summary>
        /// Add in end queene
        /// </summary>
        /// <param name="element">Element for ADD</param>
        public void Enqueue(T element)
        {
           if(Count < size)
           {
                array[countElemaent] = element;
                countElemaent++;
            }
            else
            {
                size *= 2;
                T[] tmp = array;
                array = new T[size];
                for (int i = 0; i < tmp.Length; i++)
                {
                    array[i] = tmp[i];
                }
                array[Count] = element;
                countElemaent++;
            }
        }

        /// <summary>
        /// Return first element but do not delete it
        /// </summary>
        /// <returns>First element</returns>
        public T Peek()
        {
            return array[0];
        }

        /// <summary>
        /// Delete queue start element
        /// </summary>
        /// <returns></returns>
        public T Dequeue()
        {
            T tmp = array[0];
            T[] arrTmp = array;

            for (int i = 1; i < arrTmp.Length; i++)
            {
                array[i - 1] = arrTmp[i];
               
            }

            countElemaent--;

            return tmp;
        }

        /// <summary>
        /// Implements  GetEnumerator for MyQueue
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < countElemaent)
                    yield return array[i];
                else
                    yield break;
            }
        }

        /// <summary>
        /// Implements  GetEnumerator for MyQueue
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i < countElemaent)
                    yield return array[i];
                else
                    yield break;
            }
                
        }

        /// <summary>
        /// Copy all elements since index
        /// </summary>
        /// <param name="array">Array</param>
        /// <param name="index">Start copy index element</param>
        public void CopyTo(Array array, int index)
        {
            T[] tmp = new T[size-index];
            for (int i = index, j = 0; i < array.Length; i++, j++)
            {
                tmp[j] = this.array[i];                
            }
            array = tmp;
        }
    }
}
