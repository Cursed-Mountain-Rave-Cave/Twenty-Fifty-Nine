using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class CheckList 
{
    private static IEnumerable<string> list;
    public static bool Init(IEnumerable<string> list)
    {
        CheckList.list = list;
        return CheckList.list == null? false : true;
    }
    public static bool Check(string item)
    {
        return CheckList.list == null?CheckList.list.Contains(item) : false;
    }
    public static List<string> getList()
    {
        return  CheckList.list == null? CheckList.list.ToList() : null;
    }
    public static IEnumerable<string> GetIEnumerableList()
    {
        return CheckList.list;
    }

}
