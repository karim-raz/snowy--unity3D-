using UnityEngine;
using System.Collections;

public class AvalScream : MonoBehaviour {
	public AudioClip rowl;
	public AudioClip bang;
	public float timeInterval; // interval in seconds
	float time=3f;
	// Use this for initialization
	void Start () {

		rigidbody2D.AddForce (new Vector2(0f,1500f));
		rigidbody2D.AddForce (new Vector2(300f,0));
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (time > 0)
			time -= Time.deltaTime;
		else {
			// INSERT YOUR UPDATE CODE HERE
			//audio.PlayOneShot(rowl, 0.7F);

			rigidbody2D.AddForce (new Vector2(0f,500f));
			time=3f;
		}
			


			
		}
		
		
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "boss") {
			audio.PlayOneShot(bang, 0.7F);

		}
	}
	}
	
	
	
	



