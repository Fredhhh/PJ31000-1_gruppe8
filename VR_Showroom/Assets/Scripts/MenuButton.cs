using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Texture2D[] boliger;
    public RawImage boligRamme;
    int i;

    // Use this for initialization1
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void boligChange()
    {
        for (i = 0; i < boliger.Length; i++)
        {
            boligRamme.GetComponent<RawImage>().texture = boliger[i];
        }
    }

}
