using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour {

	public Transform TransformCamera;
	public LayerMask RayMask;
	public Transform hold;

	private RaycastHit hit;
	private Transform currentTransform;
	private float lenght;

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Mouse1)){
			if(Physics.Raycast(TransformCamera.position, TransformCamera.forward, out hit, 3f, RayMask)){
				if(hit.transform.tag == "PickableObject"){
					SetNewTransform (hit.transform);
				}
			}
		}

		if(Input.GetKeyUp(KeyCode.Mouse1)){
			RemoveTransform ();
		}

		if(currentTransform){
			MoveTransformAround ();
		}
	}

	public void SetNewTransform(Transform newTransform){
		if(currentTransform){
			return;
		}
		newTransform.position = hold.position;
		currentTransform = newTransform;
		//lenght = Vector3.Distance (TransformCamera.position, newTransform.position);
		currentTransform.GetComponent<Rigidbody> ().isKinematic = true;
	}

	private void MoveTransformAround(){
		//currentTransform.position = TransformCamera.position + TransformCamera.forward * lenght;
		currentTransform.position = hold.position;
	}

	public void RemoveTransform(){
		if(!currentTransform){
			return;
		}

		currentTransform.GetComponent<Rigidbody> ().isKinematic = false;
		currentTransform = null;
	}
}
