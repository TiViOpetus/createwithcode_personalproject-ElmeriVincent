using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    private string scoreText;

    public float scoreAmount;
    private float pointIncreased;
    private int addPoints = 20;

    public bool endGame = false;

    public GameOverScreen displayScore;

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

    // When using a ramp player receives more points

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ramp") && endGame == false)
        {
            scoreAmount += addPoints;
        }
    }
}
