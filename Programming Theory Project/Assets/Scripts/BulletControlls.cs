using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControlls : MonoBehaviour
{
    private float time;

    void Update()
    {
        //make a bullet move forward
        time += Time.deltaTime;
        transform.Translate(Vector3.up * time);

        //make a bullet to be destroyed out of bounds
        if(transform.position.x > 500 || transform.position.x < -500 || transform.position.z > 500 || transform.position.z < -500)
        {
            Destroy(gameObject);
        }
    }
}
