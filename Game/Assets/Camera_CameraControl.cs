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
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * 10, Vector3.up) * offset;
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
        //Move Forward
        float moveSpeed = 10;
        /*
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


        //Look Around
        //float h = Input.GetAxisRaw("Mouse X");
        //float v = Input.GetAxisRaw("Mouse Y");
        //transform.Rotate(-v, h, 0f);

        /*
        // Move around player
        transform.LookAt(target.transform);
        transform.RotateAround(point, new Vector3(-v, h, 0.0f), 10 * Time.deltaTime * moveSpeed);
        */

        //if (moveDirection != Vector3.zero)
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(moveDirection), rotationSpeed * Time.deltaTime);

        LockCameraZ();
        CameraBoundariesX();
    }
}



//this.transform.localEulerAngles = new Vector3(Mathf.Clamp(this.transform.localEulerAngles.x, -60, 42), 0, 0);
/*
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

*/




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
