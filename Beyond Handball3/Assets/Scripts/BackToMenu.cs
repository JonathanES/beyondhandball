using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width/2.8f, Screen.height/8, Screen.width/5, Screen.height/10), "Menu")) 
		{
			Application.LoadLevel(0);
		}
}
}
