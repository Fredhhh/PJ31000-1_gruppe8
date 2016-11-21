using UnityEngine;
using System.Collections;

public class soverom : MonoBehaviour {


	// Use this for initialization
	void Start () {
		tp1 ();
	}

	// Update is called once per frame
	public void tp1 () {
		gameObject.transform.position = new Vector3 (2, 0.5f, 2.6f);
	}
}