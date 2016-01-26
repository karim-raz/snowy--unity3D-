using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MonsterHealthManager : MonoBehaviour {
	public  static float health_m = 100;
	public bool isTouched = false;
	
	public Scrollbar healthybar;
	public GameObject hp_bar;
	public AudioClip hit;
	public AudioClip destroyed;
	public GameObject explosion;
	GameObject expl;
	bool oneshot=true;
	public static bool killed=false;
	public static bool killed2=true;
	public  bool killed3=false;
	int dist ;
	// Use this for initialization
	void Start () {
		dist =0;
		killed=false;
		health_m=100;
		killed2=true;

	}
	
	// Update is called once per frame
	void Update () {
		dist = PlayerPrefs.GetInt ("distance", 0);
		
		if ((dist >= 5) && (health_m == 100) && (killed == false) && killed3==false) {
			
			
			Invoke ("hpbar", 1);
			
			
			
		}
		if ((isTouched == true) && (health_m > 0)) {
			audio.PlayOneShot (hit, 0.3F);
			health_m -= 5;
			isTouched = false;
		}
		if ((health_m == 0  && killed3==true)) {

			hp_bar.SetActive (false);
			killed = true;
			
		}
	}
	
	//-191
	//-370
	
	
	void OnTriggerEnter2D(Collider2D collision)
	{
		if ((collision.gameObject.tag == "fire" ))
		{
			Damage (5);
			Destroy(GameObject.FindGameObjectWithTag("fire") );
			isTouched = true;
			if (expl==null){
				
				expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
				if(oneshot==true){
				audio.PlayOneShot(destroyed, 0.3F);
				oneshot=false;
				}
			}
			Destroy(expl, 0.2f);
		}
	}


	
	public void Damage (float value) {
		
		health_m -= value;
		healthybar.size = health_m / 100f;
	}
	
	public void hpbar(){
		
		hp_bar.SetActive(true);
		killed3=true;
	}
	

	
	
}
