using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Text score;

    // Activates GameOver Screen
    public void Setup() {
        gameObject.SetActive(true);
    }

    // Restarts the game
    public void RestartButton() {
        SceneManager.LoadScene("TheGame");
    }
}
