using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleEnemyBeheviour : MonoBehaviour
{
public int speed;
    public int turnDelay;
    public int health;
    public Animator animator;
    public Transform target;
    public int TEPBetween;
    

    bool faceRight = false;
    bool canDead;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(SwitchDirection());
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
    }
    private void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, target.position) > 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, TEPBetween * Time.deltaTime);
        }
    }

     IEnumerator SwitchDirection()
     {
     yield return new WaitForSeconds(turnDelay);
      Switch();
     }

    private void Switch()
    {
       faceRight = !faceRight;
       Vector3 scaler = transform.localScale;
       scaler.x *= -1;
       transform.localScale = scaler;
    
       speed *= -1;
        StartCoroutine(SwitchDirection());
     }

    public void TakeDamage(int amount)
    {
        rb.AddForce(Vector2.right * 200);

        health -= amount;

        if (health <= 0)
        {
            StartCoroutine(Dead());
        }
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.GetComponent<KarakterCan>().TakeDamage();
    }

    private void Dead2()
    {
        
        Destroy(gameObject);
        
    }
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.0f);
        
        Dead2();
    }
}
