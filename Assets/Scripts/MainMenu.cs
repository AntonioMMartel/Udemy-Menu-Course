using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public String firstLevelScene;
    public GameObject optionsMenu;
    public GameObject canvas;

    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(firstLevelScene);
    }

    public void OpenOptions() {
        GameObject optionsMenuPrefab = Instantiate(optionsMenu, canvas.transform);
        optionsMenuPrefab.name = "Options Menu";
    }
    
    public void QuitGame() {
        Application.Quit();
    }

}   


