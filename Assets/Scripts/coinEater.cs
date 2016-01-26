using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class coinEater : MonoBehaviour {
	float newPosition=0f;
	public GameObject all;
	public AudioClip jumpy;
	List<float> randomElement = new List<float>();
	int	dist=0 ;
	// Use this for initialization
	void Start () {

		randomElement.Add(1090);
		dist=0 ;
	
	}
	
	// Update is called once per frame
	void Update () {
		dist = PlayerPrefs.GetInt("distance", 0);
	}
	
	void OnTriggerEnter2D(Collider2D collider) {
			
						if (collider.gameObject.tag == "boule") {
								//  Destroy(gameObject);
			
								audio.PlayOneShot (jumpy, 0.7F);
								newPosition = all.transform.position.x + randomElement [0];
								all.transform.position = new Vector2 (newPosition, all.transform.position.y);
								//all.transform.Translate(newPosition,all.transform.position.y,0f,Space.World);
								//Debug.Log("Monster Colliding");
								//Destroy(all);



		
						}

	
						if (collider.gameObject.tag == "Monster") {
								//  Destroy(gameObject);
			

								newPosition = all.transform.position.x + randomElement [0];
								all.transform.position = new Vector2 (newPosition, all.transform.position.y);
								//all.transform.Translate(newPosition,all.transform.position.y,0f,Space.World);
								//Debug.Log("Monster Colliding");
								//Destroy(all);
			
			
			
			
						}
		if (dist >= 7) {
						if (collider.gameObject.tag == "Family") {
								//  Destroy(gameObject);
			
			
								newPosition = all.transform.position.x + randomElement [0];
								all.transform.position = new Vector2 (newPosition, all.transform.position.y);
								//all.transform.Translate(newPosition,all.transform.position.y,0f,Space.World);
								//Debug.Log("Monster Colliding");
								//Destroy(all);
			
			
			
			
						}
				}
						if (collider.gameObject.name == "BGLooper") {
		
			
			
								newPosition = all.transform.position.x + randomElement [0];
								all.transform.position = new Vector2 (newPosition, all.transform.position.y);

			
			
			
			
						
				}
	
		}
	

	
}
