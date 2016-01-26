using UnityEngine;
using System.Collections;

public class monsterHP : MonoBehaviour {
	public Transform monster;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.position = new Vector3 (monster.position.x, monster.position.y+10f, monster.position.z);
	}
}
