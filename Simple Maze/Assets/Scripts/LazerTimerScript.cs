using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerTimerScript : MonoBehaviour {

    public GameObject lazerSet1;
    public GameObject lazerSet2;
    private bool active = true;
    private float timeLeft = 2.0f;


    // Update is called once per frame
    void Update()
    {
        //Decrease the value of timeLeft
        timeLeft -= Time.deltaTime;
        //If timeLeft is less than 0...
        if (timeLeft < 0)
        {
            //Set active to the opposite of what it was
            active = !active;
            //Disable or Enable the lazers depending on the value of active
            lazerSet1.SetActive(active);
            lazerSet2.SetActive(!active);
            //Set timeLeft to 2.0
            timeLeft = 2.0f;
        }
    }
}