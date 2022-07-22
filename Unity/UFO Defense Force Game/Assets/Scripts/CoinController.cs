using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinController : MonoBehaviour
{
    public GameObject[] coinPrefabs; //Array to store coins
    private float spawnRangeX = 20f;

    private float spawnPosZ = 20f;

    private float startDelay = 8f;

    private float spawnInterval = 5f;


    void Start()
    {
        InvokeRepeating("SpawnRandomCoin", startDelay, spawnInterval);
    }
    


    // Update is called once per frame
    void Update()

    {

        
    }
    void SpawnRandomCoin()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ); // Spawn Coin at random location
        int coinIndex = Random.Range(0,coinPrefabs.Length); //Pick a random Object fom the array
        Instantiate(coinPrefabs[coinIndex],spawnPos,coinPrefabs[coinIndex].transform.rotation); //Spawns a indexed Objectfrom the array

    }
}








/*{
private float coin = 0;

public TextMeshProUGUI textCoins;

private void OnTriggerEnter(Collider collision)
{
    if (collision.tag == "Coin")
    {
        coin++;
        textCoins.text =  coin.ToString();
        Destroy(collision.gameObject);
    }
    print("Coin Collected!");
}


}*/