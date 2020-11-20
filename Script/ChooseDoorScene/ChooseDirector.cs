using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChooseDirector : MonoBehaviour
{
    public GameObject WallPointObject;

    float wallnum = 10;

    public void ClickDoors()
    {
        this.wallnum -= 1;
    }


    public float Getwallnum()
    {
        return wallnum;
    }
   
    void Start()
    {
        //テキストUIを取得
        WallPointObject = GameObject.Find("WallPoint");
    }

    // Update is called once per frame
    void Update()
    {
        //テキストUIに値を入力
        this.WallPointObject.GetComponent<TextMeshProUGUI>().text = "あと"+this.wallnum.ToString() + "個選べます";
        
    }
}
