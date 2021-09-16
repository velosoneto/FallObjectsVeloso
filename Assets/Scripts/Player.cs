using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal")*speed, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("GAME OVER!!!");
        Destroy(gameObject);
    }
}
