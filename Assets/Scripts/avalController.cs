using UnityEngine;
using System.Collections;

public class avalController : MonoBehaviour {
	public  float velocity =12;
	public GameObject monstere;
	float time=1f;
	int dist ;

	bool killed1=false;
	public static bool canjump_again=false;
	// Use this for initialization
	void Start () {
		MonsterHealthManager.health_m = 100;
		MonsterHealthManager.killed = false;
		canjump_again=false;
		rigidbody2D.AddForce (new Vector2(0f,500f));
	 dist =0;
		velocity =12;
	}
	void FixedUpdate()
	{

		if (PlayerController.Dead == false && killed1 == true) {
						velocity = 10;
				}
			if (MonsterHealthManager.health_m == 0&& MonsterHealthManager.killed ==true ) {

				velocity = 19;
				
				transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
				velocity = 10;
				
				if (time > 0)
					time -= Time.deltaTime;
				else {
					rigidbody2D.AddForce (new Vector2 (0f, 500f));
					
					time = 1f;
					
					
				}
				Invoke("destroymonster",6f);
			}

			if (dist >=5  && MonsterHealthManager.health_m > 0) {

				transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
				velocity =10;

				if (time > 0)
					time -= Time.deltaTime;
				else {
					rigidbody2D.AddForce (new Vector2 (0f, 500f));

					time = 1f;
					
					
				}
					
				


			}
			if (dist  <5) {
				transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
				velocity += 0.0008f; 
			
				if (time > 0)
					time -= Time.deltaTime;
				else {
					rigidbody2D.AddForce (new Vector2 (0f, 500f));
					rigidbody2D.AddForce (new Vector2 (5f, 0f));
					time = 1f;

					
				}
			}

		}


	// Update is called once per frame
	void Update () {
		//rigidbody2D.AddForce (new Vector2(5f, 0f));
		dist = PlayerPrefs.GetInt("distance", 0);

		
	}

	public void nextstage()
	{
		transform.Translate (new Vector3 (Time.deltaTime * velocity, 0f, 0f), Space.World);
		velocity += 0.0002f; 
		
		if (time > 0)
			time -= Time.deltaTime;
		else {
			rigidbody2D.AddForce (new Vector2 (0f, 500f));
			rigidbody2D.AddForce (new Vector2 (5f, 0f));
			time = 1f;
			
			
		}

	}
	
	public void destroymonster()
	{
		
	monstere.SetActive(false);

		killed1 = true;
		canjump_again = true;
	}

		}
		
		
