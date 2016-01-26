using UnityEngine;
using System.Collections;

public class avalController2 : MonoBehaviour {
	public  float velocity =12;

	float time=1f;

	
	// Use this for initialization
	void Start () {

	
	}
	void FixedUpdate()
	{
	
				transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
				velocity += 0.0008f; 
				
				if (time > 0)
					time -= Time.deltaTime;
				else {
					rigidbody2D.AddForce (new Vector2 (0f, 500f));
					
					time = 1f;
					
					
				}

		
	}
	// Update is called once per frame
	void Update () {

	
		
		
	}

}


