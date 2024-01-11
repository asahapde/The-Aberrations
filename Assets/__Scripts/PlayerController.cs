using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
    
        // get user input from the keyboard... the input is any input from the device
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // x,y,z values. y=0 because we don't wanna move up
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;
        rb.AddForce(movement * speed);
    }
}
