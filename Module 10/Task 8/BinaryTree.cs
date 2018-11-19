using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    public class BinaryTree<T> where T : IComparable
    {
        public Node<T> root { get; set; } = null;

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
        ///  Add in BinaryTree
        /// </summary>
        /// <param name="data"></param>
        /// <param name="node"></param>
        public void Insert(T data, Node<T> node)
        {
            if (data.CompareTo(node.data) > 0)
            {
                if (node.right == null)
                {
                    node.right = new Node<T>(data);
                    return;
                }

                Insert(data, node.right);
            }
            else if (data.CompareTo(node.data) < 0)
            {
                if (node.left == null)
                {
                    node.left = new Node<T>(data);
                    return;
                }

                Insert(data, node.left);
            }
        }

        /// <summary>
        /// Add from array elements
        /// </summary>
        /// <param name="array"></param>
        public void InsertFromArray(T[] array)
        {
            foreach (T t in array)
            {
                this.Insert(t);
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




