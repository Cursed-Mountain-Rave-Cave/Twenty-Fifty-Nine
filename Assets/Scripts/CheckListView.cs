using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckListView : MonoBehaviour
{
    public Texture CheckBoxTexture;
    public List<Text> List = new List<Text>();
    public List<RawImage> CheckBox = new List<RawImage>();
    public List<(string,RawImage)> LabelCheckBox = new List<(string,RawImage)>();
    void Start()
    {
        CheckList<string>.Init(GetRandom(List.Count));
        this.initCheckListView();
    }
    void initCheckListView()
    {
        using(var TextBoxEnumerator = List.GetEnumerator())
        using(var CheckBoxEnumerator = CheckBox.GetEnumerator())
        {
            foreach(var item in CheckList<string>.list)
            {
                if(TextBoxEnumerator.MoveNext() && CheckBoxEnumerator.MoveNext())
                {
                    if(TextBoxEnumerator.Current != null && CheckBoxEnumerator.Current != null)
                    {
                        if(TagDictionary.GetValue(item,out var label))
                        {
                            TextBoxEnumerator.Current.text = label;
                            LabelCheckBox.Add((item,CheckBoxEnumerator.Current));
                        }
                    }
                }    
            }
        }
    }
    void Update()
    {
        
    }
    void SetCheckBox(RawImage image)
    {
        if(image == null)
        {
            image.texture = CheckBoxTexture;
        }
    }
    void RemoveByTag(string tag)
    {
        var tags = this.LabelCheckBox.Where(x=>x.Item1 == tag);
        if(tags.Count() != 0)
        {
            var item = tags.FirstOrDefault();
            this.SetCheckBox(item.Item2);
            this.LabelCheckBox.Remove(item);
        }
    }
    IEnumerable<string> GetRandom(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return TagList.Tags.getRandom();
        }
    }
}

