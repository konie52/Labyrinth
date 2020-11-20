using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using System.Linq;
using System;
using System.Text;

public class ClickDoor : MonoBehaviour
{

    GameObject clickedGameObject;
    bool isCalledOnce = false;
    string[,] MapID = new string[11, 11];

    void Update()
    {
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
                //Debug.Log(line);
                //一つずつに分断
                string[] values = line.Split(',');


                for (int j = 0; j < values.Length; j++)
                {
                    //2次元配列に収納
                    MapID[i, j] = values[j];
                    //Debug.Log(i + "," + j + MapID[i, j]);

                }
            }
        }

        //以下のプログラムをChangeColorと統合したい
        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit))
            {

                clickedGameObject = hit.collider.gameObject;
                //Debug.Log(clickedGameObject);

                string column = (clickedGameObject.name).Substring(0, 2);
                string row = (clickedGameObject.name).Substring(2, 2);

                Debug.Log("column" + column);
                Debug.Log("row" + row);

                MapID[int.Parse(column), int.Parse(row)] = "L";
                //Debug.Log(MapID[int.Parse(column), int.Parse(row)]);            

                /*
                for (int y = 0; y < 11; y++)
                {
                    if (y != 0)
                    {
                        words += "\n";
                    }
                    for (int x = 0; x < 11; x++)
                    {
                        words += MapID[y, x];
                        if (x != 10)
                        {
                            words += ",";
                        }
                    }
                }*/
            }


        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StreamWriter file = new StreamWriter("Assets/Resources/CSV/LabMap_copy.csv", false);

            for (int y = 0; y < 11; y++)
            {
                file.WriteLine(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}", MapID[y, 0], MapID[y, 1], MapID[y, 2], MapID[y, 3], MapID[y, 4], MapID[y, 5], MapID[y, 6], MapID[y, 7], MapID[y, 8], MapID[y, 9], MapID[y, 10]));
            }
            file.Close();
        }


    }

}
