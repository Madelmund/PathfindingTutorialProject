using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACScript : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    SpriteRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("y", rb.velocity.y);
        anim.SetBool("Run", rb.velocity.x != 0);
        anim.SetBool("Grounded", GetComponent<PlayerMovement>().IsGrounded());
        
        if(Input.GetAxisRaw("Horizontal") < 0)
        {
            renderer.flipX = true;
        }else if(Input.GetAxisRaw("Horizontal") > 0)
        {
            renderer.flipX = false;
        }
        
    }
}
