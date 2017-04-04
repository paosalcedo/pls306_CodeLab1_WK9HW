using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGeneratorScript : MonoBehaviour {

	public List<string> names;
	
	void Start ()
	{
		names.Add ("Paolo");
		names.Add ("Jono");
		names.Add ("Macky");
		names.Add ("Jan");
		names.Add ("Mario");
		names.Add ("Marco");

		string[] nameArray = names.ToArray ();
	
		for (int i = 0; i < names.Count; i++) {
			Debug.Log(names[i]);
		}
	}
	
	void Update ()
	{
		
	}
}
