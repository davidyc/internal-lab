using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {     
        static void Main(string[] args)
        {
            MyClass tmp = new MyClass();
            int[] array = tmp.Mymethod();

            Console.Read();
        }
    }

    class MyAt : Attribute
    {
        public int Count { get; set; }
    }

    [MyAt(Count = 10)]
    class MyClass
    {
        int field;

        public int MyProperty { get; set; }

        public MyClass()
        {

        }

        public int[] Mymethod()
        {
            var type = this.GetType();
            if (Attribute.IsDefined(type, typeof(MyAt)))
            {
                var countAt = Attribute.GetCustomAttribute(type, typeof(MyAt)) as MyAt;
                return new int[countAt.Count];
            }
            else
                return new int[0];
        }
    }
}