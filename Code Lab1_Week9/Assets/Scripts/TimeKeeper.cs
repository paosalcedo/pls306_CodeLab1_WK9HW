using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeKeeper : MonoBehaviour {

	private float timer;

	private const string PREF_BEST_TIME = "bestTimePref";

	public float Timer {
		get { 
			return timer;
		}
		set { 
			timer = value;
	
			if (timer < BestTime) {
				BestTime = timer;
				UtilScript.WriteStringToFile(Application.dataPath, "best_times.txt", BestTime.ToString("##" + "|"));
			}   
		}
	}

	private float bestTime = 100f;

	public float BestTime {
		get{ 
			bestTime = PlayerPrefs.GetInt(PREF_BEST_TIME);
			return bestTime;
		}
		set{ 
			bestTime = value;
			PlayerPrefs.SetFloat(PREF_BEST_TIME, bestTime);	
		}
	}


	public static TimeKeeper instance;

	// Use this for initialization
	void Start ()
	{
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
