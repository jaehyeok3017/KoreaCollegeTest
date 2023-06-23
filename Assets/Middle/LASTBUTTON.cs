using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LASTBUTTON : MonoBehaviour
{

    public List<GameObject> imgListOfEnd = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick() {
        int score = MiddleManager.testScoreOfKorean + MiddleManager.testScoreOfMath + MiddleManager.testScoreOfEnglish + MiddleManager.testScoreOfHistory
        +MiddleManager.testScoreOfJob + MiddleManager.testScoreOfArab;

        int judge = score/42;

        imgListOfEnd[judge].SetActive(true);
    }
}
