using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBoots : MonoBehaviour {
	
	int usesLeft;

	void Start()
	{
		usesLeft = 2;
	}
	public virtual void ActivateBoots (Vector3 pos, float offsetX, float offsetY, float offsetZ, int uses)
	{		
		if (usesLeft > 0) {
			print ("Jumped with " + GetComponent<FPSController>().sphereBoots.name);
			GameObject sphere = Instantiate (Resources.Load ("Prefabs/BasicSphere") as GameObject);
			sphere.transform.position = pos;
			sphere.transform.position = new Vector3 (pos.x + offsetX, pos.y + offsetY, pos.z + offsetZ);
			usesLeft -= 1;
			uses -= 1;
			print("Number of uses remaining: " + uses);
		}
	}
}
