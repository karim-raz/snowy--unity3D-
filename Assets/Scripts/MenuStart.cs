using UnityEngine;
using System.Collections;

public class MenuStart : MonoBehaviour {
	public Texture2D start ;
	public Texture2D about ;
	public Texture2D how;
	public Texture2D soundon ;
	public Texture2D soundoff ;
	public Texture2D musicon ;
	public Texture2D musicoff ;
	public GUIStyle style ;
	public static bool buttonIsOn=true;
	public static bool buttonIsOn1=true;

	public AudioClip  click;
	public  GameObject music;
	// Use this for initialization
	Rect start1 = new Rect (
		Screen.width/1.6f,
		Screen.height/3.2f,
		Screen.width/3,
		Screen.height/3) ;
	Rect start2 = new Rect (
		Screen.width/1.6f,
		Screen.height/3.3f,
		Screen.width/3,
		Screen.height/3) ;
	bool startMoved = false ;
	Rect about1 = new Rect (
		Screen.width/1.6f,
		Screen.height/1.8f,
		Screen.width/3,
		Screen.height/3) ;
	Rect about2 = new Rect (
		Screen.width/1.6f,
		Screen.height/1.9f,
		Screen.width/3,
		Screen.height/3) ;
	bool aboutMoved = false ;
	Rect how1 = new Rect (
		Screen.width/1.6f,
		Screen.height/1.2f,
		Screen.width/3,
		Screen.height/3) ;
	Rect how2 = new Rect (
		Screen.width/1.6f,
		Screen.height/1.3f,
		Screen.width/3,
		Screen.height/3) ;
	bool howMoved = false ;
	int x ;
	//keep the music play
	/*
	private static MenuStart instance = null;
	public static MenuStart Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.music);
			return;
		} else {
			instance = this;
		}
		DontDestroyOnLoad(this.music);
	}
*/


	void Update(){
		if (buttonIsOn1 == true) {
			PlayerPrefs.SetInt("sound", 1);
				} else {
			PlayerPrefs.SetInt("sound", 0);
				}
		if (buttonIsOn == true) {
			music.SetActive(true);
			PlayerPrefs.SetInt("music", 1);
			//AudioListener.volume = 30;
		} 
		else {
			PlayerPrefs.SetInt("music", 0);
			music.SetActive(false);

			//AudioListener.volume = 0;	

		}

		                  
		if (Input.GetKeyDown (KeyCode.Escape)) {
			
			Application.Quit();
		}
		}
	void OnGUI () {

	
		if (
			GUI.Button (
			// Centré en x, 2/3 en y
			startMoved ? start1 : start2, startMoved ? start : start,
			style
			
			)) { 
			startMoved = !startMoved ;

			Invoke("load01",0.3f);	
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);
		
		}
		if (
			GUI.Button (
			// Centré en x, 2/3 en y
			aboutMoved ? about1 : about2, aboutMoved ? about : about,
			style
			
			)){ 

			aboutMoved = !aboutMoved ;
			Invoke("loadabout",0.3f);	
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);



		}
		if (
			GUI.Button (
			// Centré en x, 2/3 en y
			howMoved ? how1 : how2, howMoved ? how : how,
			style
			
			)){ 
			
			howMoved = !howMoved ;

			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);
			Invoke("loadhow",0.3f);	
			
			
		}


		if (GUI.Button (new Rect (
			Screen.width / 1.2f,
			Screen.height / 10,
			Screen.width/5.5f ,
			Screen.height/5.5f ), 
		                buttonIsOn ? soundon :soundoff , style)) {
			buttonIsOn = !buttonIsOn;

			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);
		
		
	}
		if (GUI.Button (new Rect (
			Screen.width / 1.6f,
			Screen.height / 10,
			Screen.width/5.5f,
			Screen.height/5.5f ), 
		                buttonIsOn1 ? musicon :musicoff , style)) {

			buttonIsOn1 = !buttonIsOn1;
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);

			
			
			
		}

	

	}
	void load01(){
		startMoved = !startMoved ;

		Application.LoadLevel("scene01");
		if(buttonIsOn==true)
			GameObject.Find("song").SetActive(false);

	}
	void loadabout(){
		aboutMoved = !aboutMoved ;
		Application.LoadLevel("sceneabout");
	}
	void loadhow(){
		howMoved = !howMoved ;
		Application.LoadLevel("scenehow");
	}

}
