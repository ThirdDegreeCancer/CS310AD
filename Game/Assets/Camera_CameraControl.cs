using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_CameraControl : MonoBehaviour
{
    public Transform target;
    public Transform relativeTransform;
    private Vector3 point;
    private Vector3 offset = Vector3.zero;
    private Vector3 offsetY = Vector3.zero;

    void Start()
    {
        point = target.transform.position;//get target's coords
        offset = new Vector3(target.position.x, target.position.y + 1.0f, target.position.z + 7.0f);

        transform.LookAt(point);//makes the camera look to it
    }

    void Update()
    {
        Move();
    }
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * 10, Vector3.up) * offset;
        transform.position = target.position + offset;
        transform.LookAt(target.position);
    }

    void CameraBoundariesX()
    {
        float x = transform.eulerAngles.x;
        float y = transform.eulerAngles.y;
        float z = transform.eulerAngles.z;
        bool top = false;

        if (x < 360f && x > 270f)
            top = true;
        else
            top = false;
        if (x < 280f && top)
        {
            this.transform.rotation = Quaternion.Euler(280, y, z);
        }
        if (x > 40f && !top)
        {
            this.transform.rotation = Quaternion.Euler(40, y, z);
            
        }
    }
    void LockCameraZ()
    {
        float z = transform.eulerAngles.z;
        transform.Rotate(0, 0, -z);
    }
    void Move()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Vector3 moveDirection = Vector3.zero;
        float moveSpeed = 10;
        LockCameraZ();
        CameraBoundariesX();

        /*
         Old Movement Controls
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += relativeTransform.forward;
            moveDirection.y = 0f;
            LockCameraZ();
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }

        //Move Left
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection -= relativeTransform.right;
            moveDirection.y = 0f;
            LockCameraZ();
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
        //Move Back
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection -= relativeTransform.forward;
            moveDirection.y = 0f;
            LockCameraZ();
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
        //Move Right
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += relativeTransform.right;
            moveDirection.y = 0f;
            LockCameraZ();
            this.transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
        */
    }
}