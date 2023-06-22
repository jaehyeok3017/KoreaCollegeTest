using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class DifferEnglishCheck : MonoBehaviour
{
    public Sprite changeImage;
    public int englishScore = 0;

    public List<GameObject> imgList = new List<GameObject>();
    public GameObject presentImage;


    // Start is called before the first frame update
    void Start()
    {
        englishScore = 0;
        timerStart(5);
    }

    public Image img;
    public Sprite afterImg;

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
            if(limitTime < 0)
            {
                SceneManager.LoadScene("MiddleScene");
            }
        }
    }

    public void gameReset(bool check)
    {
        if (check)
        {
            englishScore = 100;
            MiddleManager.scoreOfEnglish += englishScore;
            SceneManager.LoadScene("MiddleScene");
        }
    }
}
