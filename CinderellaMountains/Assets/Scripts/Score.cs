using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;
    private string scoreText;

    private float scoreAmount;
    [SerializeField] public float pointIncreased;

    public bool endGame = false;

    void Awake() 
    {
        scoreAmount = 0f;
        pointIncreased = 10f;
    }

    // Displays the meters you have traveled.

    void Update()
    {
        if(endGame == false)
        {
            scoreText = score.text = (int)scoreAmount + " M";
            scoreAmount += pointIncreased * Time.deltaTime;

            IncreaseLv1();
        }
    }

    void IncreaseLv1() 
    {
        if((int)scoreAmount == 250)
        {
            print("WOW 250M!");
        }
    }
}
