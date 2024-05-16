using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PzProjekt
{
    public class Tools
    {

        

       
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ToStringPropertiesAttribute : Attribute
    {
    }


    public static class ToStringExtensions
    {
        public static string ToStringWithProperties<T>(this T obj)
        {
            if (obj == null) 
                return "brak";

            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();

            string result = type.Name + " { ";
            foreach (PropertyInfo property in properties)
            {
                result += $"{property.Name}: {property.GetValue(obj)}, ";
            }
            result = result.TrimEnd(',', ' ') + " }";
            return result;
        }
    }
}
