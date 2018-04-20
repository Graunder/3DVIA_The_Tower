using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {


	public AnimationClip Animation;
	public AnimationClip Animation2;
	private Animation trig;
	public int score;

	// Use this for initialization
	void Start () {
		
	}
	
	void OnCollisionEnter (Collision collision) {

		if (collision.gameObject.tag == "Projectile") {
			trig = GetComponent<Animation> ();
			trig.Play (Animation.name);
			trig.Play (Animation2.name);
			score++;
		}

	}
}
