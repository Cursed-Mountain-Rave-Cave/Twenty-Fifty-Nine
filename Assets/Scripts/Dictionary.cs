using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TagDictionary
{
    static System.Collections.Generic.Dictionary<string,string> Obj = new System.Collections.Generic.Dictionary<string, string>()
    {
        {"baltica","Балтика 9"}
    };
    public static bool GetValue(string str,out string value)
    {
        return Obj.TryGetValue(str,out value);
    }
}
