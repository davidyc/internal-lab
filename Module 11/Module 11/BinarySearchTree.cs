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

        /// <summary>
        /// Add in tree array elements
        /// </summary>
        /// <param name="arrays">array</param>
        public void InsertArray(T[] arrays)
        {
            for (int i = 0; i < arrays.Length; i++)
            {
                Insert(arrays[i]);

            }
        }

        /// <summary>
        /// Implement three ways of traversing the tree: Inorder
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Inorder()
        {
            if (root == null) yield break;

            var stack = new Stack<Node<T>>();
            var node = root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    yield return node.data;
                    node = node.right;
                }
                else
                {
                    stack.Push(node);
                    node = node.left
;
                }
            }
        }

        /// <summary>
        ///  Implement three ways of traversing the tree: Preorder
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Preorder()
        {
            if (root == null) yield break;

            var stack = new Stack<Node<T>>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var node = stack.Pop();
                yield return node.data;
                if (node.right != null) stack.Push(node.right);
                if (node.left != null) stack.Push(node.left);
            }
        }

        /// <summary>
        ///  Implement three ways of traversing the tree: Postorder
        /// </summary>
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> Postorder()
        {
            if (root == null) yield break;

            var stack = new Stack<Node<T>>();
            var node = root;

            while (stack.Count > 0 || node != null)
            {
                if (node == null)
                {
                    node = stack.Pop();
                    if (stack.Count > 0 && node.right == stack.Peek())
                    {
                        stack.Pop();
                        stack.Push(node);
                        node = node.right;
                    }
                    else { yield return node.data; node = null; }
                }
                else
                {
                    if (node.right != null) stack.Push(node.right);
                    stack.Push(node);
                    node = node.left;
                }
            }
        }





    }
}
