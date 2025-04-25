using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        this.rigidbody = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //move
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,0.1f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-0.1f);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,-1f,0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,1f,0);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Translate(0.1f,0,0);
        }
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-0.1f,0,0);
        }


        //junmp
        if(Input.GetKeyDown(KeyCode.Space) && this.rigidbody.velocity.y == 0)
        {
            this.animator.SetTrigger("JumpTrigger");
            this.rigidbody.AddForce(0, 350f, 0);
        }

        
    }
}
