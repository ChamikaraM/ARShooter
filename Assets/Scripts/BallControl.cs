using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Baberian") {
			uiManager.updateScore ();
			Destroy (gameObject);
		}

	}
}
