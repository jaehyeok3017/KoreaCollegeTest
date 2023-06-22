using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public string answer;
    public bool isAnswer;

    DifferEnglishCheck DifferEnglishCheck;

    void Start()
    {
        DifferEnglishCheck = GameObject.Find("Manager").GetComponent<DifferEnglishCheck>();

    }

    public void OnClickButton()
    {
        if (isAnswer)
        {
            DifferEnglishCheck.gameReset(true);
        }

        else
        {
            SceneManager.LoadScene("MiddleScene");
        }
    }

    void Update()
    {
    }
}
