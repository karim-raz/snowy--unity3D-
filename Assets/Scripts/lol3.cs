using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class lol3 : MonoBehaviour {
	
	static int score = 0;

	Text instruction;

	


	
	
	
	void Start() {
		
		
		instruction = GetComponent<Text>();
		instruction.text = "X " + PlayerPrefs.GetInt("Score", 0);


	}
	

}
