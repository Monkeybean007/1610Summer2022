using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Text Mesh Pro added to access librarys.
public class ScoreManager : MonoBehaviour
{

    public int score; //keeps our score value

    public TextMeshProUGUI scoreText; // Visual Text Element to be modified

    public void IncreaseScore(int amount)// Increases score by predetermined amount set in score score variable
    {
        score =+ amount;
        UpdateScoreText();

    }

    public void DecreaseScore(int amount) // Decreased the score by predetermined amount set in score variable
    {
        score =+ amount;
        UpdateScoreText();

    }

    public void UpdateScoreText() // This method updates the score in the HUD UI Text.
    {
        scoreText.text = "Score:"+ score;
    }

}
