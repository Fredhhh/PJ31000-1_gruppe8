﻿using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour
{

    public Canvas mainCanvas;
    public Canvas bolig1;
    public Canvas bolig2;
    public Canvas bolig3;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void mainChange()
    {
        mainCanvas.enabled = true;
        bolig1.enabled = false;
        bolig2.enabled = false;
        bolig3.enabled = false;
    }

    public void bolig1Change()
    {
        mainCanvas.enabled = false;
        bolig1.enabled = true;
        bolig2.enabled = false;
        bolig3.enabled = false;
    }

    public void bolig2Change()
    {
        mainCanvas.enabled = false;
        bolig1.enabled = false;
        bolig2.enabled = true;
        bolig3.enabled = false;
    }

    public void bolig3Change()
    {
        mainCanvas.enabled = false;
        bolig1.enabled = false;
        bolig2.enabled = false;
        bolig3.enabled = true;
    }
}
