using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRClickDetector : MonoBehaviour {

	public ClickDetector _furniture;
	public Lightswitcher _lightSwitch;
	public LayerMask myLayerMask1;
	public LayerMask myLayerMask2;
	SteamVR_TrackedController controller;

	// Use this for initialization
	void Start()
	{
		controller = GetComponent<SteamVR_TrackedController> ();
		if (controller == null) 
		{
			controller = gameObject.AddComponent<SteamVR_TrackedController> ();
		}
		controller.TriggerClicked += new ClickedEventHandler (Select);
	}

	// Update is called once per frame
	void Update()
	{
	}

	// Fire when trigger on controller clicks 
	void Select(object sender, ClickedEventArgs e) 
	{  
		RaycastHit _hit; 
		if (Physics.Raycast(transform.position, transform.forward * 10, out _hit, 20.0f, myLayerMask2))
		{
			_lightSwitch = _hit.collider.gameObject.GetComponent<Lightswitcher>();
			_lightSwitch.GetComponent<Lightswitcher>().OnMouseDown();

		}

		else if (Physics.Raycast(transform.position, transform.forward * 10, out _hit, 20.0f, myLayerMask1)) 
		{ 
			_furniture = _hit.collider.gameObject.GetComponent<ClickDetector>();
			_furniture.GetComponent<ClickDetector>().OnMouseDown();
		} 

	}
		
}