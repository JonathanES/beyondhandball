using UnityEngine;
using System.Collections;

public class ethan : MonoBehaviour 
{

	Animator anim;

	public float verti;
	public float horizontal;
	public float turn;
	public float hori;
	public float turning;
	public float side;

	public float gravity=9.8f;
	public float movespeed=5f;
	public float turnspeed=50f;
	public float jumpspeed=5f;

	Vector3 move;


	int jumpHash=Animator.StringToHash("Jump");



	protected CharacterController control;

	// Use this for initialization
	void Start () 
	{

		anim = GetComponent<Animator> ();
		control = GetComponent<CharacterController> ();

	}
	
	// Update is called once per frame
	void Update () 
	{

		verti = Input.GetAxis ("Vertical");
		transform.Rotate (0, Input.GetAxis ("Horizontal") * turnspeed * Time.deltaTime, 0);
		
		
		
		if (Input.GetKey(KeyCode.DownArrow)) 
		{
			verti =-0.2f;
		}
		else if (Input.GetKey(KeyCode.Space)) 
		{
			anim.SetTrigger(jumpHash);
		}

		else if (Input.GetKey(KeyCode.Q)) 
		{
			horizontal=0.3f;


		}
		else if (Input.GetKey(KeyCode.F)) 
		{
			turning=0.3f;
		}
		else if (Input.GetKey(KeyCode.X)) 
		{
			side=-0.3f;
		}
		else if (Input.GetKey(KeyCode.C)) 
		{
			side=0.3f;
		}
		else {
			horizontal=0.0f;
			turning=0.0f;
			side=0.0f;
		}

		anim.SetFloat ("Speed", verti);
		anim.SetFloat ("Turn", horizontal);
		anim.SetFloat ("turning", turning);
		anim.SetFloat ("side", side);


	}




}

