using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSplash : MonoBehaviour
{
    public ParticleSystem splashParticle;

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject)
        {
            splashParticle.Play();
            Destroy(gameObject, 0.2f);
        }
    }
}
