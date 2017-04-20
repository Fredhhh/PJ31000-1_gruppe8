using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {


    // Use this for initialization
    void Start () {
		

	}


    // Update is called once per frame
    void OnTriggerEnter(Collider other) {

        if (other.gameObject.tag.Equals("Player"))
        {
            SceneManager.LoadScene("MainScene");
           
        }
    
    }
}
