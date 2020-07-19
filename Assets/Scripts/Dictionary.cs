﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TagDictionary
{
    static System.Collections.Generic.Dictionary<string,string> Obj = new System.Collections.Generic.Dictionary<string, string>()
    {
        {"pivo_green","Пиво ЗЕЛЕНОЕ"},
        {"sidr","СИДР"},
        {"pivo_brown","ПИВО КОРИЧНЕВОЕ"},
        {"shampun","ШамПанское 'Шампунь'"},
        {"vodka","Водка Ядреная"},
        
    };
    public static bool GetValue(string str,out string value)
    {
        return Obj.TryGetValue(str,out value);
    }
}
