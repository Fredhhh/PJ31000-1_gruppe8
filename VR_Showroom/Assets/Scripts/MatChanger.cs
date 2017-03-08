using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatChanger : MonoBehaviour {

    GameObject changeableObject;

    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {

        changeableObject = GameObject.FindGameObjectWithTag("ChangeableObject");

    }

    public void ChangeTexture()
    {
    
        changeableObject.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;

    }

}
