using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Text _coinText;
    public void updateCoinDisplay(int coins)
    {
        _coinText.text = "Coins:" + coins;
    }
}