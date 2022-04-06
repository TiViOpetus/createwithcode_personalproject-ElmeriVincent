using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public Text score;
    [SerializeField] public Text highScore;

    // Activates GameOver Screen and displays the score values.
    public void Setup(int scoreAmount) {
        gameObject.SetActive(true);
        score.text = scoreAmount.ToString()+" SP";
        highScore.text = "HighScore: " + PlayerPrefs.GetInt("HighScore", 0).ToString() + " SP";
    }

    // Restarts the game
    public void RestartButton() {
        SceneManager.LoadScene("TheGame");
    }

    // Takes player back to main screen
    public void MainScreenButton() {
        SceneManager.LoadScene("MainMenu");
    }

    // Starts the game when player press the start button.
    public void StartGameButton() {
        SceneManager.LoadScene("TheGame");
    }

    // Resets the highest score
    public void Reset() {
        PlayerPrefs.DeleteKey("HighScore");
        highScore.text = "HighScore: 0 SP";
    }
}
