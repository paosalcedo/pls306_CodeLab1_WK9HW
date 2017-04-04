﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBoots : BasicBoots {

	// Use this for initialization
	public override void ActivateBoots(Vector3 pos, float offsetX, float offsetY, float offsetZ){
		print ("Jumped with rocket boots");
		GameObject rocket = Instantiate (Resources.Load ("Prefabs/Rocket") as GameObject);
		rocket.transform.position = pos;
		rocket.transform.position = new Vector3(pos.x + offsetX, pos.y + offsetY, pos.z + offsetZ);
	}

	
}