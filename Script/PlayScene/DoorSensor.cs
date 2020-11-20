using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSensor : MonoBehaviour
{
    GameObject director;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
    }

    private void OnTriggerEnter(Collider other)
    {
        this.director.GetComponent<GameDirector>().TouchDoor();
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
