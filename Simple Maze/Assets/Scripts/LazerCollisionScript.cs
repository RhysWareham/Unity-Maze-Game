using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerCollisionScript : MonoBehaviour {

    public GameObject respawnLocation;


    //If an object has entered the collision area of a lazer...
    void OnTriggerEnter(Collider other)
    {
        //If the object's tag is not Player, ignore it
        if (other.gameObject.tag != "Player")
        {
            return;
        }
        //Call the RestPlayerPosition function
        ResetPlayerPosition(other);
    }

    //Function to reset the object's position
    public void ResetPlayerPosition(Collider other)
    {
        //Set the object's position to the position of respawnLocation
        other.gameObject.transform.position = respawnLocation.transform.position;
    }
}