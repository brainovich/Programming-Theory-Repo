using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpingSphere : SphereControlls
{
    private float jumpForce = 10f;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < 0.7f)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }


}
