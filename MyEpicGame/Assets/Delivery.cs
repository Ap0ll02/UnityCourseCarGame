using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   bool hasPackage = false;
   [SerializeField] Color32 hasPackColor = new Color32 (0,200,137,255);
   [SerializeField] Color32 normColor = new Color32 (220,0,187,255);
    SpriteRenderer spriteRen;
   [SerializeField] float delayDestroy = 0.5f;

    void Start(){
        spriteRen = GetComponent<SpriteRenderer>();
    }
   void OnTriggerEnter2D(Collider2D other)
   {
        if(other.tag == "Package" && !hasPackage){
         hasPackage = true;
         spriteRen.color = hasPackColor;
         Destroy(other.gameObject, delayDestroy);
        }
        else if(other.tag == "Customer" && hasPackage){
            Debug.Log("Package Delivered");
            spriteRen.color = normColor;
            hasPackage = false;
        }
   }
}
