using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSphere : SphereControlls //INHERITANCE
{
    [SerializeField] GameObject bullet;
    private float camEulerAngleY_shoot;
    private float speedLimit = 25f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        Movement();
    }

    public override void Movement() //POLYMORPHISM
    {
        base.Movement();

        //add limitation of speed
        if(playerRb.velocity.magnitude >= speedLimit)
        {
            playerRb.velocity = playerRb.velocity.normalized * speedLimit;
        }
    }

    private void Shoot() //ABSTRACTION
    {
        camEulerAngleY_shoot = Camera.main.transform.localEulerAngles.y; //find the y rotation angle of the camera
        camEulerAngleY_shoot *= -1; // make it negative
        Instantiate(bullet, transform.localPosition + (transform.forward * 2), Quaternion.Euler(90, 0, camEulerAngleY_shoot)); //shoot along the y rotation axis of the camera
    }
}
