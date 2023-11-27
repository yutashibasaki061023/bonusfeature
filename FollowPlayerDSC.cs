using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerDSC : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset02 = new Vector3(0,2,1);
    private float Turnspeed=45.0f;
    private float horizontalinput02;

    //public Camera camera1;
    //public Camera camera2;
    //private int currentcameraindex=0;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    // void Update()
    // {
    //     if(Input.GetKeyDown(KeyCode.Z)){
    //         cameras[currentcameraindex].gameObject.SetActive(false);
    //         currentcameraindex=(currentcameraindex+1)%cameras.Length;
    //         cameras[currentcameraindex].gameObject.SetActive(true);
    //     }
    // }

     void LateUpdate()
    {
        
        transform.position = player.transform.position + offset02;
        horizontalinput02 = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up,horizontalinput02*Time.deltaTime*Turnspeed);
        //transform.rotation =player.transform.rotation horizontalinput02 +offset02;
    }
}
