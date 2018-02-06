using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public Rigidbody projectile;
	public float speed=20;


	private float counter=1;
	public float power;

	public GameObject arrow;


	 float rotationSpeed = 10;

	int theAngle;
	int maxAngle=130;
	int minAngle=0;

	float shotForce=25;


	void Start () {

			
            
			}
	void Update()
	{
	}
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetKeyDown (KeyCode.B)&& counter<0) 
		{

			Rigidbody instantiatedProjectile = Instantiate (projectile, transform.position, transform.rotation)as Rigidbody;			
			instantiatedProjectile.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
			Destroy (instantiatedProjectile.gameObject, 2);

			counter=1;

		}
		
		counter-=Time.deltaTime;
	}
	

}
