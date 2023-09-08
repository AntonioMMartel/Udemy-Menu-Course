using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject optionsMenu, canvas;
    public string mainMenuScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseUnpause() {

    }
    public void openOptions() {
        Instantiate(optionsMenu, canvas.transform);
    }

    public void mainMenu() {
        SceneManager.LoadScene(mainMenuScene);
    }

}
