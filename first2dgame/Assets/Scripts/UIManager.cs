using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Sprite[] lives;
    public Image livesImages;
    public int score;
    public Text scoreText;

    public void UpdateLives(int currentLives)
    {
        livesImages.sprite = lives[currentLives];
    }

    public void UpdateScore()
    {
         score += 10;
         scoreText.text = "Score: " + score;
    }
    
}
