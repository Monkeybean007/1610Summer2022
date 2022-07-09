using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 30;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        //Set Horiztonal input to get values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        //Keep player within bounds
        //Left side wall
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y, transform.position.z);
        }

        //Right side of Wall
        if(transform.position.x > xRange)
        {
             transform.position = new Vector3(xRange,transform.position.y, transform.position.z);
        }
    }
}
