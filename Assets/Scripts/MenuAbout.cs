using UnityEngine;
using System.Collections;

public class MenuAbout : MonoBehaviour {
	public Texture2D back ;
	public Texture2D aboutcontent;
	public GUIStyle style ;
	public GameObject root;
	
	public AudioClip  click;

	Rect back1 =new Rect (
		Screen.width / 1.7f,
		Screen.height / 9.8f,
		Screen.width/5 ,
		Screen.height/5 ) ;
	Rect back2 = new Rect (
		Screen.width / 1.7f,
		Screen.height / 10,
		Screen.width/5 ,
		Screen.height/5 ) ;
	bool backmoved = false ;
	int x;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		if (Input.GetKeyDown (KeyCode.Escape)) {
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
			{
			audio.PlayOneShot(click, 0.3F);
			Invoke("load0",0.3f);	
			}
			else{
				Invoke("load0",0.3f);
			}
		}
	}


	void OnGUI () {
		
	
		if (
			GUI.Button (
			// Centré en x, 2/3 en y
			backmoved ? back1 : back2, backmoved ? back : back,
			style
			
			)) { 
			backmoved = !backmoved ;

			Invoke("load0",0.3f);	
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);

		}
		
		if (GUI.Button (new Rect (
			Screen.width / 5,
			Screen.height / 4,
			Screen.width ,
			Screen.height), 
		             aboutcontent, style)) {
		
			
			
			
		}
		
	}
	void load0(){
		backmoved = !backmoved ;
		Application.LoadLevel("scene0");


	}
}
