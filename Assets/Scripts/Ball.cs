using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    #region Variables
    // Bool to check if a ball is clicked
    bool _isClicked;
    GameManager theGameManager;
    #endregion
    private void Start()
    {
        // Gets GameManager
        theGameManager = FindObjectOfType<GameManager>();
    }

    // Checks if a ball is clicked
    private void OnMouseDown()
    {
       _isClicked = true;
    }

    // Checks if the ball is touching another ball with the same color, 
    private void OnCollisionStay2D(Collision2D other)
    {
        if(_isClicked)
        {
            if(other.gameObject.tag == gameObject.tag)
            {
                // If the ball is touching another ball with the same color, destroy it!
                Destroy(gameObject);   
                Destroy(other.gameObject);
                
            }
        }  
    }
    // Updates the score onDestroy
    private void OnDestroy()
    {
        theGameManager.updateScore();
    }
    
    
}
