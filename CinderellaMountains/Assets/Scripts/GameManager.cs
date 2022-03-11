using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameOverScreen GameOverScreen;
    bool gameHasEnded = false;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            GameOverScreen.Setup();
        }
    }
}
