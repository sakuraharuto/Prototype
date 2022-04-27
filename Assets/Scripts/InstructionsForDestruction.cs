using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionsForDestruction : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip clip;
    bool hasPlayed = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (!hasPlayed)
        {
            audioSource.PlayOneShot(clip);
            hasPlayed = true;
        }
        Destroy(gameObject, 1.5f);

    }


}
