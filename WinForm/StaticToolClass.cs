using PzProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public static class StaticToolClass
    {
        public static List<string> GetItemsAsString <T>(this List<T> sourceList)
        {
            List<string> result = new List<string>();
            foreach (T item in sourceList)
            {
                result.Add(item.ToStringWithProperties());
            }
            return result;
        }
    }
}
