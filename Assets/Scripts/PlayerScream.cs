using UnityEngine;
using System.Collections;

public class PlayerScream : MonoBehaviour {
	public bool isGrounded=true;
	public AudioClip jumpy;
	float time=0.8f; 
	int x;
	void Start () {
		Invoke("loadscream",1.5f);
		x = PlayerPrefs.GetInt("music", 0);
		if (x == 0) {
			
			AudioListener.volume = 0;
			
		}else {
			AudioListener.volume = 1;		
		}

	}

	
	// Update is called once per frame
	void Update () {
				
		/*
		if (time > 0)
			time -= Time.deltaTime;
				else {
						// INSERT YOUR UPDATE CODE HERE
						Application.LoadLevel ("scene1");
		
				}
		*/
	}




	void loadscream(){
		audio.PlayOneShot(jumpy, 0.7F);
		rigidbody2D.AddForce (new Vector2(0f,1400f));
		
	}
	
	
		

}
