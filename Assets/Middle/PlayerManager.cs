using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Text scoreOfKorean;
    public Text scoreOfMath;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scoreOfMath.text = MiddleManager.scoreOfMath.ToString() + "점";
        scoreOfKorean.text = MiddleManager.scoreOfKorean.ToString() + "점";
    }
}
