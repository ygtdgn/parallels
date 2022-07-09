using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket1 : MonoBehaviour
{
public int Speed;
    public int jumpSpeed;



  


    Rigidbody2D rb;


    bool canJump = true;

    bool faceRight = true;

    Vector2 forward;
    Animator animator;
    public Vector3 offset;

    RaycastHit2D hit;
    private void Start()
    {
        animator = GetComponent<Animator>(); 
        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * Speed, rb.velocity.y);
        if (moveInput > 0 || moveInput < 0)
        {
            animator.SetBool("isRunning", true);

        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (faceRight == true && moveInput < 0)
        {
            Flip();
        }
        else if (faceRight == false && moveInput > 0)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            animator.SetTrigger("fall");

        }
       

       

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        canJump = true;

    }


    private void Jump()
    {
        if (canJump)
        {
            rb.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
        }
        animator.SetTrigger("jump");

    }
    

    void Flip()
    {
        faceRight = !faceRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
