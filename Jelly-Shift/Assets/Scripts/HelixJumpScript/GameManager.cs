using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;
public class GameManager : MonoBehaviour
{
    private int score;

    public TextMeshProUGUI scoreText;
    
    
    
    void Start()
    {
        
    }

    public void GameScore(int rscore)
    {
        score += rscore;
        scoreText.text = score.ToString();
    }

    
    void Update()
    {
        
    }
}
