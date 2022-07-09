using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTrigger : MonoBehaviour
{
     public int damage;
    
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            collision.GetComponent<SimpleEnemyBeheviour>().TakeDamage(damage);
        }
        
    }
}
