using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

    public GameObject destination;
    public GameObject teleport;
    private bool mouseOver = false;


	// Use this for initialization
	void Start ()
    {
        //Finds the object TeleportExit and assigns it to destination
        destination = GameObject.Find("TeleportExit");
	}

    //If the mouse is over the teleport, set mouseOver to true
    void OnMouseOver()
    {
        mouseOver = true;
    }

    //If the mouse is not over the teleport, set mouseOver to false;
    void OnMouseExit()
    {
        mouseOver = false;
    }

    //If an object has entered the collision area of the teleport...
    void OnTriggerEnter(Collider other)
    {
        //If the object's tag is not Player, ignore it
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        //Call the DisableTeleport function
        //DisableTeleport();
        //Set the object's position to the position of destination
        other.gameObject.transform.position = destination.transform.position;
    }

    //Function to disable teleport
    public void DisableTeleport()
    {
        teleport.SetActive(false);
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If mouseOver is true...
        if (mouseOver == true)
        {
            //...create a textbox which reads "Walk Through The Teleport"
            GUI.Box(
                new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Walk Through The Teleport");
        }
    }
}