using UnityEngine;
using System.Collections;
public class shake : MonoBehaviour
{ 	
	public GameObject camera;
	private Vector3 originPosition;
	private Quaternion originRotation;
	public float shake_decay;
	public float shake_intensity;
	

	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "boss") {

			Shake();

		}
		
		
	}
	
	void FixedUpdate (){
		if (shake_intensity > 0){
			camera.transform.position = originPosition + Random.insideUnitSphere * shake_intensity;
			camera.transform.rotation = new Quaternion(
				originRotation.x + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.y + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.z + Random.Range (-shake_intensity,shake_intensity) * 0.03f,
				originRotation.w + Random.Range (-shake_intensity,shake_intensity) * 0.03f);
			shake_intensity -= shake_decay;
		}
	}
	
	void Shake(){
		originPosition = camera.transform.position;
		originRotation = camera.transform.rotation;
		shake_intensity = 0.06f;
		shake_decay = 0.02f;
	}
}