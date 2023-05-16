using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControlls : MonoBehaviour
{
    private float time;
    [SerializeField] float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        transform.Translate(Vector3.up * bulletSpeed * time);
        if(transform.position.x > 500 || transform.position.x < -500 || transform.position.z > 500 || transform.position.z < -500)
        {
            Destroy(gameObject);
        }
    }
}
