using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Text scoreOfKorean;
    public Text scoreOfMath;
    public Text scoreOfEnglish;
    public Text scoreOfHistory;
    public Text scoreOfJob;
    public Text scoreOfArab;
    public Text Num;
    public Text Month;

    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if(MiddleManager.numOfStudy/2+1 == 4){
            SceneManager.LoadScene("CollegeTest1");

            Canvas.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(MiddleManager.ISCOLLEGETESTING == 0){
            scoreOfMath.text = MiddleManager.scoreOfMath.ToString() + "점";
            scoreOfKorean.text = MiddleManager.scoreOfKorean.ToString() + "점";
            scoreOfEnglish.text = MiddleManager.scoreOfEnglish.ToString() + "점";
            scoreOfHistory.text = MiddleManager.scoreOfHistory.ToString() + "점";
            scoreOfJob.text = MiddleManager.scoreOfJob.ToString() + "점";
            scoreOfArab.text = MiddleManager.scoreOfArab.ToString() + "점";

            Num.text = (MiddleManager.numOfStudy%2).ToString()+"/2";
            Month.text = (MiddleManager.numOfStudy/2+1).ToString()+"월";
        }
    }
}
