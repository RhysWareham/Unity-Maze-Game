using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLockedDoorScript : MonoBehaviour {

    public GameObject door;
    public GameObject accessToKeyScript;
    public RedKeyScript script;
    private bool mouseOver = false;
    public bool keyPickedUp;
    private bool moveDoor = false;
    

    // Use this for initialization
    void Start ()
    {
        //Gives the variable script, access to variables from RedKeyScript
        script = accessToKeyScript.GetComponent<RedKeyScript>();
    }

    // Update is called once per frame
    void Update ()
    {
        //Sets keyPickedUp to the value of keyObtained from RedKeyScript
        keyPickedUp = script.keyObtained;

        //If moveDoor is true and the translation Y axis value for door is less than 60...
        if (moveDoor == true && door.GetComponent<Transform>().position.y < 60)
        {
            //...the door will slowly move upwards
            door.transform.Translate(Vector3.up * 5 * Time.deltaTime, Space.Self);
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
        //...check if keyPickedUp is true
        if (keyPickedUp == true)
        {
            //If so, set moveDoor to true
            moveDoor = true;
        }
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If mouseOver is true and keyPickedUp is false...
        if (mouseOver == true && keyPickedUp == false)
        {
            //...create a textbox which reads "Find The Red Key"
            GUI.Box(
                new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Find The Red Key");
        }
        //If mouseOver is true and keyPickedUp is true...
        else if (mouseOver == true && keyPickedUp == true)
        {
            //...create a textbox which reads "Click To Interact"
            GUI.Box(
                new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Click To Interact");
        }
    }
}
