using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 25;
    public float xRange = 30;
    public Transform blaster;
    public GameObject lazerbolt;
    private int Coin;
    
   
    void Update()
    {
        //Set Horiztonal input to get values from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Moves player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        
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

        //If spacebar is pressed fire lazerbolt.
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Create LazerBolt at blaster transform position, maintaning the objects rotation.
            Instantiate(lazerbolt, blaster.transform.position, lazerbolt.transform.rotation );
        }
    }
   
        //Destroy Object Hitten by Lazer, with a trigger.
         private void OnTriggerEnter(Collider other)
        {
            Destroy(other.gameObject);
        }
        
    }
