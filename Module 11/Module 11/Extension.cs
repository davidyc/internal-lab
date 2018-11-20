using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_11
{
    public static class Extension
    {
        /// <summary>
        /// Where for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> WhereForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation,bool> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().Where(func).ToArray();          

            tmp.InsertArray(res);

            return tmp;
        }


        /// <summary>
        /// order for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> OberByForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, string> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderBy(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        /// <summary>
        /// order for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> OberByDescendingForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, string> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderByDescending(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        /// <summary>
        /// order for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> OberByDescendingForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, int> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderByDescending(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        /// <summary>
        /// oredr for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> OberByDescendingForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, Func<StudentTestInformation, DateTime> func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().OrderByDescending(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        /// <summary>
        /// Take for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> TakegForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, int func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().Take(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

        /// <summary>
        /// Skip for BinarySearchTree
        /// </summary>
        /// <param name="obj">BinarySearchTree</param>
        /// <param name="func"></param>
        /// <returns>BinarySearchTree</returns>
        public static BinarySearchTree<StudentTestInformation> SkipForBinaryTree(this BinarySearchTree<StudentTestInformation> obj, int func)
        {
            BinarySearchTree<StudentTestInformation> tmp = new BinarySearchTree<StudentTestInformation>();

            var res = obj.Preorder().Skip(func).ToArray();

            tmp.InsertArray(res);

            return tmp;
        }

    }
}
