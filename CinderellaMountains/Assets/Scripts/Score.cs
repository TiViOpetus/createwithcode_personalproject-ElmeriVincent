using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public float scoreAmount;
    public float pointIncreased;

    void Start()
    {
        scoreAmount = 0f;
        pointIncreased = 10f;
    }

    void Update()
    {
        score.text = (int)scoreAmount + " M";
        scoreAmount += pointIncreased * Time.deltaTime;
    }
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Obstacle"))
        {
            //if player hits and obstacle => Game Over!
            //Everything Stops
            pointIncreased = 0;
        }
    }
}
