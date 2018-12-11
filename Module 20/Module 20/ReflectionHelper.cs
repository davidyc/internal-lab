using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

public static class ReflectionHelper
{
    public static object GetPropertyValue(object instance, string propertyName)
    {
        //желательно предусмотреть чтобы propertyName мог быть составным(например address.city.region)   
        var array = propertyName.Split('.');

        PropertyInfo pi = instance.GetType().GetProperty(array[0]);

        for (int i = 1; i < array.Length; i++)
        {
            pi = pi.GetType().GetProperty(array[i]);
        }  
           

        if (pi != null)
        {
            return pi.GetValue(instance, null);
        }
        return null;
    }

    public static object GetPropertyValueByType(object instance, string propertyType)
    {
        //вернуть первый из найденых property с заданными типом.
        PropertyInfo[] pInfos = instance.GetType().GetProperties();
        Type type = Type.GetType(propertyType);

        if (type == null)
            return null;

        for (int i = 0; i < pInfos.Count(); i++)
        {
           if (pInfos[i].PropertyType == type)
            {
                return pInfos[i].GetValue(instance, null);
            }
        }
        return null;
    }

    public static bool HasProperty(object instance, string propertyName)
    {
        //желательно предусмотреть чтобы propertyName мог быть составным(например address.city.region)
        PropertyInfo pi = instance.GetType().GetProperty(propertyName);
        return pi != null ? true : false;
    }

    public static object GetPropertyValue(object instance, params string[] propertyNames)
    {
        //вернуть первый из найденых property с заданными именами.
        PropertyInfo[] pi = instance.GetType().GetProperties();
        List<object> valueProp = new List<object>();
       
        for (int i = 0; i <= pi.Length; i++)
        {
            var tmpPI = GetPropertyValue(instance, propertyNames[i]);

            if (tmpPI != null)
            {
                valueProp.Add(tmpPI);
            }
        }
        return valueProp;
    }


    public static PropertyInfo GetProperty(object instance, string propertyName)
    {
        //желательно предусмотреть чтобы propertyName мог быть составным (например address.city.region)
        return instance.GetType().GetProperty(propertyName);
    }

    public static Type GetPropertyType(object instance, string propertyName)
    {
        //желательно предусмотреть чтобы propertyName мог быть составным (например address.city.region)
        var pi = instance.GetType().GetProperty(propertyName);

        return pi.PropertyType;
    }

    public static List<Attribute> GetCustomAttributes(PropertyInfo property)
    {
        List<Attribute> listAttribute = new List<Attribute>();
        var arr = property.Attributes;
        
      

        return listAttribute;
    }

    public static List<MethodInfo> GetMethodsInfo(object instance)
    {
        List<MethodInfo> listMethod = new List<MethodInfo>();
        MethodInfo[] methods = instance.GetType().GetMethods(BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance
        );

        for (int i = 0; i < methods.Count(); i++)
        {
            listMethod.Add(methods[i]);
        }

        return listMethod;
    }

    public static List<FieldInfo> GetFieldsInfo(object instance)
    {
        List<FieldInfo> listField= new List<FieldInfo>();
        FieldInfo[] fields = instance.GetType().GetFields(BindingFlags.DeclaredOnly | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance
            );

        for (int i = 0; i < fields.Count(); i++)
        {
            listField.Add(fields[i]);
        }

        return listField;
    }

    public static object CallMethod(object instance, string methodName, object[] param)
    {
        var method = instance.GetType().GetMethod(methodName);
        return method.Invoke(instance, param);        
    }

}

