using UnityEngine;

using System.Collections;


public class Ball : MonoBehaviour 
{

	
public Transform target;

public Transform[] Points;
   
 public float movespeed=5f;
	
public float rotationspeed=5f;




	protected CharacterController control;

	
Vector3 move;

	
private Transform myTransform;

	void Awake()
	
{
		
myTransform = transform;

	}
	
void Start()
	
{
		
GameObject go = GameObject.FindGameObjectWithTag ("Player");

		target = go.transform;

		transform.position = Points[0].position;



	}
	
	
// Update is called once per frame

	void Update () 
	{
	
		myTransform.rotation = Quaternion.Slerp(myTransform.rotation,Quaternion.LookRotation(target.position-myTransform.position),rotationspeed*Time.deltaTime);
		
		myTransform.position += myTransform.forward * movespeed * Time.deltaTime;



	
	}
}

