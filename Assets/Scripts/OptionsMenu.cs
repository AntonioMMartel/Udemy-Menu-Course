using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject graphicsMenu;
    public GameObject soundsMenu;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    public void CloseMenu() {
        Destroy(optionsMenu);
    }

    public void OpenGraphicsMenu() {
        Instantiate(graphicsMenu, optionsMenu.transform);
    }

    public void OpenSoundsMenu() {
        Instantiate(soundsMenu, optionsMenu.transform);
    }
}
