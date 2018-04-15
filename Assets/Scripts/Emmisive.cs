using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emmisive : MonoBehaviour {

	public Material mat;

	void Start () {
		
	}

	void OnCollisionEnter (Collision collision) {

		collision.gameObject.GetComponent<Renderer> ().material.SetColor ("_EmmisionColor", Color.green);

	}
}
