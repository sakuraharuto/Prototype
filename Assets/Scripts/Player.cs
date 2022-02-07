using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//check
//check
public class Player : MonoBehaviour
{   

    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpSpeed = 5f;
    Rigidbody2D rb2d;
    CircleCollider2D bc2d;
    Vector2 moveInput;
    BoxCollider2D TD;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //bc2d = GetComponent<CircleCollider2D>();
        TD = GetComponent<BoxCollider2D>();

    }

    void Update()
    {   
        PlayerRun();
    }

    void OnMove(InputValue value){
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void OnJump(InputValue value){
        if(TD.IsTouchingLayers(LayerMask.GetMask("Ground"))){
            if(value.isPressed){
            rb2d.velocity += new Vector2(0f, jumpSpeed);
            }
        } 
    }

    void PlayerRun(){
        Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, rb2d.velocity.y);
        rb2d.velocity = playerVelocity;
    }
}
