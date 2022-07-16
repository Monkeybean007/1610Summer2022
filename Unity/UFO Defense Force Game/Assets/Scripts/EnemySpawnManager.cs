using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    


    // Update is called once per frame
    void Update()

    {

        if(Input.GetKeyDown(KeyCode.Q))
        {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ); // Spawn UfO ar random location
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); //Pick a random UFO fom the array
        Instantiate(ufoPrefabs[ufoIndex],spawnPos,ufoPrefabs[ufoIndex].transform.rotation); //Spawns a indexed UFO from the array
        }
    }
}
