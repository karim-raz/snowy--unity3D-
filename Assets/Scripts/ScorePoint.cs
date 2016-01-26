using UnityEngine;
using System.Collections;

public class ScorePoint : MonoBehaviour {
	public GameObject coin;
	void OnTriggerEnter2D(Collider2D collider) {
		if(collider.tag == "boule") {
			lol.AddPoint();

			//Destroy(coin);
		}
	}
}
