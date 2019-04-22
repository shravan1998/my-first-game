using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class move : MonoBehaviour
{
    public float speed=0.01;
    public float jumpspeed=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(speed,0,0));
        }
         if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-speed,0,0));
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0,jumpspeed,0));
        }
        if(Input.GetKey(KeyCode.X)){
            transform.Translate(new Vector3(0,-jumpspeed,0));
        }
    }
   
    
}
