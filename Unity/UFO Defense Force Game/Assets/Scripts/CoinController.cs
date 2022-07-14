using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinController : MonoBehaviour
{
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


}