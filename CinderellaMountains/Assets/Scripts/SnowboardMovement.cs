using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SnowboardMovement : MonoBehaviour
{
		[Header("Rigidbody")]
		[SerializeField] private Rigidbody rb;
        RaycastHit hit;
        private bool freezeRotation = true;

		[Header("Jumping")]
        [SerializeField] private int forceConst = 4;
		private bool onGround = true;

		[Header("Speed Control")]
		[SerializeField] private float moveSpeed = 20f;
		[SerializeField] private float rotationSpeed = 100f;
		private float rotation;

        void Start()
        {
            Ini();
        }

		// FOR DEBUGGING JUMPING/GRAVITY 
        void Update()
        {
            // Raycast (doesn't affect gameplay)
            if (Physics.Raycast(transform.position, -transform.up, out hit))
            {
                Debug.DrawLine(transform.position, hit.point, Color.cyan);
            }
            Jump();
        }

        void FixedUpdate()
        {

			rotation = Input.GetAxisRaw("Horizontal");
            MoveControl();
        }

		// INTIALIZATIONS
        private void Ini()
        {
            rb.useGravity = false; // Disables Gravity
            if (freezeRotation)
            {
                rb.constraints = RigidbodyConstraints.FreezeRotation;
            }
            else
            {
                rb.constraints = RigidbodyConstraints.None;
            }
        }
        // MOVING
        void MoveControl()
        {
            // Using fixedDeltaTime because we want framerate independent interval.
            rb.MovePosition(rb.position + transform.forward * moveSpeed * Time.fixedDeltaTime);
            Vector3 yRotation = Vector3.up * rotation * rotationSpeed * Time.fixedDeltaTime;

            //Returns a rotation that rotates z degrees around the z axis, x degrees around the x axis, and y degrees around the y axis
            Quaternion deltaRotation = Quaternion.Euler(yRotation);
            Quaternion targetRotation = rb.rotation * deltaRotation;

            //Spherically interpolates between quaternions a and b by ratio t.
            rb.MoveRotation(Quaternion.Slerp(rb.rotation, targetRotation, 50f * Time.deltaTime));
        }

        // JUMPING
        private void Jump()
        {
            if (Input.GetKeyDown(KeyCode.Space) && onGround)
            {
				// For jump to work correctly around a sphere we need to add force that is relative to rb coordinate system.
                rb.AddRelativeForce(0, forceConst, 0, ForceMode.Impulse);
                print("constant");
                onGround = false;         
            }
        }

		private void OnCollisionEnter(Collision collision)
		{
			if(collision.gameObject.CompareTag("Planet"))
				onGround = true;
		}
    }
