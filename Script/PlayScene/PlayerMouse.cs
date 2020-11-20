using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse: MonoBehaviour
{
    public GameObject viewcamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //カーソルを中央に固定
        //WeBGLで出力するときのみ有効にする
       
       // Cursor.lockState = CursorLockMode.Locked;

        float mouse_x = Input.GetAxis("Mouse X");
        float mouse_y = Input.GetAxis("Mouse Y");
        transform.Rotate(0.0f, 4*mouse_x, 0.0f);
        viewcamera.transform.Rotate(-4*mouse_y, 0.0f, 0.0f);
    }
}
