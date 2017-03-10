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

    void Update ()
    {
        Hand1 = GameObject.FindGameObjectWithTag("Hand1");
        Hand2 = GameObject.FindGameObjectWithTag("Hand2");
		gameObject.transform.SetParent(Hand1.transform);
    }

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag.Equals("Hand1")) {        
			leftHand = true;
            rightHand = false;
		} else if (other.gameObject.tag.Equals("Hand2")) {
            rightHand = true;
            leftHand = false;
		}
	
	}
}
