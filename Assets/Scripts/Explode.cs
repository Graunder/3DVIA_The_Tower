using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour {

	public GameObject prefab;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter (Collision collision) {

		//GameObject prefab = Resources.Load ("Explosion") as GameObject;
		GameObject explosion = Instantiate (prefab) as GameObject;
		explosion.transform.position = transform.position;
		Destroy (explosion, 2);
		Destroy (gameObject);

	}
}
