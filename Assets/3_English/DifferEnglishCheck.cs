using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DifferEnglishCheck : MonoBehaviour
{
    public Sprite changeImage;
    public int englishScore = 0;

    Image presentImage;
    System.Random rand = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        presentImage = GetComponent<Image>();
        timerStart(5);

    }

    void imageChange()
    {
        presentImage.sprite = changeImage;
    }

    void timerStart(int sec)
    {
        
    }

    void correctImageClicked(int alongSec)
    {

    }

    void wrongImageClicked(int alongSec)
    {

    }

    void timeOut(int alongSec)
    {

    }

    void gameReset()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
