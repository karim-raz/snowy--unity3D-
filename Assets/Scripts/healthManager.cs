using UnityEngine;
using System.Collections;

public class healthManager : MonoBehaviour {
	public float health = 60;
    public bool isTouched = false;
    public static float lastObstacle = 30.0f; 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(3.0f * (health / 100), 3.0f * (health / 100), 0);
        if ((isTouched==true)&&(health>=30))
        {
            health--;
        }
	}

  

 
    void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.name == "monster" ) || (collision.gameObject.name == "moun"))
        {
           
            isTouched = true;
        }
    }

    void OnCollisionStay2D(Collision2D collision)
    {
		if ((collision.gameObject.tag == "Ground")&&(isTouched==false)&&(health<=70))
        {

            health++;
        }
    }



    void OnCollisionExit2D(Collision2D collision)
    {
		if ((collision.gameObject.tag == "Ground")&&(isTouched==true)&&(health<=70))
        {
            
            isTouched = false;
        }
    }


           
}
