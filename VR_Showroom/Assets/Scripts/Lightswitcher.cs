using UnityEngine;
using System.Collections;

public class Lightswitcher : MonoBehaviour
{


	public GameObject[] lights;


    public bool off;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject light in lights)
        {
            if (!off)
                light.GetComponent<Light>().enabled = true;
            else if (off)
                light.GetComponent<Light>().enabled = false;
        }
    }

    public void OnMouseDown()
    {

        off = !off;

      

    }

}