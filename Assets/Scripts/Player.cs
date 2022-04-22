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
    CapsuleCollider2D TD;
    Animator myAnimator;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //bc2d = GetComponent<CircleCollider2D>();
        TD = GetComponent<CapsuleCollider2D>();
        myAnimator = GetComponent<Animator>();

    }

    void Update()
    {
        if (PauseManager.paused)
        {
            return; // Do nothing when the game is paused
        }
        PlayerRun();
        FlipScript();
    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void OnJump(InputValue value)
    {
        if (TD.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            if (value.isPressed)
            {
                rb2d.velocity += new Vector2(0f, jumpSpeed);
            }
        }

    }

    void PlayerRun()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, rb2d.velocity.y);
        rb2d.velocity = playerVelocity;
        bool playerHasHoriontalSpeed = Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("is running", playerHasHoriontalSpeed);
    }

    void FlipScript()
    {

        bool playerHasHoriontalSpeed = Mathf.Abs(rb2d.velocity.x) > Mathf.Epsilon;
        if (playerHasHoriontalSpeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(rb2d.velocity.x), 1f);
        }

    }

}
