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

    void start ()
    {
        Hand1 = GameObject.FindGameObjectWithTag("Hand1");
        Hand2 = GameObject.FindGameObjectWithTag("Hand2");
    }

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.tag.Equals("Hand1")) {
			transform.SetParent (Hand1.transform);

            Hand1 = Hand1;
            Hand2 = Hand2;
            
			leftHand = true;
            rightHand = false;
		} else if (other.gameObject.tag.Equals("Hand2")) {
			transform.SetParent(Hand2.transform);

            Hand2 = Hand1;
            Hand1 = Hand2;

            rightHand = true;
            leftHand = false;
		}
	
	}
}
