using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {


		// Use this for initialization
		void Start () {
			tp ();
		}

		// Update is called once per frame
		public void tp () {
			gameObject.transform.position = new Vector3 (5, 0.5f, 2.6f);
		}
	}