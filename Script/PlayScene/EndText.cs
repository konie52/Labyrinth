using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndText: MonoBehaviour
{
    public GameObject GoalText;
    void Start()
    {
        
        
    }

    void OnTriggerEnter(Collider other)
    {
        //ゴールシーンに移動
        int PlayerPoint1 = End1Director.GetPlayerPoint1();

        //Player1のポイントでif文
        //0ならEndScene1,0以外ならEndScene2

        if (PlayerPoint1==0)
        {
             SceneManager.LoadScene("1stEndScene");
        }

        else 
        {
            SceneManager.LoadScene("2ndEndScene");
        }
        
      
        

    }


    // Update is called once per frame
    void Update()
    {

    }
}