using UnityEngine;
using System.Collections;

public class moveobstacle : MonoBehaviour {
	float time=2f;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce (new Vector2 (2f, 0));
	}
	
	// Update is called once per frame
	void Update () {

		if (time > 0) {
						time -= Time.deltaTime;
						
				}
		else {
			// INSERT YOUR UPDATE CODE HERE
			rigidbody2D.AddForce (new Vector2(-2f,0));
			time=2f;
		}

	}
}
