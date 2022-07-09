using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
public int Speed;
    public int jumpSpeed;



  
public int damage;
    bool canAttack = true;

    Rigidbody2D rb;


    bool canJump = true;

    bool faceRight = true;

    Vector2 forward;

    public Vector3 offset;
    Animator animator;
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

        }
       
        if (Input.GetMouseButtonDown(0))
        {
            Attack();

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
        
       transform.Rotate(0f, 180f, 0f);
    }
    private void Attack()
    {
        canAttack = false;

        if (!faceRight)
        {
            forward = transform.TransformDirection(Vector2.right * -2);
        }
        else
        {
            forward = transform.TransformDirection(Vector2.right * 2);
        }

        animator.SetTrigger("attackS");
        StartCoroutine(AttackDelay());

    }
 IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(0.3f);
        canAttack = true;

    }


}

