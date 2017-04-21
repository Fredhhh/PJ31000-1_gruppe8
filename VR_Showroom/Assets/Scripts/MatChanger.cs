using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatChanger : MonoBehaviour {

	public GameObject library;
    public string currentTag;

    GameObject changeableObject;
    GameObject[] changeableObjects;

    // Use this for initialization
    void Start() {
		library = GameObject.FindGameObjectWithTag ("Pad");
    }

    // Update is called once per frame
    void Update() {
		
		changeableObject = library.GetComponent<MatLibrary>().activeObject;
        currentTag = changeableObject.tag;
        changeableObjects = GameObject.FindGameObjectsWithTag(currentTag);
    }

    public void ChangeTexture()
    {
        foreach (GameObject obj in changeableObjects)
        {
            obj.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
            //changeableObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
        }
    }

}
