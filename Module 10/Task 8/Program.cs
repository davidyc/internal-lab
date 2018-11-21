using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            BinaryTree<int> bst2 = new BinaryTree<int>();
            bst2.Insert(1);
            bst2.Insert(3);
            bst2.Insert(5);
            bst2.Insert(2);
            bst2.Insert(21);
            bst2.Insert(4, bst.root);

            bst2.Inorder();


            FileStream f = new FileStream("", FileMode.Create);



            f.Dispose();

            BinaryTree<int> bst3 = new BinaryTree<int>();
            bst3.Insert(1);
            bst3.Insert(3);
            bst3.Insert(5);
            bst3.Insert(2);
            bst3.Insert(21);
            bst3.Insert(4, bst.root);

            bst3.Postorder();

            Console.ReadKey();
        }
    }
}
