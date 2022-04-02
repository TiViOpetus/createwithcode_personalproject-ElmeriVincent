using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ItemDestroy : MonoBehaviour
{
    public GameObject itemParticle;

    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Planet"))
        {
            Destroy(gameObject, 6f);
        }
        if(col.gameObject.CompareTag("Snowboarder"))
        {
            Destroy(gameObject);
            ItemParticleEffect();
            Destroy(itemParticle, 3f);
        }
    }

    // Plays the Particle Effect when item collides with player
    void ItemParticleEffect ()
    {
        itemParticle = Instantiate(itemParticle, transform.position, itemParticle.transform.rotation);
    }
}
