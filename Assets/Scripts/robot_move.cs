using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robot_move : MonoBehaviour
{

    float speedX;
    float speedY;
    public float speed;
    Rigidbody2D rb;
    private bool isFacingRight = true;
    public float jump;

    public Transform inGround;
    public LayerMask groundLayer;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Ground check using OverlapCircle (simpler and more accurate)
        isGrounded = Physics2D.OverlapCircle(inGround.position, 0.2f, groundLayer);

        // Debug log to check if ground detection is working
        Debug.Log("isGrounded: " + isGrounded);

        speedX = Input.GetAxisRaw("Horizontal") * speed;

        // Ensure Jump only works when grounded
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jump); // Set jump velocity
        }

        rb.linearVelocity = new Vector2(speedX, rb.linearVelocity.y); // Maintain vertical velocity
        Flip();
    }


    private void Flip()
    {
        if (isFacingRight && speedX > 0f || !isFacingRight && speedX < 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }

    }
}