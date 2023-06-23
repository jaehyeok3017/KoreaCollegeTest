using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ANS : MonoBehaviour
{

    public int isAnswer = 0;

    ClickManager ClickManager;

    // Start is called before the first frame update
    void Start()
    {
        ClickManager = GameObject.Find("problemEditManager").GetComponent<ClickManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        Debug.Log(isAnswer);
        ClickManager.Game(isAnswer);
    }
}
