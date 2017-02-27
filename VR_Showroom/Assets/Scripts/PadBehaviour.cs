using UnityEngine;
using System.Collections;

public class PadBehaviour : MonoBehaviour {

    public Canvas hjem;
    public Canvas etasjeEn;
    public Canvas etasjeTo;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    public void HjemChange()
    {
        hjem.enabled = true;
        etasjeEn.enabled = false;
        etasjeTo.enabled = false;
    }

    public void EtasjeEnChange()
    {
        hjem.enabled = false;
        etasjeEn.enabled = true;
        etasjeTo.enabled = false;
    }

    public void EtasjeToChange()
    {
        hjem.enabled = false;
        etasjeEn.enabled = false;
        etasjeTo.enabled = true;
    }
}
