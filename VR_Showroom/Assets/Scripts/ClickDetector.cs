using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDetector : MonoBehaviour {

	public GameObject library;

    public bool clicked;

    public bool kitchenWhites;
    public bool kitchenTiles;
	public bool mainFloor;
	public bool mainWalls;
	public bool couch1;
    public bool windowSills;
    public bool bathroomFloor;
    public bool bathroomWalls;

    // Use this for initialization
    void Start() {
		library = GameObject.FindGameObjectWithTag ("Pad");
    }

    public void OnMouseEnter()
    {

    }

	public void OnMouseDown()
    {
        
        library.GetComponent<MatLibrary>().activeObject = gameObject;
        library.GetComponent<PadBehaviour>().MaterialMenuChange();

        clicked = true;

        if (tag.Equals("KitchenWhites"))
        {
            kitchenWhites = true;
        }
		else if (tag.Equals("MainFloor"))
		{
			mainFloor = true;
		}
		else if (tag.Equals("MainWalls"))
		{
			mainWalls = true;
		}
		else if (tag.Equals("Couch1"))
		{
			couch1 = true;
		}
        else if (tag.Equals("WindowSill"))
        {
            windowSills = true;
        }
        else if (tag.Equals("BathroomFloor"))
        {
            bathroomFloor = true;
        }
        else if (tag.Equals("BathroomWalls"))
        {
            bathroomWalls = true;
        }

    }
   
}

