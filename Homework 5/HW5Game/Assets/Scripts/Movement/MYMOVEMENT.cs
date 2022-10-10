using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MYMOVEMENT : MonoBehaviour

{
      private Rigidbody2D rgb;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
       // rgb.velocity = new Vector3(10, 0, 0);

         if(Input.GetKey("up"))
        {
            rgb.velocity = new Vector3(0, 10, 0);

        }
        else if(Input.GetKey("down"))
        {
            rgb.velocity = new Vector3(0, -10, 0);
        }
        else if(Input.GetKey("left"))
        {
                rgb.velocity = new Vector3(-10, 0, 0);
        }
        else if(Input.GetKey("right"))
        {
                rgb.velocity = new Vector3(10, 0, 0);
        }
    }
    }

    

