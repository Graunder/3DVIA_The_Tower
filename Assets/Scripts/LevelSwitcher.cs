using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitcher : MonoBehaviour {

	public string targetLevel;

	private void OnTriggerEnter(Collider col){
		if(col.CompareTag("Player")){
			SceneManager.LoadScene (targetLevel);
		}
	}

}
