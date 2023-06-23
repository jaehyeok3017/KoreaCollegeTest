using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class CardOfArab : MonoBehaviour
{
    public bool isAnswer;

    DifferEnglishCheckOfArab DifferEnglishCheckOfArab;
    void Start()
    {
        DifferEnglishCheckOfArab = GameObject.Find("Manager").GetComponent<DifferEnglishCheckOfArab>();
    }
    void Update()
    {

    }
    public void OnClick(){
        if(isAnswer){
            DifferEnglishCheckOfArab.gameReset(true);
        }
        else{
            DifferEnglishCheckOfArab.gameReset(false);
        }
    }
}
