using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    [SerializeField] private float restartDelay = 3f;

    public void GameOver()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game over!");
            //Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
