using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RigidbodyMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jump;
    public bool canJump;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        canJump = true;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(1f, 0f, 1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0f, 0f, -1f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(0f, jump, 0f, ForceMode.Impulse);
        }


    }
}