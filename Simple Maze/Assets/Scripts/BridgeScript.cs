using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeScript : MonoBehaviour {

    public Camera firstPersonCamera;
    public Camera bridgeCamera;
    public GameObject bridgePivotObject;
    public GameObject buttonObject;
    private bool buttonPressed = false;
    private bool mouseOver = false;


    // Update is called once per frame
    void Update()
    {
        //If buttonPressed is true and the rotation Z axis value for bridgePivotObject is more than 0...
        if (buttonPressed == true && bridgePivotObject.GetComponent<Transform>().rotation.z > 0)
        {
            //...call the ShowBridgeView function
            ShowBridgeView();
            //and rotate the bridgePivotObject on its Z axis anticlockwise slowly
            bridgePivotObject.transform.Rotate(Vector3.back * 5 * Time.deltaTime, Space.Self);
        }
        //If the rotation Z axis value for bridgePivotObject is less than 0...
        else if (bridgePivotObject.GetComponent<Transform>().rotation.z < 0)
        {
            //the object will stop rotating and will call the ShowFirstPerson function
            ShowFirstPersonView();
        }
    }

    //If the mouse is over the button, set mouseOver to true
    void OnMouseOver()
    {
        mouseOver = true;
    }

    //If the mouse is not over the button, set mouseOver to false
    void OnMouseExit()
    {
        mouseOver = false;
    }

    //If the mouse button has been clicked...
    void OnMouseDown()
    {
        //...set buttonPressed to true
        buttonPressed = true;
        //and move the button 1.7 units in the X axis
        buttonObject.transform.Translate(0.0f, 1.7f, 0.0f);
    }

    //Function for pop up text hints
    void OnGUI()
    {
        //If mouseOver is true, and the rotation Z axis value for bridgePivotObject is more than 0...
        if (mouseOver == true && bridgePivotObject.GetComponent<Transform>().rotation.z > 0)
        {
            //...create a textbox which reads "Press Mouse To Interact"
            GUI.Box(
                new Rect(Screen.width / 2 - 100, Screen.height / 2 - 25, 200, 50), "Click Mouse To Interact" );
        }
    }

    //Function to change from firstPersonCamera to bridgeCamera
    public void ShowBridgeView()
    {
        //Disables firstPersonCamera
        firstPersonCamera.enabled = false;
        //Enables bridgeCamera
        bridgeCamera.enabled = true;
    }

    //Function to change from bridgeCamera to firstPersonCamera
    public void ShowFirstPersonView()
    {
        //Enables firstPersonCamera
        firstPersonCamera.enabled = true;
        //Disables bridgeCamera
        bridgeCamera.enabled = false;
    }
}