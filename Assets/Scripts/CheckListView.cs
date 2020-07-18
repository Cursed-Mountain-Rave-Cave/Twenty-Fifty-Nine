using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckListView : MonoBehaviour
{
    public List<GameObject> List = new List<GameObject>();
    public Dictionary<string,GameObject> Dict = new Dictionary<string,GameObject>();
    void Start()
    {
        CheckList<string>.Init(new List<string>(){
            "baltika","pivo","pivas","nevskoe","jenia"
        });
        CheckList<string>.getList()?.ForEach((x)=>{
            if(List.GetEnumerator().MoveNext())
                this.Dict.Add(x,List.GetEnumerator().Current);
        });
    }
    void Update()
    {
        
    }
}

