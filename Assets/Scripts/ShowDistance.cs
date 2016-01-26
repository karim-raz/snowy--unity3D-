using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowDistance : MonoBehaviour
{
    Text instruction;
    public string score;
    public int importedScore;


    GameObject boule;
    // Use this for initialization
    void Start()
    {
        boule = GameObject.FindGameObjectWithTag("boule");
       
        instruction = GetComponent<Text>();
        instruction.text = "000";
        // score = ;
    }


    void FixedUpdate()
	{     int s = (int)boule.transform.position.x/100;
		PlayerPrefs.SetInt("distance", s);
            instruction.text = "" + s.ToString() +"M" ;
    }






}
