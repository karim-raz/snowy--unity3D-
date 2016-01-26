using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Transform player;
	bool moved_1=true;
	private const float MOVEMENT_TIME = 0.5f; // The object moves for 2 seconds
	private const float MOVEMENT_DISTANCE = 0.75f; // Distance the object should move
	void FixedUpdate(){

		

	
	}
	void Update(){
	
						transform.position = new Vector3 (player.position.x + 2f, transform.position.y, transform.position.z);
				
	}

	public void movecamera(){

		StartCoroutine("MoveObject", -MOVEMENT_DISTANCE);
		Invoke("movecamera2",0.1f);
	}
	public void movecamera2(){
		
	  StopCoroutine("MoveObject");

	}
	private IEnumerator MoveObject(float distance)
	{
		Vector3 currentPosition =transform.position;
		Vector3 targetPosition = new Vector3(player.transform.position.x + distance, transform.position.y,transform.position.z);
		float currentTime = 0.0f;
		
		while(currentTime <= MOVEMENT_TIME)
		{
			float movementFactor = currentTime / MOVEMENT_TIME;
			this.transform.position = Vector3.Lerp(currentPosition, targetPosition, movementFactor);
			currentTime += Time.deltaTime;
			yield return null;
		}
	}
}
