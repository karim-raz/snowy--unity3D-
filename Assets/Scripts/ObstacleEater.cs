using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ObstacleEater : MonoBehaviour {
    public float randomize;
    List<float> randomElement = new List<float>();
    float newPosition=0; 
	int	dist=0 ;
	ex  e;
	// Use this for initialization
	void Start () {
		e = GetComponent<ex> ();
	    
		dist=0 ;

       
	}
	
	// Update is called once per frame
	void Update () {
		dist = PlayerPrefs.GetInt("distance", 0);
	}


    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Monster")
        {
          //  Destroy(gameObject);
			e.Explosion();
			newPosition= transform.position.x + 1090;
            transform.position = new Vector2(newPosition, transform.position.y);
            Debug.Log("Monster Colliding");
           

        }
		if (dist >= 7) {
		if (collision.gameObject.tag == "Family")
		{
			//  Destroy(gameObject);
			e.Explosion();
			newPosition= transform.position.x + 1090;
			transform.position = new Vector2(newPosition, transform.position.y);
			Debug.Log("Monster Colliding");
			
			
			}
		}
    }


    int RandomElementRange(int index_1, int index_2)
    {   
        int index;
        index = Random.Range(index_1, index_2);
        index = Mathf.RoundToInt(index);
        return index;
    }

}
