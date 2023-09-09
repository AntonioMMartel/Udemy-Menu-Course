using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class GraphicsMenu : MonoBehaviour
{

    public GameObject graphicsMenu;
    public Toggle fullscreenToggle, vsyncToggle;

    public ResolutionItem[] resolutions;

    private int selectedResolution = 0;

    public Text resolutionLabel;

    // Start is called before the first frame update
    void Start()
    {
        fullscreenToggle.isOn = Screen.fullScreen;
        if(QualitySettings.vSyncCount == 0){
            vsyncToggle.isOn = false;
        } else {
            vsyncToggle.isOn = true;
        }
        
        bool foundRes = false;
        for(int i = 0; i <= resolutions.Length; i++){
            if(Screen.width == resolutions[i].horizontal && Screen.width == resolutions[i].vertical){
                foundRes = true;
                selectedResolution = i;
                updateResolutionLabel();
                
            }
        }

        if(!foundRes){
            resolutionLabel.text = Screen.width.ToString() + " x " + Screen.height.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextResolution() {
        if(selectedResolution >= resolutions.Length - 1){
            selectedResolution = 0;
        } else {
            selectedResolution++;
        }
        updateResolutionLabel();
    }



    public void previousResolution() {
        if(selectedResolution <= 0){
            selectedResolution = resolutions.Length - 1;
        } else {
            selectedResolution--;
        }
        updateResolutionLabel();
    }

    private void updateResolutionLabel() {
        resolutionLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();
    }


    public void applyChanges() {
        //Screen.fullScreen = fullscreenToggle.isOn;

        if(vsyncToggle.isOn){
            QualitySettings.vSyncCount = 1;
        } else {
            QualitySettings.vSyncCount = 0;
        }
        
        // setResolution
        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenToggle.isOn);

    }

    public void CloseMenu() {
        Destroy(graphicsMenu);
    }

    [System.Serializable] public class ResolutionItem {
        public int horizontal, vertical;
    }
}
