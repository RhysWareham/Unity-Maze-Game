using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextRenderScript : MonoBehaviour {

    public GameObject textObject;
    private bool isCollide = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        isCollide = true;
        RenderText();
    }

    private void OnTriggerExit(Collider other)
    {
        isCollide = false;
        RenderText();
    }

    void RenderText()
    {
        textObject.SetActive(isCollide);
    }
}
