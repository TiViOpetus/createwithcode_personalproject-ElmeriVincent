using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text score;

    private float scoreAmount;
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
}
