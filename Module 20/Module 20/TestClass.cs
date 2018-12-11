using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_20
{
    class TestClass
    {
        int fieldPrivate;
        protected float fieldProcected;
        public string filedPublic;
        public static bool fieldStaticProp;


        public int MyProperty { get; set; }
        public string MyStringProperty { get; set; }
        public _Region Adress { get; set; }


        public TestClass()
        {
            fieldPrivate = 1;
            fieldProcected = 1;
            Adress = new _Region { City = "Karaganda" };
        }

        public TestClass(string fPublic, bool staticBool) : this()
        {
            filedPublic = fPublic;
            fieldStaticProp = staticBool;
        }

        public TestClass(string fPublic, bool staticBool, int myProp, string myStr): this(fPublic, staticBool)
        {
            MyProperty = myProp;
            MyStringProperty = myStr;
        }

        private void PrivateVoidDoSomeThink()
        {
            Console.WriteLine("private void PrivateVoidDoSomeThink() => DoSomeThink");
        }

        private int PrivateinnDoSomeThink()
        {
            Console.WriteLine("private int PrivateinnDoSomeThink() => Return 10");
            return 10;
        }

        private int PrivateinnDoSomeThinkWithParametr(int x)
        {
            Console.WriteLine("private int PrivateinnDoSomeThinkWithParametr(int x) => Return x = " + x);
            return x;
        }

        protected void ProtectedVoidDoSomeThink()
        {
            Console.WriteLine("protected void ProtectedVoidDoSomeThink()");
        }

        protected int ProtectedinnDoSomeThink()
        {
            Console.WriteLine("protected int ProtectedinnDoSomeThink() => Return 10");
            return 10;
        }

        protected int ProtectedDoSomeThinkWithParametr(int x)
        {
            Console.WriteLine("protected int ProtectedDoSomeThinkWithParametr(int x) => Return x = " + x);
            return x;
        }

        public void PublicVoidDoSomeThink()
        {
            Console.WriteLine("public void PublicVoidDoSomeThink()");
        }

        public int PublicinnDoSomeThink()
        {
            Console.WriteLine("public int PublicinnDoSomeThink() => Return 10");
            return 10;
        }

        public int PublicDoSomeThinkWithParametr(int x)
        {
            Console.WriteLine("public int PublicDoSomeThinkWithParametr(int x) => Return x = " + x);
            return x;
        }
    }
}
