using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class problem : MonoBehaviour
{
    public int jobScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        timerStart(10);
    }

    public float limitTime;
    public bool timer = false;
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
                SceneManager.LoadScene("MiddleScene");
            }
        }
    }

    public void gameReset(bool check)
    {
        if (check)
        {
            jobScore = 100;
            MiddleManager.scoreOfJob += jobScore;
            SceneManager.LoadScene("MiddleScene");
        }
    }
}
