using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject settingsMenu;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnPlayButtonClick()
    {
        SceneManager.LoadScene("GameLevel");
    }

    public void OnOptionsButtonClick()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
