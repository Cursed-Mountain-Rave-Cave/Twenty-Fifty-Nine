using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;
public static class Ext
{
    public static T getRandom<T>(this IEnumerable<T> source)
    {
        return source.OrderBy(x => Guid.NewGuid()).FirstOrDefault();
    }
}
