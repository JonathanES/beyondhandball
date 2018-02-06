using UnityEngine;
using System.Collections;

public class patrolpoints : MonoBehaviour {

	public Transform[] Points;
	public Transform target;
	public float movespeed;
	public int rotationspeed;


	private Transform myTransform;

	private int currentpoint;

	Animator anim;
	void Awake()
	{
		myTransform = transform;
		anim = GetComponent<Animator> ();
	}

	void Start () 
	{
		transform.position = Points[0].position;
		currentpoint = 0;

		GameObject go = GameObject.FindGameObjectWithTag("Player");
		target = go.transform;

	}
	
	// Update is called once per frame
	void Update () 
	{
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation,Quaternion.LookRotation(target.position-myTransform.position),rotationspeed*Time.deltaTime);

		if (transform.position==Points[currentpoint].position) 
		{
			currentpoint++;

		}
		if (currentpoint >= Points.Length) 
		{
			currentpoint=0;
		}
		transform.position = Vector3.MoveTowards (transform.position, Points [currentpoint].position, movespeed * Time.deltaTime);
	}
}
