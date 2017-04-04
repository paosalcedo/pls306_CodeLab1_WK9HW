using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour {

	AudioSource boing;
	public float explosionRadius = 20.0f;
	public float explosionPower = 20f;
	public float raycastRange = 20f;
	public float grappleRange = 20.0f;
	public float grappleRadius = 20.0f;
	GameObject[] rocketModels;
	// Use this for initialization
	void Start () {
		boing = GetComponent<AudioSource> ();
		rocketModels = GameObject.FindGameObjectsWithTag ("Rocket");
//		foreach (GameObject rocketModel in rocketModels) {
//			rocketModel.GetComponent<RopeRenderer>().enabled = false;
//		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			ShootRay ();
//			foreach (GameObject rocketModel in rocketModels) {
//				rocketModel.GetComponent<RopeRenderer>().enabled = true;
//			}
		} 

//		if (!boing.isPlaying){
//			foreach (GameObject rocketModel in rocketModels) {
//				rocketModel.GetComponent<RopeRenderer>().enabled = false;
//			}
//			foreach (GameObject rocketModel in rocketModels) {
//				rocketModel.GetComponent<RopeRenderer>().enabled = false;
//			}
//		}
		
//		if (Input.GetMouseButtonDown (1)) {
//			ShootGrapple();
//		}
	}

	void ShootRay ()
	{

		//1. declare your raycast 
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		//2. set up our raycast hit info variable too 

		RaycastHit rayHit = new RaycastHit ();

		//3. we're ready to shoot our raycast

		if (Physics.Raycast (ray, out rayHit, raycastRange)) {
			if (rayHit.transform.tag == "Ground" && rayHit.rigidbody != null /*|| rayHit.transform.tag == "Wall" && rayHit.rigidbody != null*/) {
				Debug.Log (rayHit.transform.name);
				Collider[] colliders = Physics.OverlapSphere (rayHit.point, explosionRadius);
				foreach (Collider hit in colliders) {
					if (hit.tag != "Coin") {
						Rigidbody rb = hit.GetComponent<Rigidbody> ();

						//apply explosion force on player.
						if (rb.tag == "Player") {
							Vector3 tossDir;
							tossDir = rb.transform.position - rayHit.point;
							rb.AddForce (tossDir.normalized * explosionPower, ForceMode.VelocityChange);
							boing.Play ();							
						}
					}
				}
			}
		}
		
		
	}

	void ShootGrapple ()
	{

		//1. declare your raycast 
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);
		//2. set up our raycast hit info variable too 

		RaycastHit rayHit = new RaycastHit ();

		//3. we're ready to shoot our raycast

		if (Physics.Raycast (ray, out rayHit, grappleRange)) {
			if (rayHit.transform.tag == "Ground" && rayHit.rigidbody != null || rayHit.transform.tag == "Wall" && rayHit.rigidbody != null) {
				Debug.Log(rayHit.transform.name);
				Collider[] colliders = Physics.OverlapSphere (rayHit.point, grappleRadius);
				foreach (Collider hit in colliders) {
					if (hit.tag != "Coin") {
						Rigidbody rb = hit.GetComponent<Rigidbody> ();

						//apply explosion force on player.
						if (rb.tag == "Player") {
							Vector3 tossDir;
							tossDir = rb.transform.position - rayHit.point;
							rb.AddForce (tossDir.normalized * -explosionPower, ForceMode.VelocityChange);
							AudioSource boing;
							boing = GetComponent<AudioSource>();
							boing.Play();							
						}
					}
				}
			}
		}
	}

	
}
