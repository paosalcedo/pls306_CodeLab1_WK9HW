using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_StopwatchScript : MonoBehaviour {

	public Text stopwatchText;
	
	public float timeElapsed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ShowTimer();
		GetStopwatch();
	}

	void ShowTimer(){
//		stopwatchText.text = timeElapsed.ToString ("Time Elapsed: " + "##");
		stopwatchText.text = TimeKeeper.instance.Timer.ToString("Time Elapsed: " + "##");
	}

	void GetStopwatch(){
		//timeElapsed += Time.deltaTime;
		TimeKeeper.instance.Timer += Time.deltaTime;
	}

	
}
