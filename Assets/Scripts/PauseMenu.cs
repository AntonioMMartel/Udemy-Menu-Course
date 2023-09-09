using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject optionsMenu, canvas, pauseMenu;
    public string mainMenuScene;

    bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!GameObject.Find("Options Menu")) 
            if (Input.GetKeyDown(KeyCode.Escape)) 
                PauseUnpause();
    }

    public void PauseUnpause() {
        
            if(!isPaused) {
                pauseMenu.SetActive(true);
                isPaused = true;
                Time.timeScale = 0;
            } else {
                pauseMenu.SetActive(false);
                isPaused = false;
                Time.timeScale = 1;

            }
    }
    public void openOptions() {
        GameObject openedOptionsMenu = Instantiate(optionsMenu, canvas.transform);
        openedOptionsMenu.name = "Options Menu";


    }

    public void mainMenu() {
        SceneManager.LoadScene(mainMenuScene);
    }

}
