using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wk9Manager : MonoBehaviour {

	MyVec3 test;

	// Use this for initialization
	void Start () {
		test = new MyVec3();
		test.x = 10;	
//		HighScore[] highScores = new HighScore[2]; 

		HighScore hs1 = new HighScore();
		hs1.name = "MATT"; 
		hs1.position = 1;
		hs1.score = 10;

		HighScore hs2 = new HighScore();
		hs2.name = "David";
		hs2.position = 2;
		hs2.score = 9.9f;

		HighScore hs3 = new HighScore();
		hs3.name = "Dennis";
		hs3.position = 3;
		hs3.score = 1; 

		hs1.next = hs2;
		hs2.prev = hs1;
		hs2.next = hs3;
		hs3.prev = hs2;

		HighScore current = hs1;

//		print(hs1.name);
//		print(hs1.next.name);
//		print(hs1.next.next.name);

		print(current.name); //current = MATT or hs1
		current = current.next; //current (which is hs1) is now hs2
		print(current.name); 
		current = current.next;
		print(current.name);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
