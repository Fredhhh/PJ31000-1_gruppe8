using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpScript : MonoBehaviour {

	public GameObject player;

    public void Kitchen ()
    {  
        player.transform.position = GameObject.Find("KitchenSP").transform.position;
    }
    public void LivingRoom ()
    {
        player.transform.position = GameObject.Find("LivingroomSP").transform.position;
    }
    public void Bedroom1 ()
    {
        player.transform.position = GameObject.Find("Bedroom1SP").transform.position;
    }
    public void Bedroom2()
    {
        player.transform.position = GameObject.Find("Bedroom2SP").transform.position;
    }
    public void Bedroom3()
    {
        player.transform.position = GameObject.Find("Bedroom3SP").transform.position;
    }
    public void Office()
    {
        player.transform.position = GameObject.Find("OfficeSP").transform.position;
    }
    public void Washroom()
    {
        player.transform.position = GameObject.Find("WashroomSP").transform.position;
    }
    public void Balcony1()
    {
        player.transform.position = GameObject.Find("Balcony1SP").transform.position;
    }
    public void Balcony2()
    {
        player.transform.position = GameObject.Find("Balcony2SP").transform.position;
    }
    public void Entre()
    {
        player.transform.position = GameObject.Find("EntreSP").transform.position;
    }
    public void Hallway1()
    {
        player.transform.position = GameObject.Find("Hallway1SP").transform.position;
    }
    public void Hallway2()
    {
        player.transform.position = GameObject.Find("Hallway2SP").transform.position;
    }
    public void Bathroom1()
    {
        player.transform.position = GameObject.Find("Bathroom1SP").transform.position;
    }
    public void Bathroom2()
    {
        player.transform.position = GameObject.Find("Bathroom2SP").transform.position;
    }
}
