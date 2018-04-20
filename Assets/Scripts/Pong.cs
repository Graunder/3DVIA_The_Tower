using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pong : MonoBehaviour {

	public Transform toMove;
	public Transform pos1;
	public Transform pos2;
	public Vector3 newPos;
	public string state;

	public float smooth;
	public float reset;

	// Use this for initialization
	void Start () {
		ChangeTarget ();
	}
		
	void FixedUpdate () {
		toMove.position = Vector3.Lerp (toMove.position, newPos, smooth * Time.deltaTime);
	}

	void ChangeTarget(){
		if(state == "Move to 1"){
			state = "Move to 2";
			newPos = pos2.position;
		}
		else if(state == "Move to 2"){
			state = "Move to 1";
			newPos = pos1.position;
		}
		else if(state == ""){
			state = "Move to 2";
			newPos = pos2.position;
		}

		Invoke ("ChangeTarget", reset);
	}

}
