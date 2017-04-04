using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingMover : MonoBehaviour {

	[SerializeField] float moveSpeed;

	void Update () {
		Move ();
		PlaySFX();
	}

	private void Move()
	{
		transform.Translate (Vector3.back * moveSpeed * Time.deltaTime);		
	}

	private void PlaySFX ()
	{
//		AudioSource ceilingSound = GetComponent<AudioSource> ();
//		if (!ceilingSound.isPlaying) {
//			ceilingSound.Play ();
//		}
	}


}
