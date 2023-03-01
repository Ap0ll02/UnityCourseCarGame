using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
  [SerializeField] float steerSpeed = 0.1f;
  [SerializeField] float moveSpeed = 11;
  [SerializeField] float slowSpeed = 6f;
  [SerializeField] float boostSpeed = 22f;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
      if(other.tag == "Boost"){
        moveSpeed = boostSpeed;
      }
    }
    void OnCollisionEnter2D(Collision2D other){
      moveSpeed = slowSpeed;
    }
    // Update is called once per frame
    void Update()
    {
      float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
      float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
      transform.Rotate(0,0,-steerAmount);
      transform.Translate(0,moveAmount,0);
      
    }
}
