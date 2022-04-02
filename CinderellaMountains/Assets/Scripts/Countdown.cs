using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public int countdownTimer;
    public Text displayCountdown;

    private SnowboardMovement startMovement;
    private Score startScore;
    private SnowballSpawner startSnowball;
    private ItemSpawner startItemSpawner;
    private ObstacleSpawner startObstacleSpawner;

    private void Start()
    {
        startMovement = GetComponent<SnowboardMovement>();
        startScore = GetComponent<Score>();
        startSnowball = GetComponent<SnowballSpawner>();
        startItemSpawner = GetComponent<ItemSpawner>();
        startObstacleSpawner = GetComponent<ObstacleSpawner>();
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        startMovement.gameOver = true;
        startScore.endGame = true;
        startSnowball.spawning = false;
        startItemSpawner.spawning = false;
        startObstacleSpawner.spawning = false;

        while((countdownTimer > 0))
        {
            displayCountdown.text = countdownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countdownTimer--;
        }

        displayCountdown.text = "NOW!";

    // Starts the game flow.
        startMovement.gameOver = false;
        startScore.endGame = false;
        startSnowball.spawning = true;
        startItemSpawner.spawning = true;
        startObstacleSpawner.spawning = true;
        StartCoroutine(startItemSpawner.SpawnItem());
        StartCoroutine(startSnowball.SpawnSnowball());
        StartCoroutine(startObstacleSpawner.SpawnLog());

        yield return new WaitForSeconds(1f);
        displayCountdown.gameObject.SetActive(false);
    }
}
