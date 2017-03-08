using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRClickDetector : MonoBehaviour {
	private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
	public bool triggerButtonDown = false;
	public bool triggerButtonUp = false;
	public bool triggerButtonPressed = false;

	private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }
	private SteamVR_TrackedObject trackedObj;

	// Use this for initialization
	void Start()
	{
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	// Update is called once per frame
	void Update()
	{
		if (controller == null)
		{
			Debug.Log("Controller not initialized");
			return;
		}

		triggerButtonDown = controller.GetPressDown(triggerButton);

		if (triggerButtonDown)
		{
			Debug.Log("Trigger Button Down");
			//here is where the function callout would be
		}
	}

}