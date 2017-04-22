using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOnOff : MonoBehaviour
{
    public bool on;
    public GameObject[] lightSwitches;

    // Use this for initialization
    void Start()
    {
        lightSwitches = GameObject.FindGameObjectsWithTag("LightSwitch");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void lightsOnOff()
    {

        on = !on;
        foreach (GameObject lightSwitch in lightSwitches)
        {
            if (on)
            {
                lightSwitch.GetComponent<Lightswitcher>().off = true;
            }
            else if (!on)
            {
                lightSwitch.GetComponent<Lightswitcher>().off = false;

            }
        }
    }
}
