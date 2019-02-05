using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerOne : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 7.5f;
    public float sidewaysForce = 25f;
    public int breakCount = 0;
    public Camera camera;
    public Slider killbar;
    public bool destroy = false;
    public int desCount = 0;



    // FixedUpdate() is used for physics updates
    void FixedUpdate()
    {
        //Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
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

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & destroy == true)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.name[0] == 'O' & destroy == true)
                {
                    Destroy(hit.collider.gameObject);
                    desCount++;
                    killbar.value = percentLeft();
                    if (desCount > 4)
                    {
                        killbar.value = percentLeft();
                        desCount = 0;
                        destroy = false;
                    }
                }
            }
        }
    }

    float percentLeft()
    {
        Debug.Log((5 - desCount) / 5f);
        return (5 - desCount) / 5f;
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name[0] == 'c')
        {
            Destroy(col.gameObject);
            destroy = true;
            killbar.value = percentLeft();
        }
    }
}
