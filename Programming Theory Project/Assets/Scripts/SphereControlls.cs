using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControlls : MonoBehaviour
{
    protected Rigidbody playerRb;
    private Camera mainCamera;
    private float speed = 2f;
    private Vector3 camOffset;
    private float camSmooth = 0.9f;
    private float camRotationSpeed = 1f;
    

    // Start is called before the first frame update
    void Start()
    {
        playerRb = gameObject.GetComponent<Rigidbody>();
        camOffset = new Vector3(0, 4.5f, -5);
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        
        CameraPosition();
        
    }

    private void LateUpdate()
    {
        Movement();
    }



    public void CameraPosition()
    {

        Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * camRotationSpeed, Vector3.up);
        camOffset = camTurnAngle * camOffset;
        Vector3 camPos = transform.position + camOffset;
        mainCamera.transform.position = Vector3.Slerp(mainCamera.transform.position, camPos, camSmooth);
        mainCamera.transform.LookAt(transform.position);
    }

    public void Movement()
    {
        playerRb.AddForce(Input.GetAxis("Vertical") * GameObject.Find("Child").transform.forward * speed);
    }   
}
