using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerP : MonoBehaviour
{
    public float speed;
    public float input;
    Rigidbody2D rb;
    Animator anim;


    // Start is called before the first frame update
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
     anim = GetComponent<Animator>();
    
    }


    void Update()
    {
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxis("Horizontal");
        
        rb.velocity = new Vector2(input * speed, rb.velocity.y);
    
    if (input != 0) {
            anim.SetBool("isRunning", true);
        }
        else {
            anim.SetBool("isRunning", false);
        }
        
        if (input > 0) {
            transform.eulerAngles = new Vector3(0,0,0);
        }
        else if (input < 0) {
            transform.eulerAngles = new Vector3(0,180,0);
        }
    
    }
}
