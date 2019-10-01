using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerHintScript : MonoBehaviour {

    private bool isColliding = false;


    //If an object is in the collision area of the respawnLocation...
    void OnTriggerEnter(Collider other)
    {
        //...set isColliding to true
        isColliding = true;
    }

    //If an object is not in the collision area of the respawnLocation...
    private void OnTriggerExit(Collider other)
    {
        //...set isColliding to false
        isColliding = false;
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If isColliding is true...
        if (isColliding == true)
        {
            //...create a textbox which reads "If You Touch A Lazer, You Will Respawn Here"
            GUI.Box(new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "If You Touch A Lazer, \nYou Will Respawn Here");
        }
    }
}
