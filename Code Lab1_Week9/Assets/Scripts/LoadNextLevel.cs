using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextLevel : MonoBehaviour {

	string yourTime;
	float floatYourTime;
	public float delay = 3.0f;
	public static LoadNextLevel instance;
//	public List<


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerExit(Collider coll){
		if (coll.tag == "Player") {
			//saves finish time as string.
			yourTime = TimeKeeper.instance.Timer.ToString("##" + "|");
			//Saves finish time as float.
			floatYourTime = TimeKeeper.instance.Timer;    
			Invoke ("SendLoadMessage", delay);
		}
	}

	void SendLoadMessage ()
	{
		if (LevelLoader.levelNum < 1) {
			GameObject.Find ("Level Holder").SendMessage ("LoadNextLevel");
		} else {
			UtilScript.WriteStringToFile(Application.dataPath, "best_times.txt", yourTime);
			
		}
	}
}
