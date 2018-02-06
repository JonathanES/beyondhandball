using UnityEngine;
using System.Collections;

public class ToucheBut : MonoBehaviour 
{
	public Transform target;
	public Transform joueur;
	public Transform pivot;
	public Transform gardien;
	public Transform remisejeugardien;
	public Transform remisejeubut;
	public float movespeed;
	
	// Update is called once per frame
	void Update () {
		if (target.position.z <= -13.0) {   //touche
			joueur.position = Vector3.MoveTowards (joueur.position, target.position, movespeed * Time.deltaTime);
		} 
		if (target.position.z >= 7.5) { // touche
			joueur.position = Vector3.MoveTowards (joueur.position, target.position, movespeed * Time.deltaTime);
		}			
		if ((target.position.z < 7.5 && target.position.z > -0.6 && target.position.x < -19.5) || (target.position.z > -13.0 && target.position.z < -4.44 && target.position.x < -19.5) || (target.position.z < 7.5 && target.position.z > -0.6 && target.position.x > 26.0) || (target.position.z > -13.0 && target.position.z < -4.44 && target.position.x > 26.0)) {
			gardien.position = Vector3.MoveTowards (gardien.position, remisejeugardien.position, movespeed * Time.deltaTime);
			//gardien.position = Vector3.MoveTowards (-15.0, 4.03, -2.0);// sortie du  but
			//target.SetParent = gardien;
		}			
		if ((target.position.z < -0.6 && target.position.z > -4.44 && target.position.x < -19.5 && target.position.y < 7.0) || (target.position.z < -0.6 && target.position.z > -4.44 && target.position.x > 26.0 && target.position.y < 7.0)) {
			pivot.position = Vector3.MoveTowards (pivot.position, remisejeubut.position, movespeed * Time.deltaTime);
			//pivot.position = Vector3.MoveTowards (3.0, 4.03, -2.5); //but
			//target.SetParent = pivot;
		}
	}
}

				