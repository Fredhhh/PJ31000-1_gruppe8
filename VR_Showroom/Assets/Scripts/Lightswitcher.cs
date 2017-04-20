using UnityEngine;
using System.Collections;

public class Lightswitcher : MonoBehaviour
{


	public GameObject[] lights;
    //public GameObject light;
    //public GameObject light2;
 

    public bool on;

    // Use this for initialization
    void Start()
    {


        on = true;
		foreach (GameObject light in lights) {
			light.GetComponent<Light>().enabled = true;
		}
        //light.GetComponent<Light>().enabled = true;
        //light2.GetComponent<Light>().enabled = true;


    }

    // Update is called once per frame
    void Update()
    {



    }

    public void OnMouseDown()
    {
		Debug.Log ("test");
        if (on == true)
        {
            on = false;

			foreach (GameObject light in lights) {
				light.GetComponent<Light>().enabled = false;
			}
            //light.GetComponent<Light>().enabled = false;
            //light2.GetComponent<Light>().enabled = false;


        }

        else if (on == false)
        {
            on = true;

			foreach (GameObject light in lights) {
				light.GetComponent<Light>().enabled = true;
			}
            //light.GetComponent<Light>().enabled = true;
            //light2.GetComponent<Light>().enabled = true;

        }
    }
}