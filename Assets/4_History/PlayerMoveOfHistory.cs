using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMoveOfHistory : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    private bool isJumping = false;
    private Rigidbody2D rb;
    public GameObject Camera;
    public GameObject isTest;
    box box;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if(MiddleManager.ISCOLLEGETESTING == 1){
            isTest.SetActive(true);
        }
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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            int junk = Random.Range(0, 600);

            if(MiddleManager.ISCOLLEGETESTING == 1){
                if(junk <= MiddleManager.scoreOfHistory){
                    MiddleManager.testScoreOfHistory += 100;
                } 
                isTest.SetActive(false);
                SceneManager.LoadScene("5_Job");
            }
            else{
                if(junk <= MiddleManager.scoreOfHistory){
                    MiddleManager.scoreOfHistory += 100;
                } 
                SceneManager.LoadScene("MiddleScene");
            }
        }

        if (transform.position.y > 0){
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
