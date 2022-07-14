using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float speed = 2.5f;

    void Update () 
    {

        transform.position = new Vector3 (Mathf.PingPong(Time.time * speed, 10), transform.position.y, transform.position.z);

    }
}