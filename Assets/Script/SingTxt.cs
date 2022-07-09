using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingTxt : MonoBehaviour
{
public TextMesh myText;

    public string tutorialText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        myText.text = tutorialText;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        myText.text = null;
    }
}
