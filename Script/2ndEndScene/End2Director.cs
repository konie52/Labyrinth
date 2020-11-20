using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class End2Director : MonoBehaviour
{
    private int PlayerPoint1;
    private int PlayerPoint2;
    

    public GameObject WinnerText;
    public GameObject PointText1;
    public GameObject PointText2;

    // Start is called before the first frame update
    void Start()
    {
        //Player2の得点を取得
        int point = GameDirector.Getpoint();
        //Player1の得点を取得
        int PlayerPoint1 = End1Director.GetPlayerPoint1();
        //Player2の得点をそれ用の変数に代入
        PlayerPoint2 = point;

        Debug.Log(PlayerPoint1);
        Debug.Log(PlayerPoint2);

        //対戦結果
        if (PlayerPoint1 < PlayerPoint2)
        {
            this.WinnerText.GetComponent<TextMeshProUGUI>().text = "Player1の勝ち";
        }

        else if (PlayerPoint1 == PlayerPoint2)
        {
            this.WinnerText.GetComponent<TextMeshProUGUI>().text = "引き分け";
        }

        else
        {
            this.WinnerText.GetComponent<TextMeshProUGUI>().text = "Player2の勝ち";
        }

        //Playerの得点を表示
        this.PointText1.GetComponent<TextMeshProUGUI>().text = "Player1:" + PlayerPoint1+"回";
        this.PointText2.GetComponent<TextMeshProUGUI>().text = "Player2:" + PlayerPoint2+"回";
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
