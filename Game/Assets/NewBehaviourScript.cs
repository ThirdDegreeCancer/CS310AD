using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        Move();

    }


    void Move()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Move Forward
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.z += .1f;
            this.transform.position = position;
        }
        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 position = this.transform.position;
            position.x -= .1f;
            this.transform.position = position;
        }
        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.z -= .1f;
            this.transform.position = position;
        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 position = this.transform.position;
            position.x += .1f;
            this.transform.position = position;
        }
        //Look Around
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);
        float z = transform.eulerAngles.z;
        transform.Rotate(0, 0, -z);
        if(this.transform.rotation.eulerAngles.x > 18)
        {
            this.transform.Rotate(-transform.rotation.x +18, 0, 0);
        }
        if (this.transform.rotation.eulerAngles.x < -18)
        {
            this.transform.Rotate(-transform.rotation.x -18, 0, 0);
        }
    }
   
    
}
