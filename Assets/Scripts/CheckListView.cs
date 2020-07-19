using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckListView : MonoBehaviour
{
    public List<Text> List = new List<Text>();
    public List<RawImage> CheckBox = new List<RawImage>();
    public Dictionary<string,List<RawImage>> Dict = new  Dictionary<string,List<RawImage>>();
    void Start()
    {
        this.initCheckListView();
    }
    void initCheckListView()
    {
        using(var TextBoxEnumerator = List.GetEnumerator())
        using(var CheckBoxEnumerator = CheckBox.GetEnumerator())
        {
            foreach(var item in GetRandom(List.Count))
            {
                if(TextBoxEnumerator.MoveNext() && CheckBoxEnumerator.MoveNext())
                {
                    if(TextBoxEnumerator.Current != null && CheckBoxEnumerator.Current != null)
                    {
                        if(TagDictionary.GetValue(item,out var label))
                        {
                            TextBoxEnumerator.Current.text = label;
                            if(Dict.TryGetValue(item,out var list))
                            {
                                list.Add(CheckBoxEnumerator.Current);
                            }
                            else
                            {
                                Dict.Add(item,new List<RawImage>(){CheckBoxEnumerator.Current});
                            }
                        }

                    }
                }               
            }
        }
    }
    void Update()
    {
        
    }
    IEnumerable<string> GetRandom(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return TagList.Tags.getRandom();
        }
    }
}

