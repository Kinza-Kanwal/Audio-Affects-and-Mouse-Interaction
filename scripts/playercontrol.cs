using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    private float movement = 0f;
    private float jumpspeed = 10f;
    private float speed = 10f;
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementX = Input.GetAxis("Mouse X");
        float movementY = Input.GetAxis("Mouse Y");
        if (movementX > 0 && movementY > 0)
        {
            print("mouse is moving in first quadrant..");
        }
        else if (movementX < 0 && movementY > 0)
        {
            print("mouse is moving in second quadrant..");
        }
        else if (movementX < 0 && movementY < 0)
        {
            print("mouse is moving in third quadrant..");
        }
        else if (movementX > 0 && movementY < 0)
        {
            print("mouse is moving in fourth quadrant..");
        }
        else
            print("idle position");
    }
}
