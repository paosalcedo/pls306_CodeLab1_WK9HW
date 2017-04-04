using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("DelayedDeath", 5f);
	}

	void DelayedDeath(){
		Destroy(gameObject);
	}
}
