using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class box : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject isTest;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("box"))
        {
            if(MiddleManager.ISCOLLEGETESTING == 1){
                MiddleManager.testScoreOfHistory += 100;
                isTest.SetActive(false);
                SceneManager.LoadScene("5_Job");
            }
            else{
                MiddleManager.scoreOfHistory += 100;
                SceneManager.LoadScene("MiddleScene");   
            }
        }
    }
}
