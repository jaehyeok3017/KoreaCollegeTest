using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratorOfKorean : MonoBehaviour
{
    public List<GameObject> objectsList = new List<GameObject>();
    private List<GameObject> objectRel = new List<GameObject>();

    public GameObject IsTest;

    PlayerMoveOfKorean playerMoveOfKorean;

    // Start is called before the first frame update
    void Start()
    {
        playerMoveOfKorean = GameObject.Find("Player").GetComponent<PlayerMoveOfKorean>();

        if(MiddleManager.ISCOLLEGETESTING == 1){
            IsTest.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int numOfObjInField = 0;
    int time = 0;

    void FixedUpdate(){
        time++;

        if(time%55 == 0 && numOfObjInField < 20){
            objectRel.Add(Instantiate(objectsList[Random.Range(0, 29)]));
            objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-680, 680)/100,20);
            objectRel[numOfObjInField].transform.localScale = objectRel[numOfObjInField].transform.localScale * 1.3f;
            numOfObjInField++;
        }

        if(numOfObjInField>=20 && time>=1300){ //게임 끝
            if(MiddleManager.ISCOLLEGETESTING == 0){
                MiddleManager.scoreOfKorean += playerMoveOfKorean.scoreOfKorean;
                SceneManager.LoadScene("MiddleScene");
            }
            else if(MiddleManager.ISCOLLEGETESTING == 1){
                MiddleManager.testScoreOfKorean += playerMoveOfKorean.scoreOfKorean;
                IsTest.SetActive(false);
                SceneManager.LoadScene("2_Math");
            }
        }

        for(int i = 0; i < numOfObjInField; i++){
            objectRel[i].transform.position += new Vector3(0,-0.6f, 0);
            objectRel[i].transform.Rotate(0f, 0f, 7f);
        }
    }

}
