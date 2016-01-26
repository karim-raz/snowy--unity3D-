using UnityEngine;
using System.Collections;

public class MenuHow2 : MonoBehaviour {
	public Texture2D next ;
	public GUIStyle style ;
	
	//public Texture2D how1,how2,how3;
	public AudioClip  click;
	bool buttonIsOn=false;
	int buttonIsOff=0;
	Rect next1 =new Rect (
		Screen.width / 1.7f,
		Screen.height / 9.8f,
		Screen.width/3.5f ,
		Screen.height/3.5f ) ;
	Rect next2 = new Rect (
		Screen.width / 1.7f,
		Screen.height / 10,
		Screen.width/3.5f ,
		Screen.height/3.5f ) ;
	bool nextmoved = false ;
	int x;
	int hited =1;
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
			nextmoved ? next1 : next2, nextmoved ? next : next,
			style
			
			)) { 
			nextmoved = !nextmoved ;
			
			
			
			x = PlayerPrefs.GetInt("sound", 0);
			if(x==1)
				audio.PlayOneShot(click, 0.3F);
			Invoke("loadhow3",0.3f);	
			
		}
		
		
	}
	void load0(){
		nextmoved = !nextmoved ;
		Application.LoadLevel("scene0");
		
		
	}
	void loadhow3(){
		nextmoved = !nextmoved ;
		Application.LoadLevel("scenehow3");
		
		
	}
}
