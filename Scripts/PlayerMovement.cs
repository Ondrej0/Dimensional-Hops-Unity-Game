using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;

    private float rotation = 0f;
    public float moveX;
    
    private Rigidbody2D rb;

    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move controlls 
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;

            //Animation for jumping

            animator.SetBool("isJumpingAni", true);
        }

        //Rotation of character
        if(moveX > 0)
        {
           transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(moveX < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        //Animation for running
        animator.SetFloat("runSpeed", Mathf.Abs(moveX));

        
       
    }

    //Ground Check
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

            animator.SetBool("isJumpingAni", false);
        }
    }
}
