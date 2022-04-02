using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public GameObject bonusScore;
    private string scoreText;

    public float scoreAmount;
    private float pointIncreased;
    private int addPoints = 20;

    private ItemSpawner spawnPeriodTime;
    private ObstacleSpawner spawnPeriodTime2;

    public bool endGame = false;

    void Awake() 
    {
        spawnPeriodTime = GetComponent<ItemSpawner>();
        spawnPeriodTime2 = GetComponent<ObstacleSpawner>();
        scoreAmount = 0f;
        pointIncreased = 10f;
    }

    // Displays the score

    void Update()
    {
        if(endGame == false)
        {
            scoreText = score.text = (int)scoreAmount + " SP";
            scoreAmount += pointIncreased * Time.deltaTime;
            IncreasingSpawSpeeds();
        }
    }

    // When collecting an item increase points;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Item") && endGame == false)
        {
            scoreAmount += addPoints;
            bonusScore.SetActive(true);
            StartCoroutine(ExampleCoroutine());
        }
    }

    // Disables the bonusScore text after a second
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(1);
        bonusScore.SetActive(false);
    }


    // Increasing the spawn speed of objects
    private void IncreasingSpawSpeeds()
    {
        if(scoreAmount >= 100)
        {
            spawnPeriodTime.spawnSpeed = 8f;
            spawnPeriodTime2.spawnSpeed = 8f;
        }
        if(scoreAmount >= 200)
        {
            spawnPeriodTime.spawnSpeed = 6f;
            spawnPeriodTime2.spawnSpeed = 6f;
        }
        if(scoreAmount >= 400)
        {
            spawnPeriodTime.spawnSpeed = 4f;
            spawnPeriodTime2.spawnSpeed = 4f;
        }
        if(scoreAmount >= 600)
        {
            spawnPeriodTime.spawnSpeed = 2f;
            spawnPeriodTime2.spawnSpeed = 2f;
        }
    }
}
