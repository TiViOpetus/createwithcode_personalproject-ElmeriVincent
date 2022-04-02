using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource itemCollected;
    public AudioSource crashingSound;
    public AudioSource snowballHit;
    public AudioSource backgroundMusic;

    //snowballHit plays in the SnowSplash Script;
    //backgroundMusic is controlled by the volume set on the main menu.

    void Awake()
    {
        backgroundMusic.Play();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Item"))
        {
            itemCollected.Play();
        }
        if (col.gameObject.CompareTag("Obstacle"))
        {
            crashingSound.Play();
        }
    }
}
