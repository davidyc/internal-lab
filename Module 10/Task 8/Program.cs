using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Hello World!");

            BinaryTree<int> bst = new BinaryTree<int>();
            bst.Insert(1);
            bst.Insert(3);
            bst.Insert(5);
            bst.Insert(2);
            bst.Insert(21);
            bst.Insert(4, bst.root);
            Console.WriteLine(bst.FindByValue(4, bst.root).data);

            Console.ReadKey();

        }
    }
}
