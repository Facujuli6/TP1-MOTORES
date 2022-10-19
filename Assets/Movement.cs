using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0f , 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed * Time.deltaTime);
        }
    }
}
