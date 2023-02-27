using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanderer : MonoBehaviour
{
    public float speed = 10;
    public float turnSpeed = 100;
    private float horizontalInput;
    private float forwardInput;

    void Start()
    {

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Move vehicle forward and back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn vehicle left and right
        transform.Rotate(Vector3.up, horizontalInput * Time.deltaTime * turnSpeed);
    }
}
