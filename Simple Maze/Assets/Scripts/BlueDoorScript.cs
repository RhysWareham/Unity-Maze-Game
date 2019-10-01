using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueDoorScript : MonoBehaviour {

    public GameObject blueDoorPivotObject;
    private bool doorOpen = false;
    private bool buttonPressed = false;
    private bool mouseOver = false;
    
	
	// Update is called once per frame
	void Update ()
    {
        //If buttonPressed is true...
		if (buttonPressed == true)
        {
            //activate either the opening or closing door animation depending on if doorOpen is true or false
            blueDoorPivotObject.GetComponent<Animator>().SetBool("doorIsOpen", doorOpen);
        }
	}

    //If the mouse is over the door, set mouseOver to true
    void OnMouseOver()
    {
        mouseOver = true;
    }

    //If the mouse is not over the door, set mouseOver to false
    void OnMouseExit()
    {
        mouseOver = false;
    }

    //If the mouse button has been clicked...
    void OnMouseDown()
    {
        //...set buttonPressed to true
        buttonPressed = true;
        //and doorOpen to the opposite of what it was
        doorOpen = !doorOpen;
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If mouseOver is true, and doorOpen is false...
        if (mouseOver == true && doorOpen == false)
        {
            //create a textbox which reads "Click Mouse To Open"
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Click Mouse To Open");
        }
        //If mouseOver is true, and doorOpen is true...
        else if (mouseOver == true && doorOpen == true)
        {
            //create a textbox which reads "Click Mouse To Close"
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Click Mouse To Close");
        }
    }
}
