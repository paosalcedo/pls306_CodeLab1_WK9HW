using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamSoundScript : MonoBehaviour {
	// Use this for initialization
	AudioSource scream;

	void Start () {
		scream = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlaySound ()
	{
		if (!scream.isPlaying) {
			scream.Play ();
		}
	}
}
