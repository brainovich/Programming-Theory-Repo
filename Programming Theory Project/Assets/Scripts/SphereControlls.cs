using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControlls : MonoBehaviour
{
    //rigidbody variables
    protected Rigidbody playerRb;
    private float speed = 2f;

    //camera variables
    private Camera mainCamera;
    private Vector3 camOffset;
    private float camEulerAngleY;

    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        camOffset = new Vector3(0, 4.5f, -5);
        mainCamera = Camera.main;
    }

    void Update()
    {
        CameraPosition();
        Movement();
    }

    public void CameraPosition() //ABSTRACTION
    {
        Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X"), Vector3.up); //set an orbit of camera
        camOffset = camTurnAngle * camOffset; //set an orbit of camera
        mainCamera.transform.position = transform.position + camOffset; //offset to the camera position on the orbit
        mainCamera.transform.LookAt(transform.position); //make the camera to follow the player
    }

    public virtual void Movement() //ABSTRACTION
    {
        playerRb.AddRelativeForce(Input.GetAxis("Vertical") * Vector3.forward * speed); //make the ball to move forward and backwards

        camEulerAngleY = mainCamera.transform.localEulerAngles.y;  //find the Y rotation angle as Eulers angle
        if (camEulerAngleY > 180)
        {
            camEulerAngleY = (360 - camEulerAngleY) * -1;
        }

        transform.rotation = Quaternion.Euler(transform.rotation.x, camEulerAngleY, transform.rotation.z); //make the ball to follow along the camera position (y rotation Eulers)
    }   
}
