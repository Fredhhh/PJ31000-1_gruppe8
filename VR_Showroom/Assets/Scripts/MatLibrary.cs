using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatLibrary : MonoBehaviour {

    public ClickDetector[] clickDetectorScript;

    public Material[] kitchenWhites;
    public Material[] kitchenTiles;
    public Material[] couch;
    public Material[] mainWall;
    public Material[] mainFloor;
    public Material[] bathroomTilesWall;
    public Material[] bathroomTilesFloor;

    public RectTransform content;
    public RectTransform texturePF;
    Button button;
    RawImage image;
    Renderer material;

    GameObject[] changeableMaterial;
    public int i;

    // Use this for initialization
    void Start()
    {

        button = texturePF.GetComponent<Button>();
        image = texturePF.GetComponent<RawImage>();
        material = texturePF.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        changeableMaterial = GameObject.FindGameObjectsWithTag("ChangeableMaterial");


        for (i = 0; i < clickDetectorScript.Length; i++)
        {
            if (clickDetectorScript[i].clicked == true && clickDetectorScript[i].kitchenWhites == true)
            {
                DeleteCurrentMat();

                foreach (Material mat in kitchenWhites)
                {
                    image.texture = mat.mainTexture;
                    image.color = mat.color;
                    material.material = mat;
                    material.enabled = false;

                    Instantiate(texturePF, content, false);
                }
                clickDetectorScript[i].transform.tag = "ChangeableObject";
            }

            

            else if (clickDetectorScript[i].clicked == true && clickDetectorScript[i].kitchenTiles == true)
            {
                DeleteCurrentMat();

                foreach (Material mat in kitchenTiles)
                {
                    image.texture = mat.mainTexture;
                    image.color = mat.color;
                    material.material = mat;
                    material.enabled = false;

                    Instantiate(texturePF, content, false);
                }
                clickDetectorScript[i].transform.tag = "ChangeableObject";
            }

           
            clickDetectorScript[i].clicked = false;
            

        }
       

    }

    void DeleteCurrentMat()
    {
        foreach (GameObject obj in changeableMaterial)
        {
            Destroy(obj);
        }
    }
}
