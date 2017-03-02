using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickExample : MonoBehaviour
{
    public Button yourButton;
    public Canvas[] boligSlides;
    void Start()
    {
        /*Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);*/
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
