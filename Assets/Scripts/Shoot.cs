using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

	public Rigidbody projectile;
	public Transform spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse0)){

			Rigidbody clone;
			clone = (Rigidbody)Instantiate(projectile, spawn.position, spawn.rotation);
			//clone.velocity = spawn.TransformDirection (Vector3.forward*20);
			clone.AddForce(clone.transform.forward * 1000);

		}
	}
}
