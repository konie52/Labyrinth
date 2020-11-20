using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class End1Director : MonoBehaviour
{
    private static int PlayerPoint1;
    //private static int PlayerPoint2;

    public GameObject P1PointObject;
    void Start()
    {
       int point = GameDirector.Getpoint();

        PlayerPoint1 = point;
       
        
        //PlayerPoint2 = 0;
        Debug.Log("P1="+PlayerPoint1);

        //Debug.Log("P2="+PlayerPoint2);
    }

    // Update is called once per frame
    void Update()
    {
        this.P1PointObject.GetComponent<TextMeshProUGUI>().text = "ぶつかった回数:" + PlayerPoint1 + "回";
    }

    public static int GetPlayerPoint1()
    {
        return PlayerPoint1;
    }
}
