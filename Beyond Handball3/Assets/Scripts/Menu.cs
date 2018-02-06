using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour 
{
	public AudioSource _AudioSource1;
	public AudioSource _AudioSource2;
	
	void Start() 
	{

		_AudioSource2.Play();
		_AudioSource1.Pause();
	}
	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width/4.5f, Screen.height/3, Screen.width/5, Screen.height/10), "Play")) 
		{
			Application.LoadLevel(1);

		}
		if (GUI.Button (new Rect (Screen.width/6.5f, Screen.height/2, Screen.width/6, Screen.height/10), "Music 1")) 
		{
			_AudioSource1.Pause();
			
			_AudioSource2.Play();
		}
		if (GUI.Button (new Rect (Screen.width/3.0f, Screen.height/2, Screen.width/6,Screen.height/10), "Music 2")) 
		{
			_AudioSource2.Pause();
			
			_AudioSource1.Play();
			
		}

		if (GUI.Button (new Rect (Screen.width/4.5f, Screen.height/1.5f, Screen.width/5, Screen.height/10), "Instructions")) 
		{
			Application.LoadLevel(2);

		}

	}
}
