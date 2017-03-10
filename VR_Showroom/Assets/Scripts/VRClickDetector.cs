using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRClickDetector : MonoBehaviour {

	public ClickDetector _furniture;
	public LayerMask myLayerMask;
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
		if (Physics.Raycast(transform.position, transform.forward * 10, out _hit, 20.0f, myLayerMask)) 
		{ 
			Debug.Log("Fired");
			_furniture = _hit.collider.gameObject.GetComponent<ClickDetector>();

			_furniture.GetComponent<ClickDetector> ().OnMouseDown();

		} 

	}
		
}