using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishTextRenderScript : MonoBehaviour
{

    public GameObject textObject;
    public GameObject textObject1;
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

    void RenderText()
    {
        if (isCollide == true)
        {
            textObject1.SetActive(false);
            textObject.SetActive(true);
        }
    }
}