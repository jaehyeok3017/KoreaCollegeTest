using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public string answer;
    public bool isAnswer;

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            if (isAnswer)
            {
                DifferEnglishCheck.gameReset(true);
            }

            else
            {
                DifferEnglishCheck.gameReset(false);
            }
        }

    }
}
