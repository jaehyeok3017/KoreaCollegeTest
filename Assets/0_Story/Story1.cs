using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour
{
    public Sprite[] sprites;
    int clickCnt = 1;
    int maxCnt;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("ImageChange").GetComponent<Image>().sprite = sprites[0];
        maxCnt = sprites.Length - 1;
    }

    public void screenClick(){
        clickCnt++;
        if(clickCnt > maxCnt) SceneManager.LoadScene("MiddleScene");
        else GameObject.Find("ImageChange").GetComponent<Image>().sprite = sprites[clickCnt];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
