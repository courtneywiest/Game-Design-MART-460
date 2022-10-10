using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody 2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //rgb.velocity = new Vector3(10, 0, 0);

    }

    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rgb.velocity = new Vector3(0, 10, 0);

        }
        else if(Input.GetKey("s"))
        {
            rgb.velocity = new Vector3(0, -);
        }
    }
}


