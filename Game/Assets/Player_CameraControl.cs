using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_CameraControl : MonoBehaviour
{
    //private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent(Rigidbody);
    }

    

    public Transform relativeTransform;

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 moveDirection = Vector3.zero;
        //Move Forward
        float moveSpeed = 10;
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += relativeTransform.forward;
            moveDirection.y = 0f;
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }

        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection -= relativeTransform.right;
            moveDirection.y = 0f;
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= relativeTransform.forward;
            moveDirection.y = 0f;
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += relativeTransform.right;
            moveDirection.y = 0f;
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
    }
}
