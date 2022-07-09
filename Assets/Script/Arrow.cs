using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    public float Speed = 20f;
    public Rigidbody2D rb;
    public int damage = 1;

    void Start()
    {

        rb.velocity = transform.right * Speed;

    }

    private void OnTriggerEnter2D(Collider2D hitInfo) {
        SimpleEnemyBeheviour enemy = hitInfo.GetComponent<SimpleEnemyBeheviour>();

        if (enemy != null)
        {
            enemy.TakeDamage(1);
        }

        Destroy(gameObject);
    }


}
