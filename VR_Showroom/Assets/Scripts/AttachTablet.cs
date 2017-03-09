using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class AttachTablet : MonoBehaviour
{

    public GameObject Hand1;
	public GameObject Hand2;

	public bool leftHand;
	public bool rightHand;

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag.Equals("Hand1")) {
			transform.SetParent (Hand1.transform);
			leftHand = true;
            rightHand = false;
		} else if (other.gameObject.tag.Equals("Hand2")) {
			transform.SetParent(Hand2.transform);
			rightHand = true;
            leftHand = false;
		}
	
	}
}
