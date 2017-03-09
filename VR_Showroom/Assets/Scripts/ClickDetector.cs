using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDetector : MonoBehaviour {

	public GameObject library;

    public bool clicked;

    public bool kitchenWhites;
    public bool kitchenTiles;

    // Use this for initialization
    void Start() {
		library = GameObject.FindGameObjectWithTag ("Pad");
    }

    // Update is called once per frame
    void Update() {

    }

    public void OnMouseEnter()
    {

    }

	public void OnMouseDown()
    {
		library.GetComponent<MatLibrary>().activeObject = gameObject;

        clicked = true;

        if (tag.Equals("KitchenWhites"))
        {
            kitchenTiles = false;
            kitchenWhites = true;
        }

        else if (tag.Equals("KitchenTiles"))
        {
            kitchenWhites = false;
            kitchenTiles = true;
        }

    }
   
}

