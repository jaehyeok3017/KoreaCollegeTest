using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DifferEnglishCheck : MonoBehaviour
{
    public int englishScore = 0;
    public GameObject presentImage; 
    public GameObject isTest;
    public GameObject Not;
    public GameObject Answer;
    public GameObject Mother;

    // Start is called before the first frame update
    void Start()
    {
        englishScore = 0;
        timerStart(5);

        int ansNum = Random.Range(3, 31);

        for(int i = 0; i < 8; i++){
            for(int j = 0; j < 8; j++){
                if(i*9+j == ansNum){
                    GameObject M = Instantiate(Answer, new Vector3(120*i - 120*3.5f,120*j - 120*4,0), Quaternion.identity);
                    M.transform.SetParent(Mother.transform, false);
                }
                else{
                    GameObject M = Instantiate(Not, new Vector3(120*i - 120*3.5f,120*j - 120*4,0), Quaternion.identity);
                    M.transform.SetParent(Mother.transform, false);
                }
            }
        }

        if(MiddleManager.ISCOLLEGETESTING == 1){
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
            if(limitTime < 0)
            {
                int junk = Random.Range(0, 600);

                if(MiddleManager.ISCOLLEGETESTING == 1){
                    if(junk >= MiddleManager.scoreOfEnglish){
                        MiddleManager.testScoreOfEnglish += 100;
                    } 
                    isTest.SetActive(false);
                    SceneManager.LoadScene("4_History");
                }
                else{
                    if(junk >= MiddleManager.scoreOfEnglish){
                        MiddleManager.scoreOfEnglish += 100;
                    } 
                    SceneManager.LoadScene("MiddleScene");
                }
            }
        }
    }

    public void gameReset(bool check)
    {
        if (check)
        {
            englishScore = 100;

            if(MiddleManager.ISCOLLEGETESTING == 1){
                MiddleManager.testScoreOfEnglish += englishScore;
                SceneManager.LoadScene("4_History");
                isTest.SetActive(false);
            }
            else{
                MiddleManager.scoreOfEnglish += englishScore;
                SceneManager.LoadScene("MiddleScene");
            }
        }
    }
}
