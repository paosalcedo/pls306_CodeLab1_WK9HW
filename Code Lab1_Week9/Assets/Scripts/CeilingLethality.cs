using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CeilingLethality : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision hit){
		if(hit.gameObject.tag == "Player"){
			GameObject gameManager = GameObject.Find("Game Manager");
			GameObject.Find("ScreamSoundHolder").GetComponent<AudioSource>().Play();
			Destroy(hit.gameObject);
			gameManager.SendMessage ("PlayerIsDead");
		}
	}
}
