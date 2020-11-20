using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Linq;

public class LockController : MonoBehaviour
{
   
    [SerializeField]

    //ドアをインスペクターから入力
    GameObject[] Doors =new GameObject[60];

    void Start()
    {
        string[,] MapID = ChangeColor.getMapID();

        //文字が０ならドアが開く

        //1列目（横縦）
        if (MapID[0, 1] == "O") Doors[0].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[0, 3] == "O") Doors[1].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[0, 5] == "O") Doors[2].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[0, 7] == "O") Doors[3].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[0, 9] == "O") Doors[4].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 0] == "O") Doors[5].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 2] == "O") Doors[6].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 4] == "O") Doors[7].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 6] == "O") Doors[8].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 8] == "O") Doors[9].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[1, 10] == "O") Doors[10].layer = LayerMask.NameToLayer("DoorOpen");

        //2列目（横縦）
        if (MapID[2, 1] == "O") Doors[11].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[2, 3] == "O") Doors[12].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[2, 5] == "O") Doors[13].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[2, 7] == "O") Doors[14].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[2, 9] == "O") Doors[15].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 0] == "O") Doors[16].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 2] == "O") Doors[17].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 4] == "O") Doors[18].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 6] == "O") Doors[19].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 8] == "O") Doors[20].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[3, 10] == "O") Doors[21].layer = LayerMask.NameToLayer("DoorOpen");

        //3列目（横縦）
        if (MapID[4, 1] == "O") Doors[22].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[4, 3] == "O") Doors[23].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[4, 5] == "O") Doors[24].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[4, 7] == "O") Doors[25].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[4, 9] == "O") Doors[26].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 0] == "O") Doors[27].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 2] == "O") Doors[28].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 4] == "O") Doors[29].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 6] == "O") Doors[30].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 8] == "O") Doors[31].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[5, 10] == "O") Doors[32].layer = LayerMask.NameToLayer("DoorOpen");

        //4列目（横縦）
        if (MapID[6, 1] == "O") Doors[33].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[6, 3] == "O") Doors[34].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[6, 5] == "O") Doors[35].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[6, 7] == "O") Doors[36].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[6, 9] == "O") Doors[37].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 0] == "O") Doors[38].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 2] == "O") Doors[39].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 4] == "O") Doors[40].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 6] == "O") Doors[41].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 8] == "O") Doors[42].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[7, 10] == "O") Doors[43].layer = LayerMask.NameToLayer("DoorOpen");

        //5列目（横縦）
        if (MapID[8, 1] == "O") Doors[44].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[8, 3] == "O") Doors[45].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[8, 5] == "O") Doors[46].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[8, 7] == "O") Doors[47].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[8, 9] == "O") Doors[48].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 0] == "O") Doors[49].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 2] == "O") Doors[50].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 4] == "O") Doors[51].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 6] == "O") Doors[52].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 8] == "O") Doors[53].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[9, 10] == "O") Doors[54].layer = LayerMask.NameToLayer("DoorOpen");

        //6列目（縦）
        if (MapID[10, 1] == "O") Doors[55].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[10, 3] == "O") Doors[56].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[10, 5] == "O") Doors[57].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[10, 7] == "O") Doors[58].layer = LayerMask.NameToLayer("DoorOpen");
        if (MapID[10, 9] == "O") Doors[59].layer = LayerMask.NameToLayer("DoorOpen");
      
    }

    
    void Update()
    {
        
    }
}
