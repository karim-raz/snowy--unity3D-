using UnityEngine;
using System.Collections;

public class MenuTap : MonoBehaviour {
	public Texture2D tap ;

	public GUIStyle style ;
	public AudioClip click;
	int x;
	// Use this for initialization
	void Start(){

	

		PlayerController.Dead=false;
	
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Invoke("load0",0.3f);	
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
			{
				audio.PlayOneShot(click, 0.3F);
			
			}

			
		}
		if (Input.GetMouseButtonDown (0) || Input.GetKeyDown (KeyCode.Space)) {
			audio.PlayOneShot (click, 0.3F);
			Invoke ("load1", 0.3f);	
		}
	}
	void OnGUI () {
	
		if (
			GUI.Button (
			// Centré en x, 2/3 en y
			new Rect (
			Screen.width/1.8f,
			Screen.height/10,
			Screen.width/2.5f,
			Screen.height/2.5f),
			tap,
			style
			
			)) { 

			
		}

		
	}
	void load0(){

		Application.LoadLevel("scene0");
		
		
	}
	void load1(){

		Application.LoadLevel("scene1");
	}
}
