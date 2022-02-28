using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowSplash : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Planet")
        {
            Destroy(gameObject, 1f);
        }

        if(collision.gameObject.tag == "Snowboard")
        {
            //if snowballs hits the snowboard then
            //Game Over
            print("game over");
        }
    }
}
