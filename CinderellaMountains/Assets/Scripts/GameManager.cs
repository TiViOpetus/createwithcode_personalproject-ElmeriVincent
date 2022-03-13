using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameOverScreen GameOverScreen;

    public void GameOver()
    {
        GameOverScreen.Setup();
    }
}
