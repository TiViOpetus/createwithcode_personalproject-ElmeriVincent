using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] public Text score;

    // Activates GameOver Screen
    public void Setup(int scoreAmount) {
        gameObject.SetActive(true);
        score.text = scoreAmount.ToString();
    }

    // Restarts the game
    public void RestartButton() {
        SceneManager.LoadScene("TheGame");
    }
}
