﻿using System;
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


            //var PropertyValue = ReflectionHelper.GetPropertyValue(testClass, "MyProperty");
            //Console.WriteLine("MyProperty value = " + PropertyValue);

            //var PropertyValueAdress = ReflectionHelper.GetPropertyValue(testClass, "Adress.City");
            //Console.WriteLine("Adress value = " + PropertyValueAdress);


            //var GetPropertyValueByType = ReflectionHelper.GetPropertyValueByType(testClass, "System.Int32");
            //Console.WriteLine("System.Int32 value = " + GetPropertyValueByType);


            //var HasProperty = ReflectionHelper.HasProperty(testClass, "MyProperty");
            //Console.WriteLine("MyProperty " + HasProperty);
            //var HasProperty2 = ReflectionHelper.HasProperty(testClass, "yProperty");
            //Console.WriteLine("yProperty " + HasProperty2);

            //var HasProperty3 = ReflectionHelper.HasProperty(testClass, "Adress.City");
            //Console.WriteLine("Adress.City " + HasProperty3);
            //var HasProperty4 = ReflectionHelper.HasProperty(testClass, "Adress.City.ttt");
            //Console.WriteLine("Adress.City.ttt " + HasProperty4);

            //var GetPropertyValue = ReflectionHelper.GetPropertyValue(testClass, "MyProperty", "Myprop", "MyStringProperty");
            //List<object> tmpList = (List<object>)GetPropertyValue;
            //foreach (var item in tmpList)
            //{
            //    Console.WriteLine(item);
            //}

            //var prop = testClass.GetType().GetProperty("MyProperty");
            //var GetCustomAttributes = ReflectionHelper.GetCustomAttributes(prop);          
            //foreach (var item in GetCustomAttributes)
            //{
            //    Console.WriteLine(item);
            //}

            //var GetProperty = ReflectionHelper.GetProperty(testClass, "MyProperty");
            //Console.WriteLine("Property name = " + GetProperty.Name);

            //var GetProperty2 = ReflectionHelper.GetProperty(testClass, "Adress.City");
            //Console.WriteLine("Property name = " + GetProperty2.Name);

            var GetPropertyType = ReflectionHelper.GetPropertyType(testClass, "MyProperty");
            Console.WriteLine("Property type = " + GetPropertyType);

            var GetPropertyType2 = ReflectionHelper.GetPropertyType(testClass, "Adress.City");
            Console.WriteLine("Property type = " + GetPropertyType2);







            //Console.WriteLine();
            //Console.WriteLine("Methods");
            //Console.WriteLine("--------------------------------------------------------------------------------");

            //var GetMethodsInfo = ReflectionHelper.GetMethodsInfo(testClass);

            //foreach (var item in GetMethodsInfo)
            //{
            //    Console.WriteLine(item.Name + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Fields");
            //Console.WriteLine("--------------------------------------------------------------------------------");

            //var GetFieldsInfo = ReflectionHelper.GetFieldsInfo(testClass);

            //foreach (var item in GetFieldsInfo)
            //{
            //    Console.WriteLine(item.Name + " ");
            //}

            //object[] num = new object[1];
            //num[0] = 10;
            //var res= ReflectionHelper.CallMethod(testClass, "PublicDoSomeThinkWithParametr", num);
            //Console.WriteLine("Res = "+ res);



            Console.Read();
        }
    }
}
