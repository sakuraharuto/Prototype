using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingKey : MonoBehaviour
{
    public bool keygot = false;
    public Component key;

    public void OnCollisionEnter2D(Collision2D other) 
    {
        keygot = true;
        //Destroy(gameObject);
        key.GetComponent<BoxCollider2D>().enabled = false;
        key.GetComponent<SpriteRenderer>().enabled = false;
    }
        
    
}
