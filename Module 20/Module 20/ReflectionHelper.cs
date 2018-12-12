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
        
        object res = null;
        object instance2 = null;

        instance2 = instance.GetType().GetProperty(array[0]).GetValue(instance, null);
        if (array.Length == 1)
        {
            return instance2;
        }

        for (int i = 1; i < array.Length; i++)
        {
            try
            {
                instance2 = instance.GetType().GetProperty(array[i - 1]).GetValue(instance, null);
                res = instance2.GetType().GetProperty(array[i]).GetValue(instance2, null);
            }
            catch(NullReferenceException)
            {
                return null;
            }
                    
        }

        return res;     
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

        var array = propertyName.Split('.');

        object res = null;
        object instance2 = null;

        instance2 = instance.GetType().GetProperty(array[0]);
        if (array.Length == 1)
        {
            return instance2 != null ? true : false; 
        }

        for (int i = 1; i < array.Length; i++)
        {
            try
            {
                instance2 = instance.GetType().GetProperty(array[i - 1]).GetValue(instance,null);
                res = instance2.GetType().GetProperty(array[i]);
            }
            catch (NullReferenceException)
            {
                return false;
            }

        }

        return res != null ? true : false; ;



        
    }

    public static object GetPropertyValue(object instance, params string[] propertyNames)
    {
        //вернуть первый из найденых property с заданными именами.
        PropertyInfo[] pi = instance.GetType().GetProperties();
        List<object> valueProp = new List<object>();
       
        for (int i = 0; i < pi.Length; i++)
        {
            var tmpPI = GetPropertyValue(instance, propertyNames[i]);

            if (tmpPI != null)
            {
                valueProp.Add(tmpPI);
            }
        }
        return valueProp;
    }

    public static PropertyInfo GetProperty(object instance, string propertyName) { 
    
        //желательно предусмотреть чтобы propertyName мог быть составным(например address.city.region)   
        var array = propertyName.Split('.');

        PropertyInfo res = null;
        object instance2 = null;

        res = instance.GetType().GetProperty(array[0]);
        if (array.Length == 1)
        {
            return res;
        }

        for (int i = 1; i < array.Length; i++)
        {
            try
            {
                instance2 = instance.GetType().GetProperty(array[i - 1]).GetValue(instance, null);
                res = instance2.GetType().GetProperty(array[i]);
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        return res;
    }

    public static Type GetPropertyType(object instance, string propertyName)
    {
        //желательно предусмотреть чтобы propertyName мог быть составным (например address.city.region)
        var pi = instance.GetType().GetProperty(propertyName);
        var array = propertyName.Split('.');

        PropertyInfo res = null;
        object instance2 = null;

        res = instance.GetType().GetProperty(array[0]);
        if (array.Length == 1)
        {
            return res.PropertyType;
        }

        for (int i = 1; i < array.Length; i++)
        {
            try
            {
                instance2 = instance.GetType().GetProperty(array[i - 1]).GetValue(instance, null);
                res = instance2.GetType().GetProperty(array[i]);
            }
            catch (NullReferenceException)
            {
                return null;
            }
        }

        return res.PropertyType;
        
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

