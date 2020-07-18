using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckListView : MonoBehaviour
{
    public List<Text> List = new List<Text>();
    public Dictionary<string,Text> Dict = new Dictionary<string,Text>();
    void Start()
    {
        CheckList<string>.Init(new List<string>(){
            "baltika","pivo","pivas","nevskoe","jenia"
        });
        using(var enumerator = List.GetEnumerator())
        {
            foreach(var item in CheckList<string>.getList())
            {
                if(enumerator.MoveNext())
                {
                    if(enumerator.Current != null)
                    {
                        enumerator.Current.text = item;
                        Dict.Add(item,enumerator.Current);
                    }
                }               
            }
        }
        
    }

    void Update()
    {
        
    }
}

