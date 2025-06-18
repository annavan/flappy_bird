using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    public TextMeshProUGUI instructions;
    public int score;

    public void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
        //hide game over and score
        gameOver.SetActive(false);
        scoreText.gameObject.SetActive(false);  
        playButton.SetActive(true);  
    }

    public void Play() {
        score = 0;
        scoreText.text = score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        instructions.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        Time.timeScale = 1;
        player.enabled = true;

        //destroy all pipes on screen
        GameObject[] pipes = GameObject.FindGameObjectsWithTag("Pipe");
        foreach (GameObject pipe in pipes) {
            Destroy(pipe);
        }

        //destroy all coins on screen
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        foreach (GameObject coin in coins) {
            Destroy(coin);
        }

    }
    public void Pause() {
        // don't have any update functions work in other scripts
        Time.timeScale = 0;
        player.enabled = false;

    }
    public void GameOver()
    {
        //Debug.Log("Game Over! Final Score: " + score);
        gameOver.SetActive(true);
        playButton.SetActive(true);
        instructions.gameObject.SetActive(true);

        Pause();
    }

    public void Scored()
    {
        score++;
        //Debug.Log("Score: " + score);
        scoreText.text = score.ToString();
    }

    public void CoinScore()
    {
        score += 2;
        //Debug.Log("Coin Score: " + score);
        scoreText.text = score.ToString();
    }
}
