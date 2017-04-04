using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSController : MonoBehaviour {

	public float speed = 10.0f;
	public float airControl = 0.1f;
	public float gravity = 10.0f;
	public float maxFallVelocity = 20f;
	public float maxVelocityChange = 10.0f;
	public float fallDeathHeight = 20f;
//	public bool canJump = true;
	public float jumpHeight = 2.0f;
	private bool grounded = false;
//	float initHeight;


	Rigidbody rb;
	//
//	public float sideSpeed;
//	public float forwardSpeed;
//	public static float movementSpeed;
//	public float mouseSensitivity;
//
//	float verticalLook = 0; //why declare it here?
//	float verticalLookMax = 90.0f;
//	float horizontalLook;
//
//	public float verticalVelocity;
//
	void Start () {

//		soundPlayed = false;
		Cursor.lockState = CursorLockMode.Locked;
		rb = GetComponent<Rigidbody> ();

// 		ORIGINAL SETTINGS
		rb.freezeRotation = true;
		rb.useGravity = false;

//		MINE
//		rb.freezeRotation = true;
//		rb.useGravity = true;
	}

	void Update(){
		BootAbility();
	}

	void FixedUpdate ()
	{
		MovePlayer ();
		CheckIfFalling();
		
//		CheckIfGrounded();
	}
//		**** ORIGINAL FPS CONTROLLER MOVE CODE (place this in FixedUpdate()***
//		if (grounded == true || grounded == false) { // first option lets you move in the air, but also gives jetpack effect.
//		if (grounded == true) {
			// Calculate how fast we should be moving
//			Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
//			targetVelocity = transform.TransformDirection(targetVelocity);
//			targetVelocity *= speed;

			// Apply a force that attempts to reach our target velocity
//			Vector3 velocity = rb.velocity;
//			Vector3 velocityChange = (targetVelocity - velocity);
//			velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
//			velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
//			velocityChange.y = 0;
//			rb.AddForce(velocityChange, ForceMode.VelocityChange);

			// Jump
//			if (canJump && Input.GetButtonDown("Jump")) {
//				rb.velocity = new Vector3 (velocity.x, CalculateJumpVerticalSpeed (), velocity.z);
////				rb.velocity = new Vector3 (velocity.x, velocity.y + jumpHeight, velocity.z);
//			} 

//		}

	

	float CalculateJumpVerticalSpeed () {
		// From the jump height and gravity we deduce the upwards speed 
		// for the character to reach at the apex.
		return Mathf.Sqrt(2 * jumpHeight * gravity);
	}

	void MovePlayer ()
	{

		Vector3 targetVelocity = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
		targetVelocity = transform.TransformDirection (targetVelocity);
		targetVelocity *= speed;

		// Apply a force that attempts to reach our target velocity
		Vector3 velocity = rb.velocity;
		Vector3 velocityChange = (targetVelocity - velocity);
		velocityChange.x = Mathf.Clamp (velocityChange.x, -maxVelocityChange, maxVelocityChange);
		velocityChange.z = Mathf.Clamp (velocityChange.z, -maxVelocityChange, maxVelocityChange);
		velocityChange.y = 0;

		if (grounded == true) {
			rb.AddForce (velocityChange, ForceMode.VelocityChange);
		}

		//jump
		
		if (grounded == true && Input.GetButtonDown ("Jump")) {
			rb.velocity = new Vector3 (velocity.x, CalculateJumpVerticalSpeed (), velocity.z);
			// play the jump sound.
			AudioSource jump;
			jump = GetComponent<AudioSource> ();
			jump.Play ();
		}

		
		
		//tweaking air control when jumping.
		if (grounded == false) {
			rb.AddForce (velocityChange * airControl, ForceMode.VelocityChange);
		}

		// We apply gravity manually for more tuning control
		rb.AddForce(new Vector3 (0, -gravity * rb.mass, 0));

	}

	void BootAbility(){
	//boot ability
		if (Input.GetKeyDown (KeyCode.LeftControl)) {
			GetComponent<BasicBoots>().ActivateBoots(transform.position, 0f, -1f, 0f);
		}
	}

	void CheckIfFalling ()
	{
//		if (rb.velocity.y < maxFallVelocity) {
//			GameObject scream = GameObject.Find("ScreamSoundHolder");
//			scream.SendMessage("PlaySound");
//			SendDeathMessage();
//		}
	}

	public bool canFallToDeath;

	void OnCollisionStay (Collision coll) {
		if (coll.collider.tag == "Ground") {
			grounded = true;
		}
	}

	void OnCollisionExit(Collision coll){
		grounded = false;
		if (coll.gameObject.tag == "ground") {
//			initHeight = transform.position.y;
		}
	}


	void SendDeathMessage(){
		GameObject gameManager = GameObject.Find("Game Manager");
		gameManager.SendMessage ("PlayerIsDead");
	}



}
