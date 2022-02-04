using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   

    [SerializeField] float moveSpeed = 5f;
    Rigidbody2D rb2d;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {   
        float x = Input.GetAxis("Horizontal");
        //float y = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(x, 0, 0);

        moveVector = moveVector.normalized * moveSpeed * Time.deltaTime;

        rb2d.MovePosition(rb2d.transform.position + moveVector);

        // Use rigidbody instead
        /*
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.LeftArrow)){
            transform.position += Vector3.left *moveSpeed * Time.deltaTime;
        }
        */
    }
}
