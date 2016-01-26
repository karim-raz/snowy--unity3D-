using UnityEngine;
using System.Collections;

public  class MenuPause : MonoBehaviour {
	public Texture2D pause ;
	public Texture2D retry ;
	public Texture2D continu ;
	public Texture2D main ;
	public GUIStyle style ;
	public AudioClip click;
	public bool isvisible1 = false;
	public bool isclicked = false;
	Rect ret = new Rect (
		Screen.width/5,
		Screen.height/1.8f,
		Screen.width/3.5f,
		Screen.height/3.5f);
	Rect cont = new Rect (
		Screen.width/5,
		Screen.height/1.8f,
		Screen.width/3.5f,
		Screen.height/3.5f);
	Rect mai = new Rect (
		Screen.width/1.7f,
		Screen.height/1.8f,
		Screen.width/3.5f,
		Screen.height/3.5f);
	Rect mai2 = new Rect (
		Screen.width/1.7f,
		Screen.height/1.8f,
		Screen.width/3.5f,
		Screen.height/3.5f);
	// Use this for initialization

	void Start(){

		AudioListener.volume=1;
	}
	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			audio.PlayOneShot(click, 0.3F);
			Time.timeScale = 0;
			isvisible1=true;
			AudioListener.volume=0;
			isclicked=true;
		}
		if (isclicked = true) {
						if (Input.GetKeyDown (KeyCode.Escape)) {
								audio.PlayOneShot (click, 0.3F);
								Time.timeScale = 1;
								isvisible1 = false;
								AudioListener.volume = 1;

						}
				}
		
	}
	void OnGUI () {
		if (PlayerController.Dead) {
						if (isvisible1 == true) {
				
								
				
										if (
					GUI.Button (
					// Centré en x, 2/3 en y
					new Rect (
					Screen.width / 19,
					Screen.height / 1.3f,
					Screen.width / 100,
					Screen.height / 100),
					pause,
					style
					
										)) { 
												audio.PlayOneShot (click, 0.3F);
												Time.timeScale = 0;
												isvisible1 = true;
												AudioListener.volume = 0;
					
										}
				
				
								





						}
			if (
				GUI.Button (
				// Centré en x, 2/3 en y
				mai2,
				main,
				style
				
				)) { 
				audio.PlayOneShot (click, 0.3F);
			
			
				Invoke("load0",0.3f);	

				
			}
			if (
				GUI.Button (
				// Centré en x, 2/3 en y
				ret,
				retry,
				style
				
				)) { 
			audio.PlayOneShot (click, 0.3F);
			

				Invoke("load01",0.3f);	
			
			}
				}

			if(PlayerController.Dead==false){


			if (isvisible1) {
				
				if (
					GUI.Button (
					// Centré en x, 2/3 en y
					mai,
					main,
					style
					
					)) { 
					audio.PlayOneShot (click, 0.3F);
					Time.timeScale = 1;
					AudioListener.volume = 1;
					isvisible1 = false;
					
					Application.LoadLevel ("scene0");
					
				}
				if (
					GUI.Button (
					// Centré en x, 2/3 en y
					cont,
					continu,
					style
					
					)) { 
					audio.PlayOneShot (click, 0.3F);
					isvisible1 = false;
					Time.timeScale = 1;
					AudioListener.volume = 1;
				}
				
			} else {
				
				if (
					GUI.Button (
					// Centré en x, 2/3 en y
					new Rect (
					Screen.width/19,
					Screen.height/1.3f,
					Screen.width/5,
					Screen.height/5),
					pause,
					style
					
					)) { 
					audio.PlayOneShot(click, 0.3F);
					Time.timeScale = 0;
					isvisible1=true;
					AudioListener.volume=0;
					
				}
				
				
			}

				}

	

	



	
	
}



	void load0(){

		Application.LoadLevel("scene0");
		
		
	}
	void load01(){
	
		Application.LoadLevel("scene01");
		
		
	}
}

