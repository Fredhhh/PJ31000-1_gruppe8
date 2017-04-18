using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DaylightControl : MonoBehaviour {

    public Slider daylightSlider;
    private float daylightSliderIntensity;


    // Use this for initialization
    void Awake () {

    }
	
	// Update is called once per frame
	void Update () {

        daylightSliderIntensity = daylightSlider.GetComponent<Slider>().value;

        float exposureValue = daylightSliderIntensity + 10;
        RenderSettings.skybox.SetFloat("_Exposure", 0 - (0.05f));

        Vector3 temp = transform.rotation.eulerAngles;
        temp.x = daylightSliderIntensity * -(10);
        transform.rotation = Quaternion.Euler(temp);
    }


}
