using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickDetector : MonoBehaviour {

    public bool clicked;

    public bool kitchenWhites;
    public bool kitchenTiles;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void OnMouseEnter()
    {

    }

    public void OnMouseDown()
    {
        clicked = true;

        if (tag.Equals("KitchenWhites"))
        {
            kitchenTiles = false;
            kitchenWhites = true;
            transform.tag = "KitchenWhites";
        }

        else if (tag.Equals("KitchenTiles"))
        {
            kitchenWhites = false;
            kitchenTiles = true;
            transform.tag = "ChangeableObject";

        }

    }
    

}

