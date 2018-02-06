using UnityEngine;
using System.Collections;

public class music : MonoBehaviour {

	private static music instance = null;
	public static music Instance {
		get { return instance; }
	}
	void Awake() 
	{
		if (GUI.Button (new Rect (Screen.width/4.5f, Screen.height/1.5f, Screen.width/5, Screen.height/10), "Instructions")) 
		{
			DontDestroyOnLoad(this.gameObject);
		}
		else if (GUI.Button (new Rect (Screen.width/4.5f, Screen.height/3, Screen.width/5, Screen.height/10), "Play"))  {
			Destroy(this.gameObject);
			return;
		}

	}
	
	// any other methods you need
}

	
	// any other methods you need

