using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lol2 : MonoBehaviour {
	

	static int highScore = 0;
	Text instruction;

	

	
	
	void Start() {
		
		
		instruction = GetComponent<Text>();


		highScore = PlayerPrefs.GetInt("highScore", 0);
		instruction.text = "X " + highScore;
	}
	

		
		
		
}
