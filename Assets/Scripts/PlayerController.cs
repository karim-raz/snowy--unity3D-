 using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public bool isGrounded=true;
	public AudioClip jumpy;
	public AudioClip shot;
	public GameObject Bglooper;
	public GameObject hp_bar;
	public GameObject boule,monster;
	public GameObject zijump;
	public static  float velocity =12;
	private float time=5f; 
	public static bool Dead = false ; 
	public GameObject Gameover;
	public GameObject info;
	public AudioClip sound ; 
	 GameObject expl;
	int	dist=0 ;
	public GameObject cameras;
	public GameObject explosion;
	public GameObject player;
	public Projectile Projectile;
	public float FireRate;
	private float _canfireIn;
	public GameObject Family;
	public Transform ProjectileFireLocation;
	bool jumped = false;
	bool familyback=false;
	int x;
	// Use this for initialization
	void Start () {
		x = PlayerPrefs.GetInt("music", 0);
		if (x == 0) {

						AudioListener.volume = 0;

				}else {
			AudioListener.volume = 1;		
		}
		velocity =12;
		Family.SetActive (false);
		familyback=false;

	dist=0 ;
	}
	void FixedUpdate()
	{

		if (Dead == false) {
			
			transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
			transform.Rotate (new Vector3 (0f, 0f, -15f));

            if(dist>=7)

			{
				Bglooper.SetActive(true);
			}
			if (avalController.canjump_again == true  ) {
				Jump ();
				hp_bar.SetActive(false);
				velocity += 0.0002f; 

				if(familyback==false)
					Invoke ("nextstage",7f);
			}

			if (dist >=5 && MonsterHealthManager.health_m > 0 && MonsterHealthManager.killed==false && avalController.canjump_again == false ) {
				if (jumped==false){
					rigidbody2D.AddForce (new Vector2(0f,1100f));
					rigidbody2D.AddForce (new Vector2(-700f,0f));
					zijump.SetActive(true);
					velocity =9.9f;
					Invoke("jumpb",0.45f);
				}
				Bullet ();
			}
			if (dist <5) {
				Jump ();
				velocity += 0.0002f; 
				
			}


		}

	}
	// Update is called once per frame
	void Update () {
		dist = PlayerPrefs.GetInt("distance", 0);
		_canfireIn -= Time.deltaTime;


			
		if (Dead == false) {
			if ( avalController.canjump_again == true  ) {
				Jump ();
				
				hp_bar.SetActive(false);
				velocity += 0.0002f; 
				if(familyback==false)
				Invoke ("nextstage",7f);
			}

			if (dist >=5 && MonsterHealthManager.health_m > 0&& MonsterHealthManager.killed==false && avalController.canjump_again == false ) {
		if (jumped==false){
				rigidbody2D.AddForce (new Vector2(0f,1200f));
				rigidbody2D.AddForce (new Vector2(-800f,0f));
					zijump.SetActive(true);
					velocity =9.9f;
			Invoke("jumpb",0.45f);
				}
				Bullet ();
			}
			if (dist <5) {
				Jump ();
				velocity += 0.0001f; 
			}


		

						


						

						
				}
				
		if (Dead&&familyback==false) {
		


				if (expl==null){
					audio.PlayOneShot(sound, 0.7F);

					expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
				}

				
				transform.Translate (new Vector3 (0f, 0f, 10f), Space.World);
//			
			monster.transform.Translate (new Vector3 (0f, 0f, 10f), Space.World);
			boule.transform.Translate (new Vector3 (0f, 0f, 10f), Space.World);
				Gameover.SetActive(true);
				info.SetActive(false);

			}
		if (Dead&&familyback==true) {
			
			
			
			if (expl==null){
				audio.PlayOneShot(sound, 0.7F);
				
				expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
			}
			
			
			transform.Translate (new Vector3 (0f, 0f, 10f), Space.World);
			Family.SetActive (false);

			boule.transform.Translate (new Vector3 (0f, 0f, 10f), Space.World);
			Gameover.SetActive(true);
			info.SetActive(false);
			
		}
			

			
			


					

				
		}
	
	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Ground") {
			
			isGrounded=true;
		}
		if (collision.gameObject.tag == "Monster") {

			Dead = true ; 

		}
		if (collision.gameObject.tag == "Family") {

			Dead = true ; 
			
		}

		
		
	}
	void OnCollisionExit2D(Collision2D collision){
		if (collision.gameObject.tag == "Respawn") {
			rigidbody2D.AddForce (new Vector2(500f,0f));
			rigidbody2D.AddForce (new Vector2(0f,1400f));
		}
		
		
	}

	/*
	if (collision.gameObject.tag == "Respawn") {
		rigidbody2D.AddForce (new Vector2(0f,1800f));
		rigidbody2D.AddForce (new Vector2(900f,0f));
		velocity =  30;
	}
	
	
}
void OnCollisionExit2D(Collision2D collision){
	if (collision.gameObject.tag == "Respawn") {
		rigidbody2D.AddForce (new Vector2(-300f,0f));
		velocity =  12;
		//rigidbody2D.AddForce (new Vector2(0f,1800f));
	}

}
*/


	
	void Jump(){
		if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space)) {
				
			if(isGrounded==true){
				rigidbody2D.AddForce (new Vector2(0f,1500f));
				audio.PlayOneShot(jumpy, 0.3F);

				isGrounded=false;
			}

			
		}
	
		
	}
	void jumpb()
	{
		rigidbody2D.AddForce (new Vector2(0f,-1100f));
		rigidbody2D.AddForce (new Vector2(740f,0f));
		//velocity = velocity + 0.0001f;
		jumped = true;
	}
	void Bullet(){
		if (Input.GetMouseButtonDown (0))
						FireProjectile ();
	}
	private void FireProjectile() {
	
	if (_canfireIn > 0)
						return;

		var projectile = (Projectile)Instantiate (Projectile,ProjectileFireLocation.position,ProjectileFireLocation.rotation);
		var direction= transform.right ;
		projectile.Initialize (player, direction, new Vector2(5,0));
		audio.PlayOneShot(shot, 0.7F);

		_canfireIn = FireRate;

	}

	public void nextstage()
	{
		velocity = 12;

		Invoke ("family", 2f);

	}

	public void family(){
		Family.transform.position = new Vector3 (transform.position.x-22f,Family.transform.position.y, Family.transform.position.z);
		Family.SetActive(true);
		familyback=true;

	}
}
//-301
//-357