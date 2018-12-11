using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_20
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass("Fpublic", true, 100, "MyPropString");

          
            var PropertyValue =  ReflectionHelper.GetPropertyValue(testClass, "MyProperty");
            Console.WriteLine("MyProperty value = " + PropertyValue);

            var PropertyValueAdress = ReflectionHelper.GetPropertyValue(testClass, "MyProperty");
            Console.WriteLine("Adress  value = " + PropertyValue);


            var GetPropertyValueByType = ReflectionHelper.GetPropertyValueByType(testClass, "System.Int32");
            Console.WriteLine("System.String value = " + GetPropertyValueByType);


            var HasProperty = ReflectionHelper.HasProperty(testClass, "MyProperty");
            Console.WriteLine("MyProperty " + HasProperty);
            var HasProperty2 = ReflectionHelper.HasProperty(testClass, "yProperty");
            Console.WriteLine("yProperty " + HasProperty2);

            var GetPropertyValue = ReflectionHelper.GetPropertyValue(testClass, "MyProperty", "Myprop", "MyStringProperty");
            List<object> tmpList = (List<object>)GetPropertyValue;
            foreach (var item in tmpList)
            {
                Console.WriteLine(item);
            }

            var prop = testClass.GetType().GetProperty("MyProperty");
            var GetCustomAttributes = ReflectionHelper.GetCustomAttributes(prop);          
            foreach (var item in GetCustomAttributes)
            {
                Console.WriteLine(item);
            }

            var GetProperty = ReflectionHelper.GetProperty(testClass, "MyProperty");
            Console.WriteLine("Property name = "  + GetProperty.Name);

            var GetPropertyType = ReflectionHelper.GetPropertyType(testClass, "MyProperty");
            Console.WriteLine("Property type = " + GetPropertyType);







            Console.WriteLine();
            Console.WriteLine("Methods");
            Console.WriteLine("--------------------------------------------------------------------------------");

            var GetMethodsInfo = ReflectionHelper.GetMethodsInfo(testClass);
           
            foreach (var item in GetMethodsInfo)
            {
                Console.WriteLine(item.Name + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Fields");
            Console.WriteLine("--------------------------------------------------------------------------------");

            var GetFieldsInfo = ReflectionHelper.GetFieldsInfo(testClass);

            foreach (var item in GetFieldsInfo)
            {
                Console.WriteLine(item.Name + " ");
            }

            object[] num = new object[1];
            num[0] = 10;
            var res= ReflectionHelper.CallMethod(testClass, "PublicDoSomeThinkWithParametr", num);
            Console.WriteLine("Res = "+ res);



            Console.Read();
        }
    }
}
