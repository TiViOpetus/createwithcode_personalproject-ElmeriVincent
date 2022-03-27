using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSplash : MonoBehaviour
{
    public GameObject splashParticle;

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject)
        {
            Destroy(gameObject);
            SplashParticleEffect();
            Destroy(splashParticle, 3f);
        }
    }

    // Plays the particle effect at the position where it collides
    void SplashParticleEffect ()
    {
        splashParticle = Instantiate(splashParticle, transform.position, splashParticle.transform.rotation);
    }
}
