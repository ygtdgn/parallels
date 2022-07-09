using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wepon : MonoBehaviour
{
   public Transform firePoint;
    public GameObject arrowPrefab;
    Animator animator;
    private void Start() {
                animator = GetComponent<Animator>();
    }
  private void Update() {
     if (Input.GetMouseButtonDown(1))
     {
         Shoot();
     }

     void Shoot(){
        Instantiate(arrowPrefab, firePoint.position, firePoint.rotation);
        animator.SetTrigger("attackA");
     }
 }
 
}
