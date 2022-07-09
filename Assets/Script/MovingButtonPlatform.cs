using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingButtonPlatform : MonoBehaviour
{
       public Transform firstPos, secondPos;
    public float speed;
    public Button buton;
    Vector3 nextPos;

    private void Start()
    {
        nextPos = firstPos.position;

    }

    private void Update()
    {
        if (buton.isOn2 == true && transform.position == firstPos.position)
           nextPos = secondPos.position;


        if (buton.isOn2 == false)
            nextPos = firstPos.position;


        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(firstPos.position, secondPos.position);
    }
}
