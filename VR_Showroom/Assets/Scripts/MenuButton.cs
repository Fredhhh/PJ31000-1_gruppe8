using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public Texture2D[] boliger;
    public RawImage boligRamme;
    public int i;

    // Use this for initialization1
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (i + 1 > boliger.Length)
        {
            i = boliger.Length - 1;
        } else if(i < 0)
        {
            i = 0;
        }

        boligRamme.GetComponent<RawImage>().texture = boliger[i];
    }

    public void boligChange()
    {
            if (i +1 < boliger.Length)
            {
            i++;
            }
    }
    public void boligBack()
    {
            if (i > 0)
            {  
            i--;
            }
    }

}
