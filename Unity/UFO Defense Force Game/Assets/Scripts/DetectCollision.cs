using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
public ScoreManager scoreManager; // Store refrence to score manager

public int scoreToGive;

void Start()
{
    scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();// Find ScoreManager gameobject and refrence ScoreManager script component.
}

void OnTriggerEnter(Collider other)// Once the trigger has been entered record colission in the argument variable "Other"
{
    scoreManager.IncreaseScore(scoreToGive);
    Destroy(gameObject); // Destroy this gameobject
    Destroy(other.gameObject); // Destroy the other gameobject it hits

}

}
