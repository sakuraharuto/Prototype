using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingKey : MonoBehaviour
{
    public bool keygot = false;
    public Component key;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;

    public void OnCollisionEnter2D(Collision2D other) 
    {
        keygot = true;
        audioSource.PlayOneShot(clip);
        //Destroy(gameObject);
        key.GetComponent<BoxCollider2D>().enabled = false;
        key.GetComponent<SpriteRenderer>().enabled = false;
    }
        
    
}
