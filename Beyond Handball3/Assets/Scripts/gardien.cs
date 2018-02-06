using UnityEngine;
using System.Collections;

public class gardien : MonoBehaviour {

	Animator anim;

	public float side=20.0f;

	private float counter=1;
	// Use this for initialization
	void Start () 
	{
		anim = GetComponent<Animator> ();

	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (side<20.0f) 
		{
			side=0.1f+side;

		}
		else 
		{
			side=0.0f;

		}

		anim.SetFloat ("goal", side);
	}
}
