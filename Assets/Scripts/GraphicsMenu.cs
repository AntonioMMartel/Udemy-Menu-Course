using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GraphicsMenu : MonoBehaviour
{

    public GameObject graphicsMenu;
    public Toggle fullscreenToggle, vsyncToggle;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void applyChanges() {
        Screen.fullScreen = fullscreenToggle.isOn;

        if(vsyncToggle.isOn){
            QualitySettings.vSyncCount = 1;
        } else {
            QualitySettings.vSyncCount = 0;
        }
        
    }

    public void CloseMenu() {
        Destroy(graphicsMenu);
    }

}
