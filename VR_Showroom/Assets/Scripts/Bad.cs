using UnityEngine;
using System.Collections;

public class Bad : MonoBehaviour {


	// Use this for initialization
	void Start () {
		tp2 ();
	}

	// Update is called once per frame
	public void tp2 () {
		gameObject.transform.position = new Vector3 (6, 0.5f, -5);
	}
}