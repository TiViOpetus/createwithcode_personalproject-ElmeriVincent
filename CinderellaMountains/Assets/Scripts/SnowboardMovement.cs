using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnowboardMovement : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 20f;
	[SerializeField] private float rotationSpeed = 100f;

	private float rotation;
	private Rigidbody rb;

	public float jumpForce;
	public bool isOnGround = true;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
        rotation = Input.GetAxisRaw("Horizontal");
        MoveControl();
	}

    void MoveControl()
    {
        // Hahmon liike kääntösuuntaan päin.

        rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
		Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;
		Quaternion deltaRotation = Quaternion.Euler(yRotation);
		Quaternion targetRotation = rb.rotation * deltaRotation;
		rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
    }
}
