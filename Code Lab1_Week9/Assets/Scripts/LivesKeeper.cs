using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesKeeper : MonoBehaviour {

	public static LivesKeeper instance;
	// Use this for initialization

	private int lives = 3;

	public int Lives {
		get{ 
			return lives;
		}
		set{ 
			lives = value;
		}
	}

	void Start () {
		if (instance == null) {
			instance = this;
			DontDestroyOnLoad (this);
		} else {
			Destroy(gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
