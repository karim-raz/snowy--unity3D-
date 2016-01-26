using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lol : MonoBehaviour {
	
	static int score = 0;
	static int highScore = 0;
	Text instruction;
	static lol instance;
	
	static public void AddPoint() {
		
		score++;
		
		if(score > highScore) {
			highScore = score;
		}
	}
	
	
	
	void Start() {
		
		
		instruction = GetComponent<Text>();

		score = 0;
		highScore = PlayerPrefs.GetInt("highScore", 0);
	}
	
	void OnDestroy() {
		
		PlayerPrefs.SetInt("highScore", highScore);
		PlayerPrefs.SetInt("Score", score);
	}
	
	void Update () {
		PlayerPrefs.SetInt("highScore", highScore);
		PlayerPrefs.SetInt("Score", score);
		instruction.text = "X " + score;


	}
}
