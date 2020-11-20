using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//以下ClickDoor用
using UnityEditor;
using System.IO;
using System.Linq;
using System;
using System.Text;

public class ChangeColor : MonoBehaviour
{
    public Material MaterialA;
    public GameObject MainSceneButton;

     GameObject director;
   　GameObject clickedGameObject;
   
    //ClickDoorの部分
    bool isCalledOnce = false;
    public static string[,] MapID = new string[11, 11];
    public static string[,] getMapID()
    {
        return MapID;
    }


    // Start is called before the first frame update
    void Start()
    {
        //UIを操作する監督を取得
        director = GameObject.Find("ChooseDirector");

    }


    void Update()
    {
        float wnum = director.GetComponent<ChooseDirector>().Getwallnum();

        //ClickDoorの部分
        if (!isCalledOnce)
        {
            isCalledOnce = true;
            //CSVファイルの読み込み
            TextAsset csv = Resources.Load("CSV/LabMap") as TextAsset;
            StringReader reader = new StringReader(csv.text);
            for (int i = 0; i < 11; i++)
            {
                //一列ごとに読み込む
                string line = reader.ReadLine();
                
                //一つずつに分断
                string[] values = line.Split(',');


                for (int j = 0; j < values.Length; j++)
                {
                    //2次元配列に収納
                    MapID[i, j] = values[j];

                }
            }
        }


        //壁の選択数で場合分け
        if (wnum < 1)
        {
            MainSceneButton.SetActive(true);
        }


        else if (Input.GetMouseButtonDown(0))
        {
            clickedGameObject = null;

            //Rayでクリックしたオブジェクトを取得
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {
                clickedGameObject = hit.collider.gameObject;
               
                //clickedGameObjectがクリックされたオブジェクト


                //Tagでドアのみ反応させる
                if (clickedGameObject.gameObject.CompareTag("Doors"))
                {
                    //マテリアルを変更
                    clickedGameObject.GetComponent<Renderer>().material = MaterialA;

                    //UIを更新するよう監督に通達
                    director.GetComponent<ChooseDirector>().ClickDoors();

                    string column = (clickedGameObject.name).Substring(0, 2);
                    string row = (clickedGameObject.name).Substring(2, 2);

                    MapID[int.Parse(column), int.Parse(row)] = "L";


                }

            }
        }
        
        
      
    }
    
}
