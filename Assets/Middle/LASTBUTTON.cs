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
        float score = MiddleManager.testScoreOfKorean * 1.8f + MiddleManager.testScoreOfMath *2.4f + MiddleManager.testScoreOfEnglish * 0.6f 
        + MiddleManager.testScoreOfHistory * 0.3f +MiddleManager.testScoreOfJob * 0.6f + MiddleManager.testScoreOfArab * 0.3f;

        int judge = (int)(score/42);

        imgListOfEnd[judge].SetActive(true);
    }
}
