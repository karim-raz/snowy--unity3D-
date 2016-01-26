using UnityEngine;
using System.Collections;

public class changescript : MonoBehaviour {
	public bool CanPause;
	public bool CanMute;
	bool opt = false;
	bool opt2 = false;
	float ButtonLeft = 0.0f;
	private bool showButton  = true;
	public  Texture2D icon;
	public  Texture2D icon2;
	public  Texture2D icon3;
	public Texture2D icon4;
	public Texture2D icon5;
	public GUIStyle style;
	public GUIStyle style2;

	void Start (){

	}
	
	
	void OnGUI(){
		if(showButton){
			if(GUI.Button (new Rect (Screen.width/2 -195, ButtonLeft, Screen.width/2-50, Screen.height/2-50) , icon,style)) {

			opt = !opt;
				showButton = false;

			//Application.LoadLevel ("scene1");
				}
		}

		if (opt && GUI.Button (new Rect (Screen.width / 2 - 195, Screen.height / 2 - 70, Screen.width / 2 - 50, Screen.height / 2 - 50), icon2, style)) {
						if (!showButton) {
				
								opt = !opt;
						}
				
				}

	
}

}