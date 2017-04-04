using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBoots : MonoBehaviour {
	
	protected string name = "BasicBoots";
	
	public virtual void ActivateBoots (Vector3 pos, float offsetX, float offsetY, float offsetZ)
	{
		print ("Jumped with " + name);
		GameObject sphere = Instantiate (Resources.Load ("Prefabs/BasicSphere") as GameObject);
		sphere.transform.position = pos;
		sphere.transform.position = new Vector3(pos.x + offsetX, pos.y + offsetY, pos.z + offsetZ);
	}
}
