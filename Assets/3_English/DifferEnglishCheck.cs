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
        cardChange();
        timerStart(5);
    }

    public Image img;
    public Sprite afterImg;

    void cardChange()
    {
        System.Random rand = new System.Random(); 
        
        Sprite[] sprites = Resources.LoadAll<Sprite>("images");
        int index = rand.Next(16);
        imgList.sprite = sprites[index];

        for (int i = 0; i < 16; i++)
        {
            if (randNum == i)
            {
                imgList[i].sprite = afterImg;
            }

            else
            {

            }
        }
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
            if(limitTime < 0)
            {
                gameReset();
            }
        }
    }

    void correctImageClicked(int alongSec)
    {
        englishScore += 20;
        gameReset();
    }

    void wrongImageClicked(int alongSec)
    {
        gameReset();
    }

    void gameReset()
    {
        SceneManager.LoadScene("MiddleScene");
    }
}
