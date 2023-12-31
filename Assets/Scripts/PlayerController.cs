using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    [SerializeField] float speed = 5.0f;
    private const float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    public Camera maincamera;
    public Camera hoodCamera;
    public KeyCode switchKey;
    public string inputID;



    // Update is called once per frame
  

    void FixedUpdate()
    {
        //This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);


        // move the vehicle forward

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        // We turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        if(Input.GetKeyDown(switchKey)) { maincamera.enabled = !maincamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }
        
        

    }
}
