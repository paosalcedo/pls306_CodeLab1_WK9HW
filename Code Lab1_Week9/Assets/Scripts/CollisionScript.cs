using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {

	string yourTime;
	// Use this for initialization
	void PlayerIsDead ()
	{
 		Invoke ("DelayedRestart", 3f);
		//Send message to LivesKeeper to deduct a life.
		LivesKeeper.instance.Lives -= 1;
	}

	void DelayedRestart()
	{
		if (LivesKeeper.instance.Lives < 0) {
			TimeKeeper.instance.Timer = 0f;
			LivesKeeper.instance.Lives = 3;
			LevelLoader.levelNum = 0;
		}  
		ScoreKeeper.instance.Score = 0;
		SceneManager.LoadScene ("first");
	}

	
}
