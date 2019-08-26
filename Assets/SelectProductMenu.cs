using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectProductMenu : MonoBehaviour {

	public void Atlas(){
		SceneManager.LoadScene (2);
	}

	public void Back(){
		SceneManager.LoadScene (0);
	}

}
