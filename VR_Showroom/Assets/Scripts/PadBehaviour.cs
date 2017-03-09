using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PadBehaviour : MonoBehaviour {

    public Canvas hjem;
    public Canvas etasjeEn;
    public Canvas etasjeTo;
    public Canvas materialMenu;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if(materialMenu.enabled)
        {

        }

    }

    public void HjemChange()
    {
        hjem.enabled = true;
        etasjeEn.enabled = false;
        etasjeTo.enabled = false;
        materialMenu.enabled = false;
    }

    public void EtasjeEnChange()
    {
        hjem.enabled = false;
        etasjeEn.enabled = true;
        etasjeTo.enabled = false;
        materialMenu.enabled = false;
    }

    public void EtasjeToChange()
    {
        hjem.enabled = false;
        etasjeEn.enabled = false;
        etasjeTo.enabled = true;
        materialMenu.enabled = false;
    }

    public void MaterialMenuChange()
    {
        hjem.enabled = false;
        etasjeEn.enabled = false;
        etasjeTo.enabled = false;
        materialMenu.enabled = true;
    }

}
