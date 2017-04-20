using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MatLibrary : MonoBehaviour {

    public ClickDetector[] clickDetectorScript;
	public GameObject activeObject;

    public Material[] kitchenWhites;
    public Material[] kitchenTiles;
    public Material[] couch1;
    public Material[] mainWalls;
    public Material[] mainFloor;
    public Material[] bathroomTilesWall;
    public Material[] bathroomTilesFloor;

    public RectTransform content;
    public RectTransform texturePF;
    RawImage image;
    Renderer material;

    GameObject[] changeableMaterial;
    public int i;

    // Use this for initialization
    void Start()
    {
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
            }	     
			else if (clickDetectorScript[i].clicked == true && clickDetectorScript[i].mainFloor == true)
			{
				DeleteCurrentMat();

				foreach (Material mat in mainFloor)
				{
					image.texture = mat.mainTexture;
					image.color = mat.color;
					material.material = mat;
					material.enabled = false;

					Instantiate(texturePF, content, false);
				}
			}	     
			else if (clickDetectorScript[i].clicked == true && clickDetectorScript[i].mainWalls == true)
			{
				DeleteCurrentMat();

				foreach (Material mat in mainWalls)
				{
					image.texture = mat.mainTexture;
					image.color = mat.color;
					material.material = mat;
					material.enabled = false;

					Instantiate(texturePF, content, false);
				}
			}
			else if (clickDetectorScript[i].clicked == true && clickDetectorScript[i].couch1 == true)
			{
				DeleteCurrentMat();

				foreach (Material mat in couch1)
				{
					image.texture = mat.mainTexture;
					image.color = mat.color;
					material.material = mat;
					material.enabled = false;

					Instantiate(texturePF, content, false);
				}
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
