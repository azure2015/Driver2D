using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColour = new Color32(255,255,255,255);
    [SerializeField] Color32 noPackageColour = new Color32(255,255,255,255);
    [SerializeField] float destroyDelay = 0.25f;

    SpriteRenderer spriteRenderer;

    bool hasPackage;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();  
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Debug.Log("We hit something!!!");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If package then print to debug log
        if(collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("We hit a package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColour;
            Destroy(collision.gameObject,destroyDelay);
            
        } else if(collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("We hit a customer");
            hasPackage = false;
            spriteRenderer.color = noPackageColour;
        }

    }
}
