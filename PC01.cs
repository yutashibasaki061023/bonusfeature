using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC01 : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed=5.0f;
    private float turnSpeed=45.0f;
    private float horizontalinput;
    private float  forwardinput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardinput);
        //transform.Translate(Vector3.right *Time.deltaTime * turnspeed * horizonalinput);
        //Time.deltaTimeはMonoBehavior.FixedUpdateから返された，単位時間のこと．
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalinput);
        //transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalinput);
    }
}
