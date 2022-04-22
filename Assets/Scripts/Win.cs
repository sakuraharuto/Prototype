using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem effect;
    public GameObject Key;
    public bool a = false;

    public void Update()
    {
        a = Key.GetComponent<GettingKey>().keygot;
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (a == true){
                Debug.Log("You Win");
                effect.Play();
                source.PlayOneShot(clip);
                Invoke("ReloadScene", delayTime);
        }
    }
    

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
