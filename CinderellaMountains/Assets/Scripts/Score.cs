using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public string scoreText;

    public float scoreAmount;
    private float pointIncreased;
    private int addPoints = 20;

    public bool endGame = false;

    void Awake() 
    {
        scoreAmount = 0f;
        pointIncreased = 10f;
    }

    // Displays the score

    void Update()
    {
        if(endGame == false)
        {
            scoreText = score.text = (int)scoreAmount + " M";
            scoreAmount += pointIncreased * Time.deltaTime;
        }
    }

    // When collecting an item increase points;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Item") && endGame == false)
        {
            scoreAmount += addPoints;
        }
    }
}
