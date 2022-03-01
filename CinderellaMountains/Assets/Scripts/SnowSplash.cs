using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSplash : MonoBehaviour
{
    public ParticleSystem splashParticle;

    void Update() 
    {
    
    }

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Planet"))
        {
            Destroy(gameObject, 1f);
            splashParticle.Play();
        }
    }
}
