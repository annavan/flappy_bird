using UnityEngine;
using UnityEngine.SceneManagement;

// when play button is pressed, the game starts and scene changes to the game scene
public class titleScreen : MonoBehaviour
{

    public GameObject playButton;
    public GameObject titleScreenUI;
    // public GameObject testButton;

    //add on start console log
    private void Start()
    {
        // Debug.Log("Title screen loaded!");
        // set time scale to 0 to pause the game
        Time.timeScale = 0;
    }

    public void PlayGame()
    {
        // when play button is pressed, the game starts and scene changes to the game scene
        // Debug.Log("Play button clicked!");
        SceneManager.LoadScene("game");
        playButton.SetActive(false);
        titleScreenUI.SetActive(false);
        // Time.timeScale = 1;
    }
}
