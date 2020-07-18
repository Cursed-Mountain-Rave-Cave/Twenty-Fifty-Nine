using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class CheckList<T> 
{
    private static IEnumerable<T> list;
    public static bool Init(IEnumerable<T> list)
    {
        CheckList<T>.list = list;
        return CheckList<T>.list == null? false : true;
    }
    public static bool Check(T item)
    {
        return CheckList<T>.list == null?CheckList<T>.list.Contains(item) : false;
    }
    public static List<T> getList()
    {
        return  CheckList<T>.list == null? CheckList<T>.list.ToList() : null;
    }
    public static IEnumerable<T> GetIEnumerableList()
    {
        return CheckList<T>.list;
    }

}
