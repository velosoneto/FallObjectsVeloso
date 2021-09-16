using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject cube;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateCube", 1f, 1f);
    }

    void CreateCube()
    {
        if (player != null)
        {
            Instantiate(cube, new Vector3(Random.Range(-6,6), 10, 0), Quaternion.identity);
        }
    }
}
