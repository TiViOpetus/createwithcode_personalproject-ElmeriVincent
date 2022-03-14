using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollisions : MonoBehaviour
{
    private SnowboardMovement endMovement;
    private Score endScore;
    private SnowballSpawner stopSnowball;

    void Start()
    {
        endMovement = GetComponent<SnowboardMovement>();
        endScore = GetComponent<Score>();
        stopSnowball = GetComponent<SnowballSpawner>();
    }

    //Game ends when colliding with an obstacle

    private void OnCollisionEnter(Collision collision)
		{
			if(collision.gameObject.CompareTag("Planet"))
            {
                endMovement.onGround = true;
            }
            else if(collision.gameObject.CompareTag("Obstacle"))
            {
                endMovement.gameOver = true;
                endScore.endGame = true;
                stopSnowball.spawning = false;
                FindObjectOfType<GameManager>().GameOver();
            }
        }
}
