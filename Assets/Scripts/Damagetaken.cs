using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Healthtaken : MonoBehaviour {
	public Scrollbar healthybar;
	public float health =100;

	public void Damage (float value) {
	
		health -= value;
		healthybar.size = health / 100f;
	}
}
