using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public static class Extension
    {
        public static BinarySearchTree<StudentTestInformation> WhereForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation,bool> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().Where(func).ToArray();          

            tmp.InsertArray(res);

            return tmp;
        }

        public static BinarySearchTree<StudentTestInformation> OberByForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, string> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderBy(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        public static BinarySearchTree<StudentTestInformation> OberByDescendingForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, string> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderByDescending(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

    }
}
