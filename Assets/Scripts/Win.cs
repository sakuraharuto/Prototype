using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem effect;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player"){
            Debug.Log("You Win");
            effect.Play();

            Invoke("ReloadScene", delayTime);
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
