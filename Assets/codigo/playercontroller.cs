using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    private float speed = 6;
    private float speedRun = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.gravityScale = 35;
         Quieto();
        
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            Correr();
            
            rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {            
            saltarF();
            
            }
            if(Input.GetKey(KeyCode.X))
            {
            Correr();
             rb2d.velocity = new Vector2(speedRun,rb2d.velocity.y);
            }
             if(Input.GetKey(KeyCode.Z))
            {
            atakar();
            }
          
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            Correr();
            rb2d.velocity = new Vector2(-speed,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {
               saltarF();
             
           
            }
            if(Input.GetKey(KeyCode.X))
            {
            Correr();
             rb2d.velocity = new Vector2(-speedRun,rb2d.velocity.y);
            }
             if(Input.GetKey(KeyCode.Z))
            {
            atakar();
            }
        }
        else
        {
            Quieto();
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
            if(Input.GetKey(KeyCode.Space))
            {
            saltarF();
            }
             if(Input.GetKey(KeyCode.Z))
            {
            atakar();
            }
        }
    }
    public void saltarF(){
        var upSpeed = 80f;
        rb2d.velocity = Vector2.up * upSpeed;
        saltar();
    }
    public void Quieto(){
        animator.SetInteger("estado", 0);        
    }
     public void Correr(){
        animator.SetInteger("estado", 1);        
    }
     public void saltar(){
        animator.SetInteger("estado", 2);        
    }
    public void atakar(){
        animator.SetInteger("estado", 3);        
    }
}
