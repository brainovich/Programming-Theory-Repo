using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSphere : SphereControlls
{
    [SerializeField] GameObject bullet;
    [SerializeField] float bulletSpeed = 10f;
    [SerializeField] float camEulerAngle2;
    [SerializeField] float recoil = 2.0f;

    // Update is called once per frame
    void Update()
    {
        camEulerAngle2 = Camera.main.transform.localEulerAngles.y;
        camEulerAngle2 *= -1;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.localPosition + (transform.forward * 2), Quaternion.Euler(90, 0, camEulerAngle2));
        }
    }

    public override void Movement()
    {
        playerRb.AddRelativeForce(Input.GetAxis("Vertical") * Vector3.forward *0.001f);
    }
}
