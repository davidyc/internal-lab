using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public class BinarySearchTree<T> where T : IComparable
    {
        public Node<T> root { get; set; }

        /// <summary>
        /// Add in BinaryTree 
        /// </summary>
        /// <param name="data">T type elemenrts</param>
        public void Insert(T data)
        {
            if (root == null)
            {
                root = new Node<T>(data);
            }

            Node<T> current = root;

            while (current != null)
            {
                if (data.CompareTo(current.data) > 0)
                {
                    if (current.right != null)
                    {
                        current = current.right;
                        continue;
                    }
                    current.right = new Node<T>(data);
                }
                else if (data.CompareTo(current.data) < 0)
                {
                    if (current.left != null)
                    {
                        current = current.left;
                        continue;
                    }
                    current.left = new Node<T>(data);
                }
                else
                {
                    return;
                }
            }
        }



    }
}
