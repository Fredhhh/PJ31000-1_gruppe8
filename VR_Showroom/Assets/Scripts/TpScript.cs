using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpScript : MonoBehaviour {

    public void Kitchen ()
    {  
        gameObject.transform.position = GameObject.Find("KitchenSP").transform.position;
    }
    public void LivingRoom ()
    {
        gameObject.transform.position = GameObject.Find("LivingroomSP").transform.position;
    }
    public void Bedroom1 ()
    {
        gameObject.transform.position = GameObject.Find("Bedroom1SP").transform.position;
    }
    public void Bedroom2()
    {
        gameObject.transform.position = GameObject.Find("Bedroom2SP").transform.position;
    }
    public void Bedroom3()
    {
        gameObject.transform.position = GameObject.Find("Bedroom3SP").transform.position;
    }
    public void Office()
    {
        gameObject.transform.position = GameObject.Find("OfficeSP").transform.position;
    }
    public void Washroom()
    {
        gameObject.transform.position = GameObject.Find("WashroomSP").transform.position;
    }
    public void Balcony1()
    {
        gameObject.transform.position = GameObject.Find("Balcony1SP").transform.position;
    }
    public void Balcony2()
    {
        gameObject.transform.position = GameObject.Find("Balcony2SP").transform.position;
    }
    public void Entre()
    {
        gameObject.transform.position = GameObject.Find("EntreSP").transform.position;
    }
    public void Hallway1()
    {
        gameObject.transform.position = GameObject.Find("Hallway1SP").transform.position;
    }
    public void Hallway2()
    {
        gameObject.transform.position = GameObject.Find("Hallway2SP").transform.position;
    }
    public void Bathroom1()
    {
        gameObject.transform.position = GameObject.Find("Bathroom1SP").transform.position;
    }
    public void Bathroom2()
    {
        gameObject.transform.position = GameObject.Find("Bathroom2SP").transform.position;
    }
}
