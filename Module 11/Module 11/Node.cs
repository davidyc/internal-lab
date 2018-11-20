using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public class Node<T> : IEnumerable where T : IComparable
    {
        public Node(T data)
        {
            this.data = data;
        }

        public Node() { }

        public Node<T> right { get; set; } = null;
        public Node<T> left { get; set; } = null;
        public T data { get; set; }

        public IEnumerator GetEnumerator()
        {
            if (this.left != null)
            {
                foreach (var item in this.left)
                {
                    yield return item;
                }
            }

            yield return this.data;

            if (this.right != null)
            {
                foreach (var item in this.right)
                {
                    yield return item;
                }
            }
        }
    }
}
