using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class move : MonoBehaviour
{
    public LayerMask groundLayers;
    public Rigidbody rb;
    public float speed=0.01F;
    public float jumpspeed=1F;
    bool ground = false;
    //public transform groundCheck;
    float groundRadius=0.2f;
    private bool shouldJump;
    private bool canJump;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      //  grounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,groundLayers);
        //anim.setBool("Grounded",grounded);

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
           rb.AddForce(new Vector2(0,0.5F));
        }
        if(Input.GetKey(KeyCode.S)){
           rb.AddForce(new Vector2(0,-0.5F));
           
        }
       
    }
   
    
}
