using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class Node<T> where T : IComparable
    {
      
        public Node(T data)
        {
            this.data = data;
        }

        public Node() { }
     
        public Node<T> right { get; set; } = null;
        public Node<T> left { get; set; } = null;
        public T data { get; set; }
    }


}
