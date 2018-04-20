using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baarrier : MonoBehaviour {

	public GameObject key;
	public GameObject target;

	void OnTriggerEnter(Collider col){
		if(col.name == key.name){
			Destroy (target);
		}
	}
}
