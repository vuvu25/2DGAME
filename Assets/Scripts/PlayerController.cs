using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    public float jumpForce;

    
    


    void Start()
    {
        
    }

    
    void Update()
    {
        theRB.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), theRB.velocity.y);

      
        if(Input.GetButtonDown("Jump"))
        {
        
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);
            
        }
    }
}
