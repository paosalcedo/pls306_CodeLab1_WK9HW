using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartLevel : MonoBehaviour {

	void PlayerIsDead ()
	{	
// 		LivesKeeper.instance.Lives -= 1;
//		if (LivesKeeper.instance.Lives < 0) {
//			TimeKeeper.instance.Timer = 0f;
//			LivesKeeper.instance.Lives = 3;
//			LevelLoader.levelNum = 0;
//		}  
//		ScoreKeeper.instance.Score = 0;
		SceneManager.LoadScene ("first");
	}

}
