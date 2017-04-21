using UnityEngine;
using System.Collections;

public class LightSwitcher : MonoBehaviour
{



    public GameObject light;
  

    public bool on;

    // Use this for initialization
    void Start()
    {


        on = true;
        light.GetComponent<Light>().enabled = true;


    }

    // Update is called once per frame
    void Update()
    {



    }

    void OnMouseDown()
    {

        if (on == false)
        {
            on = true;
            light.GetComponent<Light>().enabled = true;


        }

        else if (on == true)
        {
            on = false;
            light.GetComponent<Light>().enabled = false;

        }
    }
}