using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCube : Cube
{
    public BlueCube(float x = 0, float y = 0, float z = 0): base(x,y,z) {
        cubeObj.GetComponent<Renderer>().material.color = Color.blue;
    }

    public void Move(Vector3 pos) {
        base.Move(pos);
        cubeObj.transform.localScale = new Vector3(2,2,2);
    }
}
