using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameCollisions : MonoBehaviour
{
    private SnowboardMovement endMovement;
    private Score endScore;
    private SnowballSpawner stopSnowball;
    private ItemSpawner stopItemSpawn;

    public GameObject puff;
    public GameObject mesh;

    void Start()
    {
        endMovement = GetComponent<SnowboardMovement>();
        endScore = GetComponent<Score>();
        stopSnowball = GetComponent<SnowballSpawner>();
        stopItemSpawn = GetComponent<ItemSpawner>();
    }

    //Game ends when colliding with an obstacle

    private void OnCollisionEnter(Collision collision)
		{
			if(collision.gameObject.CompareTag("Planet"))
            {
                endMovement.onGround = true;
            }

            //When colliding, stop the following:
            else if(collision.gameObject.CompareTag("Obstacle"))
            {
                endMovement.gameOver = true;
                endScore.endGame = true;
                stopSnowball.spawning = false;
                stopItemSpawn.spawning = false;
                Destroy(mesh);
                SplashParticleEffect();
                FindObjectOfType<GameManager>().GameOver();

                //hides the score that is shown while playing
                endScore.score.gameObject.SetActive(false);
            }
        }

    // Puff Particle plays when player collides with an obstacle.
    void SplashParticleEffect ()
    {
        Instantiate(puff, transform.position, puff.transform.rotation);
    }
}
