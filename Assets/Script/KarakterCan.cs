using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterCan : MonoBehaviour
{
    public PnlControl control;
    public int health = 1;

    private void Start()
    {

    }
    public void TakeDamage()
    {
        health -= 1;

    }
    private void Update()
    {
        if (health <= 0)
        {
            
            control.kaybettin();
            Time.timeScale = 0.0f;
            
        }
    }
}
