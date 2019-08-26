using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baberian : MonoBehaviour {

	public Transform[] target;
	public float speed;

	private int current;

	void Start () {
		StartCoroutine (BaberianMove ());
	}

	// Update is called once per frame
	IEnumerator BaberianMove() {
		while (true) {
			if (transform.position != target [current].position) {
				Vector3 pos = Vector3.MoveTowards (transform.position, target [current].position, speed * Time.deltaTime);
				GetComponent<Rigidbody> ().MovePosition (pos);
			} else {
				current = (current + 1) % target.Length;
			}
			yield return new WaitForSeconds(1);
		}

	}
}
