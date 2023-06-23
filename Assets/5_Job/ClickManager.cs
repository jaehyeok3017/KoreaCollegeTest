using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject isTest;

    void Start()
    {
        timerStart(10);
        if(MiddleManager.ISCOLLEGETESTING == 1)
        {
            isTest.SetActive(true);
        }
    }

    float limitTime;
    bool timer = false;
    void timerStart(int sec)
    {
        limitTime = 4;
        timer = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer)
        {
            limitTime -= Time.deltaTime;
            if (limitTime < 0)
            {
                if (MiddleManager.ISCOLLEGETESTING == 1)
                {
                    SceneManager.LoadScene("6_Arab");
                    isTest.SetActive(false);
                }
                else
                {
                    SceneManager.LoadScene("MiddleScene");
                }
            }
        }
    }
    public void Game(int X)
    {
        if (X == 1)
        {
            if (MiddleManager.ISCOLLEGETESTING == 1)
            {
                MiddleManager.testScoreOfJob += 100;
                SceneManager.LoadScene("6_Arab");
                isTest.SetActive(false);
            }
            else
            {
                MiddleManager.scoreOfJob += 100;
                SceneManager.LoadScene("MiddleScene");
            }
        }
        else
        {
            if (MiddleManager.ISCOLLEGETESTING == 1)
            {
                SceneManager.LoadScene("6_Arab");
                isTest.SetActive(false);
            }
            else
            {
                SceneManager.LoadScene("MiddleScene");
            }
        }
    }
}
