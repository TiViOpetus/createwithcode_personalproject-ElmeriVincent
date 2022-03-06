using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private SnowboardMovement endMovement;
    private Score endScore;
    private RandomSpawner endSpawning;

    void Start()
    {
        endMovement = GetComponent<SnowboardMovement>();
        endScore = GetComponent<Score>();
        endSpawning = GetComponent<RandomSpawner>();
    }

    //Ending action if colliding againts an obstacle
    private void OnCollisionEnter(Collision collision)
		{
			if(collision.gameObject.CompareTag("Planet"))
            {
                endMovement.onGround = true;
            }
            else if(collision.gameObject.CompareTag("Obstacle"))
            {
                endMovement.gameOver = true;
                endScore.pointIncreased = 0;
                endSpawning.spawning = false;
                FindObjectOfType<GameManager>().GameOver();
            }
        }
}
