using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAna : MonoBehaviour
{
    public GameObject kapi1;

    public bool ison1 = false;

 public Sprite on;
    public Sprite off;

    private void Start()
    {

    }
    private void Update()
    {
         if (ison1 == true)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = on;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = off;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && kapi1)
            ison1 = true;

        
        calis();

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && kapi1)
            ison1 = false;

    }

    void calis()
    {
        if (ison1 == true )
        {
                    SceneManager.LoadScene(1);
            
        }
    }
}

