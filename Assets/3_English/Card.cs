using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour
{
    public bool isAnswer;

    DifferEnglishCheck DifferEnglishCheck;
    void Start()
    {
        DifferEnglishCheck = GameObject.Find("Manager").GetComponent<DifferEnglishCheck>();
    }
    void Update()
    {

    }
    public void OnClick(){
        if(isAnswer){
            DifferEnglishCheck.gameReset(true);
        }
        else{
            DifferEnglishCheck.gameReset(false);
        }
    }
}
