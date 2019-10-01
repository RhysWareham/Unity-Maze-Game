using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuScript : MonoBehaviour {

    public GameObject settingsMenu;
    public GameObject mainMenu;
    public bool fullscreen = false;
    private Resolution[] resolutions; 

    [SerializeField]
    private Dropdown resolutionDropdown;

	// Use this for initialization
	void Start () {
        resolutions = Screen.resolutions;
        foreach (Resolution resolution in resolutions)
        {
            resolutionDropdown.options.Add(new Dropdown.OptionData(resolution.ToString()));
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnApplyButtonClick()
    {
        Screen.SetResolution(resolutions[resolutionDropdown.value].width, resolutions[resolutionDropdown.value].height, !fullscreen);
    }

    public void OnBackButtonClick()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
