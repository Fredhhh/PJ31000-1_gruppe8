using UnityEngine;
using System.Collections;

public class kjokken : MonoBehaviour {


	// Use this for initialization
	void Start () {
		tp ();
	}

	// Update is called once per frame
	public void tp () {
		gameObject.transform.position = new Vector3 (3, 0.5f, -5);
	}
}