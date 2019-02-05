using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 7.5f;
    public float sidewaysForce = 25f;
    public int breakCount = 0;

    // FixedUpdate() is used for physics updates
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange );
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("w"))
        {
            if(breakCount < 350) {
                rb.AddForce(0, 0, (-forwardForce) * Time.deltaTime, ForceMode.VelocityChange);
                breakCount++;
            }
        }

    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "crystal")
        {
            Destroy(col.gameObject);
        }
    }
}
