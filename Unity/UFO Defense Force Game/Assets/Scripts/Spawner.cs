using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject objectToSpawn;
    public GameObject spawnToObject;




    void Start()
    {
        Instantiate(objectToSpawn);
    }

    void Update()
    {

    }



}
   