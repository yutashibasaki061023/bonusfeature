using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchcamera : MonoBehaviour
{
    public Camera camera01;
    public Camera camera02;
    private bool cameraactive =true;//現在アクティブなカメラ

    // Start is called before the first frame update
    void Start()
    {
    //最初のカメラのみを有効にする
     camera01.enabled=true;
     camera02.enabled=true;  
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z)){
            cameraactive = !cameraactive;
            camera01.enabled = cameraactive;
            camera02.enabled=!cameraactive;
        }
    }
}
