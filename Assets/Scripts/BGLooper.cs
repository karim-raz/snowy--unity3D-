using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

	int numBGPanels = 6;
	float newPosition=0;
	int	dist=0 ;
	public GameObject all;

	void Start() {
		dist=0 ;
	}
	void Update(){

		dist = PlayerPrefs.GetInt("distance", 0);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		Debug.Log ("Triggered: " + collider.name);

		if (collider.name == "wall") {
			newPosition= collider.transform.position.x +1090;
			collider.transform.position = new Vector2(newPosition, collider.transform.position.y);
		}
		if (dist >= 7) {



						if (collider.name == "back 1") {
								float widthOfBGObject = ((BoxCollider2D)collider).size.x;
			
								Vector3 pos = collider.transform.position;
			
								pos.x += widthOfBGObject * numBGPanels;
			
			
								collider.transform.position = pos;
						}
						if (collider.name == "plan") {
								float widthOfBGObject = ((BoxCollider2D)collider).size.x;
			
								Vector3 pos = collider.transform.position;
			
								pos.x += widthOfBGObject * numBGPanels;
			
			
								collider.transform.position = pos;
						}
				}

	}
}
