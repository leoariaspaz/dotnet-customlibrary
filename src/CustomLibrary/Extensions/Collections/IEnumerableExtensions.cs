using CustomLibrary.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLibrary.Extensions.Collections
{
    public static class IEnumerableExtensions
    {
        public static SortableBindingList<T> ToSortableBindingList<T, T2>(this IEnumerable<T2> query, Func<T2, T> convert)
        {
            SortableBindingList<T> list = new SortableBindingList<T>();
            foreach (var item in query)
            {
                list.Add(convert(item));
            }
            return list;
        }

        public static SortableBindingList<T> ToSortableBindingList<T>(this IEnumerable<T> query)
        {
            SortableBindingList<T> rubros = new SortableBindingList<T>();
            foreach (var item in query)
            {
                rubros.Add(item);
            }
            return rubros;
        }
    }
}
