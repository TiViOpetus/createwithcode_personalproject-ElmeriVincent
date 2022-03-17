using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameOverScreen GameOverScreen;

    [SerializeField] private Score score;

    public void GameOver()
    {
        GameOverScreen.Setup((int)score.scoreAmount);
    }
}
