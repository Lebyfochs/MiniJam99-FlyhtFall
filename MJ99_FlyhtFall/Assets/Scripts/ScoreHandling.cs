using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandling : MonoBehaviour
{

    public int playerScore;
    public Text scoreText;
   
    
    void Start()
    {
        playerScore = 0;
       
    }

    
    void Update()
    {
        
    }

    public void addScore()
    {
        playerScore += 10;
        scoreText.text = playerScore.ToString() + "Score";
    }
}
