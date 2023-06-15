using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject Canvas;
    public Text Num;
    public Text Month;
    
    public void OnClick(int num){
        if(MiddleManager.numOfStudy == 0 || MiddleManager.numOfStudy == 1 || MiddleManager.numOfStudy == 2){
            MiddleManager.numOfStudy+=1;
            Num.text = MiddleManager.numOfStudy.ToString()+"/3";
        }
        else{ //두자릿수 감안
            Num.text = "0/3";
            MiddleManager.staticMonth+=1;
            Month.text = MiddleManager.staticMonth.ToString()+"월";
        }

        if(num == 0){
            SceneManager.LoadScene("1_Korean");
        }
        else if(num == 1){
            SceneManager.LoadScene("2_Math");
        }
        else if(num == 2){
            SceneManager.LoadScene("3_English");
        }
        else if(num == 3){
            SceneManager.LoadScene("4_History");
        }
        else if(num == 4){
            SceneManager.LoadScene("5_Job");
        }
        else{
            SceneManager.LoadScene("6_Arab");
        }

        Canvas.SetActive(false);
    } 
}
