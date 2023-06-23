using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerOfEnd : MonoBehaviour
{

    public Text scoreOfKorean;
    public Text scoreOfMath;
    public Text scoreOfEnglish;
    public Text scoreOfHistory;
    public Text scoreOfJob;
    public Text scoreOfArab;

    // Start is called before the first frame update
    void Start()
    {
        scoreOfKorean.text = MiddleManager.testScoreOfKorean.ToString() + "점";
        scoreOfMath.text = MiddleManager.testScoreOfMath.ToString() + "점";
        scoreOfEnglish.text = MiddleManager.testScoreOfEnglish.ToString() + "점";
        scoreOfHistory.text = MiddleManager.testScoreOfHistory.ToString() + "점";
        scoreOfJob.text = MiddleManager.testScoreOfJob.ToString() + "점";
        scoreOfArab.text = MiddleManager.testScoreOfArab.ToString() + "점";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
