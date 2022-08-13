using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    //Set Top Bounds to Destroy Bullets
    public float topBounds = 30.0f;

    //Set Bottom Bounds to Destory Bullets
    public float lowerBounds = -10.0f;

    // Start is called before the first frame update
    void Awake()
    {
        //Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy Bullets when they go out of bounds.
        if(transform.position.z > topBounds)
        {
        Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
            Time.timeScale=0;
        }
    }
}
