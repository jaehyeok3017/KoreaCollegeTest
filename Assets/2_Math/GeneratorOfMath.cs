using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorOfMath : MonoBehaviour
{
    public List<GameObject> objectsListOfMath = new List<GameObject>();
    private List<GameObject> objectRel = new List<GameObject>();

    void Start()
    {
        
    }

    int time = 0;
    private int numOfObjInField = 0;
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        time++;



        if(time%80 == 0 && numOfObjInField < 20){
            objectRel.Add(Instantiate(objectsListOfMath[numOfObjInField]));

            //objectRel[numOfObjInField].transform.position = new Vector2(Random.Range(-680, 680)/100,20);
            //objectRel[numOfObjInField].transform.localScale = objectRel[numOfObjInField].transform.localScale * 1.3f;
            numOfObjInField++;
        }

        for(int i = 0; i < numOfObjInField; i++){
            //objectRel[i].transform.position += new Vector3(0,-0.6f, 0);
            //objectRel[i].transform.Rotate(0f, 0f, 7f);
        }
    }
}
