using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ex : MonoBehaviour
{	public AudioClip jumpy;

	// Explosion Prefab
	public GameObject explosion;
	
	// Make an explosion
	public void Explosion ()
	{
		GameObject instantiatedObj= (GameObject)Instantiate (explosion, transform.position, transform.rotation);
		audio.PlayOneShot(jumpy, 0.7F);
		Destroy(instantiatedObj, 0.3f);
	}
	

}