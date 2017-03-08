using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatChanger : MonoBehaviour {

	public GameObject library;

    GameObject changeableObject;

    // Use this for initialization
    void Start() {
		library = GameObject.FindGameObjectWithTag ("Pad");
    }

    // Update is called once per frame
    void Update() {
		
		changeableObject = library.GetComponent<MatLibrary>().activeObject;
    }

    public void ChangeTexture()
    {
        changeableObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
    }

}
