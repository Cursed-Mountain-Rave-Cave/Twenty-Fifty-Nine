using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public static class CheckList<T> 
{
    public static List<T> list;
    public static void Init(IEnumerable<T> list)
    {
        CheckList<T>.list = list.ToList();
    }

}
