using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRigidbody;
    private Animator myAnim;
    private SpriteRenderer marioSprite;

    public float speed;
    public int jumpForce;
    public bool isGrounded;
    public LayerMask isGroundLayer;
    public Transform groundCheck;
    public float groundCheckRadius;

    public float powerupTime;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        marioSprite = GetComponent<SpriteRenderer>();

        if (speed <= 0)
        {
            speed = 5.0f;
        }

        if (jumpForce <= 0)
        {
            jumpForce = 100;
        }

        if (!groundCheck)
        {
            Debug.Log("Groundcheck does not exist, please set a transform value for groundcheck");
        }

        if (groundCheckRadius <= 0)
        {
            groundCheckRadius = 0.01f;
        }
    }

    // Update is called once per frame
    void Update()
    {

        float horizontalInput = Input.GetAxisRaw("Horizontal");
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, isGroundLayer);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            myRigidbody.velocity = Vector2.zero;

            myRigidbody.AddForce(Vector2.up * jumpForce);
        }

        myRigidbody.velocity = new Vector2(horizontalInput * speed, myRigidbody.velocity.y);

        myAnim.SetFloat("moveValue", Mathf.Abs(horizontalInput));
        myAnim.SetBool("jump", !isGrounded);

        if (marioSprite.flipX && horizontalInput > 0 || !marioSprite.flipX && horizontalInput < 0 )
            marioSprite.flipX = !marioSprite.flipX;


    }

    public void StartJumpForceChange()
    {
        StartCoroutine(JumpForceChange());
    }

    IEnumerator JumpForceChange()
    {
        jumpForce = 300;
        yield return new WaitForSeconds(powerupTime);
        jumpForce = 150;
        Debug.Log("End of Ienumerator");
    }

}
