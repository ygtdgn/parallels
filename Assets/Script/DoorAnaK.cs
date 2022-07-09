using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorAnaK : MonoBehaviour
{
    public GameObject kapi1;

    public bool ison1 = false;

  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player" && kapi1)
            ison1 = true;

        
        calis();

    }


    void calis()
    {
        if (ison1 == true )
        {
                    SceneManager.LoadScene(3);
            
        }


    }
}
