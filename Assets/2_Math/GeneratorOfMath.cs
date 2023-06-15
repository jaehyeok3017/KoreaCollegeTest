using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GeneratorOfMath : MonoBehaviour
{
    public List<GameObject> objectsListOfMath = new List<GameObject>();
    private List<GameObject> objectRel = new List<GameObject>();


    PlayerMoveOfMath playerMoveOfMath;
    void Start()
    {
        playerMoveOfMath = GameObject.Find("Player").GetComponent<PlayerMoveOfMath>();
    }

    int time = 0;
    private int numOfObjInField = 0;
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        time++;



        if(time%20 == 0 && numOfObjInField < 60){
            objectRel.Add(Instantiate(objectsListOfMath[numOfObjInField%20]));

            if(numOfObjInField%3==0){
                objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-1330, 1330)/100,4);
            }
            else if(numOfObjInField%3==1){
                objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-1330, 1330)/100,-3.5f);
            }
            else{
                objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-1330, 1330)/100,-3.5f);
            }

            objectRel[numOfObjInField].transform.localScale = objectRel[numOfObjInField].transform.localScale * 1.7f;
            numOfObjInField++;
        }

        if(numOfObjInField>=60 && time>=1470){
            MiddleManager.scoreOfMath += playerMoveOfMath.scoreOfMath;
            SceneManager.LoadScene("MiddleScene");
        }

        for(int i = 0; i < numOfObjInField; i++){
            if(i%3==0){
                objectRel[i].transform.position += new Vector3(0,-0.6f, 0);
            }
            else if(i%3==1){
                objectRel[i].transform.position += new Vector3(0.4f,0, 0);
            }
            else{
                objectRel[i].transform.position += new Vector3(-0.4f,0, 0);
            }
            objectRel[i].transform.Rotate(0f, 0f, 7f);
        }
    }
}
