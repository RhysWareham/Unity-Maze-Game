using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeKeyScript : MonoBehaviour
{

    public GameObject key;
    public bool keyObtained = false;
    private bool mouseOver = false;


    //If the mouse is over the key, set mouseOver to true
    void OnMouseOver()
    {
        mouseOver = true;
    }

    //If the mouse is not over the key, set mouseOver to false
    void OnMouseExit()
    {
        mouseOver = false;
    }

    //If the mouse button has been clicked...
    public void OnMouseDown()
    {
        //...set keyObtained to true
        keyObtained = true;
        //and call the DisableKey function
        DisableKey();
    }

    //Function to disable key
    public void DisableKey()
    {
        key.SetActive(false);
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If mouseOver is true and keyObtained is false...
        if (mouseOver == true && keyObtained == false)
        {
            //...create a textbox which reads "Click To Take Key"
            GUI.Box(
                new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Click To Take Key");
        }
    }
}