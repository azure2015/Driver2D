using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{


    public void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Trigger HIT!!!"); 
    }
}
