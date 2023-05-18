using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public GameObject Camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // 좌우 이동 처리
        float moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // 점프 처리
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }

        if(transform.position.y > 0){
            Camera.transform.position = new Vector3(0, transform.position.y, -10);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥과 충돌 시 점프 가능 상태로 변경
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
