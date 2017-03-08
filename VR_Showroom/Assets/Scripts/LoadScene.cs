using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GameObject Hand1;
    public GameObject Hand2;

    public bool leftHand;
    public bool rightHand;

    // Use this for initialization
    void Start () {
		

	}


    // Update is called once per frame
    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag.Equals("Hand1"))
        {
            SceneManager.LoadScene("MainScene");
            leftHand = true;
        }
        else if (other.gameObject.tag.Equals("Hand2"))
        {
            SceneManager.LoadScene("MainScene");
            rightHand = true;
        }

        
       leftHand = true;
       rightHand = true;
    
    }
}
