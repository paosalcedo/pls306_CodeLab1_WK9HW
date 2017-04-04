using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpenScript : MonoBehaviour {
	public int startScore;
	public const int SCORE_TO_WIN = 4;
	// Use this for initialization
	void Start () {
		startScore = ScoreKeeper.instance.Score;
	}
	
	// Update is called once per frame
	void Update () {
		OpenGate();
	}
	
	void OpenGate ()
	{
		if (ScoreKeeper.instance.Score - startScore >= SCORE_TO_WIN) {
 			Destroy(gameObject);
		}
	}
}
