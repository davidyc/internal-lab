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
                 
           
            public void InsertFromArray(T[] array)
            {
                foreach (T t in array)
                {
                    this.Insert(t);
                }
            }            

            public int GetLevel(Node<T> node, int current = 1)
            {
                int right = 0;
                int left = 0;

                if (node.right != null)
                {
                    right = GetLevel(node.right, current + 1);
                }

                if (node.left != null)
                {
                    left = GetLevel(node.right, current + 1);
                }

                if (right == 0 && left == 0) return current; 

                else
                {
                    return right > left ? right : left;
                }

            }
           
            public void GetOnLevel(Node<T> node, int curLevel, int trgLevel, Queue<T> result)
            {
                if (curLevel == trgLevel)
                {
                    result.Enqueue(node.data);
                }
                else
                {
                    if (node.left != null)
                    {
                        GetOnLevel(node.left, curLevel + 1, trgLevel, result);
                    }

                    if (node.right != null)
                    {
                        GetOnLevel(node.right, curLevel + 1, trgLevel, result);
                    }
                }
            }

            public Node<T> FindByValue(T data, Node<T> node)
            {
                if (node == null) return null;

                if (data.Equals(node.data))
                {
                    return node;
                }

                if (data.CompareTo(node.data) > 0)
                {
                    return FindByValue(data, node.right);
                }
                else if (data.CompareTo(node.data) < 0)
                {
                    return FindByValue(data, node.left);
                }

                else return null;
            }

        }
}




