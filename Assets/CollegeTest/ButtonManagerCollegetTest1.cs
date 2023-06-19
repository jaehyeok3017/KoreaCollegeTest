using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManagerCollegetTest1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick(){
        MiddleManager.ISCOLLEGETESTING = 1;
        SceneManager.LoadScene("1_Korean");
    }
}
