using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DisplayHighScores : MonoBehaviour {

	public string fileName = "best_times.txt";

	private string bestTimes;

	// Use this for initialization
	void Start () {
		bestTimes = UtilScript.ReadStringFromFile(Application.dataPath, fileName);
//		UtilScript.ReadStringFromFile(Application.dataPath, fileName);
		Debug.Log(UtilScript.ReadStringFromFile(Application.dataPath, fileName));

		string[] bestTimesArray = bestTimes.Split('|');
		for(int i = 0; i < bestTimesArray.Length; i++){
			Debug.Log("Best times: " + bestTimesArray[i]);
		}

//		StreamReader sr = new StreamReader (Application.dataPath + "/" + fileName);
//		while (!sr.EndOfStream) {
//			string line = sr.ReadLine ();
//			string[] splitLine = line.Split('|');
//			for(int i = 0; i < splitLine.Length; i++){
//				Debug.Log("Best times: " + splitLine[i]);
//			}
//		}	
//			sr.Close ();
	}
	

	// Update is called once per frame
	void Update () {
		
	}

	void GrabTimes(){
		
	}
}
