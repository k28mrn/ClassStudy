using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube
{
    /// <summary>
    /// メンバ変数
    /// </summary>
    public GameObject cubeObj;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public Cube(float x = 0, float y = 0, float z = 0) {
        Debug.Log("Cube コンストラクター");
        // Cubeオブジェクト生成
        cubeObj = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // 作成したCubeオブジェクトの位置を変更
        cubeObj.transform.position = new Vector3(x, y, z);
    }

    /// <summary>
    /// Moveメソッド
    /// </summary>
    /// <param name="pos"></param>
    public void Move(Vector3 pos) {
        cubeObj.transform.position = pos;
    }
}
