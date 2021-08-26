using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    private float speed = 15;
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
         quieto();
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
                     
            rb2d.velocity = new Vector2(speed,rb2d.velocity.y);
            Correr();
        }else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
           
            rb2d.velocity = new Vector2(-speed,rb2d.velocity.y);
            Correr();
        }
    }
    public void quieto(){
        animator.SetInteger("estado", 0);        
    }
     public void Correr(){
        animator.SetInteger("estado", 1);        
    }
     public void muere(){
        animator.SetInteger("estado", 2);        
    }
}
