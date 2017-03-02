using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class AttachTablet : MonoBehaviour
{

    public GameObject Hand;

    void Update()
    {
        transform.SetParent(Hand.transform);
        
    }

}
