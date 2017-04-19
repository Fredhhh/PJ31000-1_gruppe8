using UnityEngine;
using System.Collections;

public class Lightswitcher : MonoBehaviour
{



    public GameObject light;
    public GameObject light2;
 

    public bool on;

    // Use this for initialization
    void Start()
    {


        on = true;
        light.GetComponent<Light>().enabled = true;
        light2.GetComponent<Light>().enabled = true;


    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnMouseDown()
    {

        if (on == true)
        {
            on = false;
            light.GetComponent<Light>().enabled = false;
            light2.GetComponent<Light>().enabled = false;


        }

        else if (on == false)
        {
            on = true;
            light.GetComponent<Light>().enabled = true;
            light2.GetComponent<Light>().enabled = true;

        }
    }
}