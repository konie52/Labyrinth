using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GameDirector : MonoBehaviour
{
    GameObject pointText;
    AudioSource sound1;

    static int point;



    //ドアに触れたときに1point追加する
    public void TouchDoor()
    {
        point += 1;
        sound1.PlayOneShot(sound1.clip);
    }


    void Start()
    {
        point = 0;
        this.pointText = GameObject.Find("Point");

        sound1 = this.GetComponent<AudioSource>();
    }

  
    void Update()
    {
       this.pointText.GetComponent<Text>().text = point.ToString() + "Point";
    }

    //そのシーンのポイントを返す
    public static int Getpoint()
    {
        return point;
    }


}
