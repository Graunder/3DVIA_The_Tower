using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPuzzle : MonoBehaviour {

	public string colorName;
	public GameObject toDestroy;
	private bool cont;

	IEnumerator WaitToDestroy(){
		yield return new WaitForSeconds (2);
		Destroy (toDestroy);
	}

	public void OnTriggerEnter(Collider other){
		if(other.gameObject.tag == colorName){
			cont = true;
		}
	}

	IEnumerator Update(){
		if(cont == true){
			yield return StartCoroutine (WaitToDestroy);
		}
	}

}
