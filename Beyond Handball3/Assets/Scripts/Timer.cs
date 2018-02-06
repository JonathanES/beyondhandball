using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timer;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () 
	{
		timer -= Time.deltaTime;
		if (timer<=0) 
		{
			timer=0;


			
		}
	}
	void OnGUI()
	{
		GUILayout.Label("Fin du match !");
		GUI.Box(new Rect(10,10,50,20),""+timer.ToString("0"));

	}
}
