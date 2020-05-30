using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    #region Variables
    // Types of balls
    public GameObject[] ballz;
    // Quantity of balls on the screen
    public int ballzQuantity;
    // Position of generation of balls
    public float xRandPos;
    public float yPos;
    // Score text
    public Text theScoreText;
    // Score count
    public int score;
    
    // Checks if score has changed
    bool _scoreChanged;
    
    #endregion
    private void Start()
    {
        // Instantiate balls with it's quantity and range
        for(int i = 0; i < ballzQuantity; i++)
        {
            Instantiate(ballz[Random.Range(0, ballz.Length)], new Vector3( Random.Range(-xRandPos, xRandPos), Random.Range(6f, yPos), 0f), Quaternion.identity);
        }
       
    }

    // If score is changed update scoreText
    private void Update()
    {
        if(_scoreChanged)
        {
            theScoreText.text = "Score: " + score;
        }
    }
    // Updates score
    public void updateScore()
    {
        score++;
        _scoreChanged = true;
    }
    
}
