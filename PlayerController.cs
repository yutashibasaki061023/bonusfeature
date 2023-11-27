using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move cehicle forward
        transform.Translate(Vector3.forward);
        //transformはオブジェクトの位置，回転，スケールを扱う．https://docs.unity3d.com/ja/2019.4/ScriptReference/Transform.html
        
    }
}
