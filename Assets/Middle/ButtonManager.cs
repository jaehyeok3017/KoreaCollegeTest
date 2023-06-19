using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public GameObject Canvas;
    
    public void OnClick(int num){
        MiddleManager.numOfStudy+=1;

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
