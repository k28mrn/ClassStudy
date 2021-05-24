using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Cube
{
    public RedCube(float x = 0, float y = 0, float z = 0) : base(x,y,z) {
        cubeObj.GetComponent<Renderer>().material.color = Color.red;
    }
}
