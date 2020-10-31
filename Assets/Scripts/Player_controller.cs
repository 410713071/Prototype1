using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    public float speed = 0;
    public float turnspeed = 0;
    public float horizontalinput;
    public float verticalinput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
        verticalinput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward*Time.deltaTime* verticalinput* speed);
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalinput* turnspeed);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalinput * turnspeed);
    }
}
