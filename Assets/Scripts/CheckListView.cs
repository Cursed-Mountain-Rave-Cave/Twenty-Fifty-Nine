using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckListView : MonoBehaviour
{
    public List<Text> List = new List<Text>();
    public List<RawImage> CheckBox = new List<RawImage>();
    public Dictionary<string,RawImage> Dict = new  Dictionary<string,RawImage>();
    void Start()
    {
        CheckList<string>.Init(new List<string>(){
            "baltika","pivo","pivas","nevskoe","jenia"
        });
        this.initCheckListView();
        
    }
    void initCheckListView()
    {
        using(var TextBoxEnumerator = List.GetEnumerator())
        using(var CheckBoxEnumerator = CheckBox.GetEnumerator())
        {
            foreach(var item in CheckList<string>.getList())
            {
                if(TextBoxEnumerator.MoveNext() && CheckBoxEnumerator.MoveNext())
                {
                    if(TextBoxEnumerator.Current != null && CheckBoxEnumerator.Current != null)
                    {
                        TextBoxEnumerator.Current.text = item;
                        Dict.Add(item,CheckBoxEnumerator.Current);
                    }
                }               
            }
        }
    }
    void Update()
    {
        
    }
}

