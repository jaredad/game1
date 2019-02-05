using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchCameras : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    // Start is called before the first frame update
    void Start()
    {
        camera1.enabled = true;
        camera2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKey("q"))
        {
            camera1.enabled = true;
            camera2.enabled = false;
        }

        if (Input.GetKey("e"))
        {
            camera1.enabled = false;
            camera2.enabled = true;
        }
    }
}
