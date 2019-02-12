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
        float h = Input.GetAxisRaw("Mouse X");
        float v = Input.GetAxisRaw("Mouse Y");
        transform.Rotate(-v, h, 0);

        float z = transform.eulerAngles.z;
        transform.Rotate(0, 0, -z);

        float x = transform.rotation.x;
        /*
        if(x < -60f)
        {
            print("before");
            float XChangeHigh = x + 60f;
            transform.Rotate(-XChangeHigh, 0, 0);
            print("after");
        }

        if(x > 42f)
        {
            print("beforelow");
            float XChangeLow = x - 42f;
            transform.Rotate(-XChangeLow, 0, 0);
            print("afterlow");
        }
        */
        //this.transform.localEulerAngles = new Vector3(Mathf.Clamp(this.transform.localEulerAngles.x, -60, 42), 0, 0);

        if (transform.localEulerAngles.x > 42)
        {
            transform.localEulerAngles = new Vector3(42, 0, 0);
        }
        else
        {
            if (transform.localEulerAngles.x < -60)
            {
                transform.localEulerAngles = new Vector3(-60, 0, 0);
            }
        }






        /*
        if(this.transform.rotation.eulerAngles.x > 18)
        {
            this.transform.Rotate(-transform.rotation.x +18, 0, 0);
        }
        if (this.transform.rotation.eulerAngles.x < -18)
        {
            this.transform.Rotate(-transform.rotation.x -18, 0, 0);
        }
        */
    }
   
    
}
