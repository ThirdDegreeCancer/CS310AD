using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Move()
    {
        //Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += .1f;
            transform.position = position;
        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= .1f;
            transform.position = position;
        }
        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z -= .1f;
            transform.position = position;
        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += .1f;
            transform.position = position;
        }
    }
}
