using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ScoreUpdateScript : MonoBehaviour {
	
	public Text scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ShowText();
	}

	void ShowText(){
		scoreText.text = ScoreKeeper.instance.Score.ToString("Coins to open gate: " + "#" + "/" + GateOpenScript.SCORE_TO_WIN);
	}
}
