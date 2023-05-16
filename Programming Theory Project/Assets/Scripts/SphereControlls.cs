using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControlls : MonoBehaviour
{
    protected Rigidbody playerRb;
    protected Camera mainCamera;
    private float speed = 2f;
    private Vector3 camOffset;
    private float camSmooth = 0.9f;
    private float camRotationSpeed = 1f;
    [SerializeField] protected float camEulerAngleY;
    

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
        camEulerAngleY = mainCamera.transform.localEulerAngles.y;
        if(camEulerAngleY > 180)
        {
            camEulerAngleY = (360 - camEulerAngleY) * -1;
        }
        transform.rotation = Quaternion.Euler(transform.rotation.x, camEulerAngleY, transform.rotation.z);
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

    public virtual void Movement()
    {
        playerRb.AddRelativeForce(Input.GetAxis("Vertical") * Vector3.forward * speed);
    }   
}
