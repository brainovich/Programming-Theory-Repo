using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingSphere : SphereControlls
{
    [SerializeField] GameObject bullet;
    private Rigidbody bulletRb;
    private Vector3 bulletPos = new Vector3(0, -3.9f, 5.8f);
    [SerializeField] float bulletSpeed = 10f;


    void Start()
    {
        bulletRb = bullet.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, GameObject.Find("Child").transform.position + bulletPos, bullet.transform.rotation);
            //bullet.transform.Translate(Vector3.up * Time.deltaTime);
            bulletRb.AddForce(GameObject.Find("Child").transform.forward * bulletSpeed);

            //HOW TO CREATE BULLET IN FRONT OF THE BALL???
        }
    }
}
