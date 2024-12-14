using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float playerScore = 0f;

    public void UpdateScore(float amount)
    {
        playerScore += amount;
        scoreText.text = "Score: " + Mathf.RoundToInt(playerScore).ToString();
    }
}
