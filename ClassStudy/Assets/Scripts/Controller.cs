using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    Cube cube;
    void Start()
    {
        cube = new Cube(2, 1, 3);
        // Moveメソッドが動作するか確認用
        cube.Move(new Vector3(3, -1, -1));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { // キーボードのSPACEが押されたとき
            cube.Move(new Vector3(2, 1, 3));
        } else if (Input.GetKeyDown(KeyCode.Alpha1)) { // 1押されたら
            cube.Move(new Vector3(-2, -1, -3));
        }
    }
}
