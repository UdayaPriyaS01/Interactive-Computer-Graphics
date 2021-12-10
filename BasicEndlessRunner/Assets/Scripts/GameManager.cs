using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

    int score;
    static int lives = 3;
    public static GameManager inst;

    [SerializeField] Text scoreText;
    [SerializeField] Text LivesText;
    [SerializeField] Text GameoverText;

    [SerializeField] PlayerMovement playerMovement;

    public void IncrementScore ()
    {
        score++;
        scoreText.text = "SCORE: " + score;
        // Increase the player's speed

        if (score == 25)
        {
            DisplayGameover();

        }

        playerMovement.speed += playerMovement.speedIncreasePerPoint;
    }

    public int DecrementLives()
    {
        lives--;
        LivesText.text = "LIVES LEFT: " + lives;

        return lives;
    }

    public void DisplayGameover()
    {
        if (lives > 0)
        {
             GameoverText.text = "YOU WIN!!";
        }
        else
        {
            GameoverText.text = "GAME OVER!!";
        }
        
    }

    private void Awake ()
    {
        inst = this;
    }

    private void Start () {

	}

	private void Update () {

    }
}