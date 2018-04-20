using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour {

	public Transform[] path;
	public int speed;

	// Use this for initialization
	void Start () {
		StartCoroutine (FollowPath());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator FollowPath(){
		foreach (Transform waypoint in path) {
			yield return StartCoroutine (Move (waypoint.position, speed));
		}
	}

	IEnumerator Move(Vector3 destination, float speed){
		while(transform.position != destination){
			transform.position = Vector3.MoveTowards (transform.position, destination, speed * Time.deltaTime);
			yield return null;
		}
	}
}
