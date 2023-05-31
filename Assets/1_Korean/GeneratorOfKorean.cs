using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorOfKorean : MonoBehaviour
{
    public List<GameObject> objectsList = new List<GameObject>();
    private List<GameObject> objectRel = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int numOfObjInField = 0;
    int time = 0;

    void FixedUpdate(){
        time++;

        if(time%80 == 0 && numOfObjInField < 20){
            objectRel.Add(Instantiate(objectsList[Random.Range(1, 29)]));
            objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-680, 680)/100,20);
            objectRel[numOfObjInField].transform.localScale = objectRel[numOfObjInField].transform.localScale * 1.3f;
            numOfObjInField++;
        }

        for(int i = 0; i < numOfObjInField; i++){
            objectRel[i].transform.position += new Vector3(0,-0.6f, 0);
            objectRel[i].transform.Rotate(0f, 0f, 7f);
        }
    }

}
