using System;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    
    private Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewardForce = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(forwardForce * Time.deltaTime, 0, 0);

        if (Input.GetKey("d"))
        {
            rb.AddForce(0, 0, -sidewardForce * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(0, 0, sidewardForce * Time.deltaTime);
        }
    }
}
