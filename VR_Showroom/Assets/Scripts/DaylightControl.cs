using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaylightControl : MonoBehaviour {

    public Slider daylightSlider;
    private float daylightSliderIntensity;
    public Light sun;
    private float sunIntensity;


    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        sunIntensity = sun.GetComponent<Light>().intensity;
	}

    public void changeDaylight(float newValue)
    {
        sunIntensity = newValue;
    }

}
