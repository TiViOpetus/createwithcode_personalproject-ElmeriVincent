using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityAttractor : MonoBehaviour
{
	/*Creating an inertial force that mimics the effects of the force g by rotation.*/

	[SerializeField] private float gravity = -9.81f;
	
	public void Attract(Rigidbody body) {
		Vector3 gravityUp = (body.position - transform.position).normalized;
		Vector3 localUp = body.transform.up;
		
		// Apply downwards gravity to body
		body.AddForce(gravityUp * gravity);
		// Allign bodies up axis with the centre of planet
		body.rotation = Quaternion.FromToRotation(localUp,gravityUp) * body.rotation;
	} 
}
