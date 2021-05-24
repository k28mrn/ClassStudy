using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendsController : MonoBehaviour
{
    // Cube cube;
    BlueCube blueCube;
    RedCube redCube;
    // Start is called before the first frame update

    List<BlueCube> blueCubes = new List<BlueCube>();
    void Start()
    {
        // cube = new Cube();
        blueCube = new BlueCube(2,2,2);
        blueCube.Move(new Vector3(3,3,3));
        redCube = new RedCube();

        for (int i = 0; i < 10; i++) {
            BlueCube bc = new BlueCube(
                Random.Range(-5,5),
                Random.Range(-5,5),
                Random.Range(-5,5)
            );

            blueCubes.Add(bc);
        }

        for (int i = 0; i < 20; i++) {
            new RedCube(
                Random.Range(-5,5),
                Random.Range(-5,5),
                Random.Range(-5,5)
            );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
