using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class College1TestManager : MonoBehaviour
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
        if(MiddleManager.ISCOLLEGETESTING == 0){
            scoreOfMath.text = MiddleManager.scoreOfMath.ToString() + "점";
            scoreOfKorean.text = MiddleManager.scoreOfKorean.ToString() + "점";
            scoreOfEnglish.text = MiddleManager.scoreOfEnglish.ToString() + "점";
            scoreOfHistory.text = MiddleManager.scoreOfHistory.ToString() + "점";
            scoreOfJob.text = MiddleManager.scoreOfJob.ToString() + "점";
            scoreOfArab.text = MiddleManager.scoreOfArab.ToString() + "점";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
