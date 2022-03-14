using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampDestroy : MonoBehaviour
{
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Planet"))
        {
            Destroy(gameObject, 6f);
        }
    }
}
