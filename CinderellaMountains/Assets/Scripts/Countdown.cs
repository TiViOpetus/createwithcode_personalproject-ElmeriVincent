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
    private ItemSpawner startRampSpawner;

    private void Start()
    {
        startMovement = GetComponent<SnowboardMovement>();
        startScore = GetComponent<Score>();
        startSnowball = GetComponent<SnowballSpawner>();
        startRampSpawner = GetComponent<ItemSpawner>();
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        startMovement.gameOver = true;
        startScore.endGame = true;
        startSnowball.spawning = false;
        startRampSpawner.spawning = false;

        while((countdownTimer > 0))
        {
            displayCountdown.text = countdownTimer.ToString();

            yield return new WaitForSeconds(1f);

            countdownTimer--;
        }

        displayCountdown.text = "NOW!";

        startMovement.gameOver = false;
        startScore.endGame = false;
        startSnowball.spawning = true;
        startRampSpawner.spawning = true;
        StartCoroutine(startRampSpawner.SpawnRamp());
        StartCoroutine(startSnowball.SpawnSnowball());

        yield return new WaitForSeconds(1f);
        displayCountdown.gameObject.SetActive(false);
    }
}
