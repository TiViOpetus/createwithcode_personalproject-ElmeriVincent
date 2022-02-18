using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class FauxGravityBody : MonoBehaviour
{
    FauxGravityAttractor planet;
    new Rigidbody rigidbody;

    void Awake()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").GetComponent<FauxGravityAttractor>();
        rigidbody = GetComponent<Rigidbody>();
		
        // Disable rigidbody gravity and rotation as this is simulated in GravityAttractor script
        rigidbody.useGravity = false;
        rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    void FixedUpdate()
    {
        // Allow this body to be influenced by planet's gravity
        planet.Attract(rigidbody);
    }
}
