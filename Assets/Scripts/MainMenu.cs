using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public String firstLevelScene;
    public GameObject optionsMenu, loadingScreen, loadingIcon;
    public GameObject canvas;
    public Text loadingText, loadedText;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        //SceneManager.LoadScene(firstLevelScene);
        StartCoroutine(LoadGame());
    }

    public void OpenOptions() {
        GameObject optionsMenuPrefab = Instantiate(optionsMenu, canvas.transform);
        optionsMenuPrefab.name = "Options Menu";
    }
    
    public void QuitGame() {
        Application.Quit();
    }


    public IEnumerator LoadGame()
    {

        loadingScreen.SetActive(true);


        // Load scene async
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(firstLevelScene);

        // Press button to continue
        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if (asyncLoad.progress >= .9f)
            {
                loadedText.text = "Press Any button to start";
                loadingText.text = "Loaded";
                loadingIcon.SetActive(false);
                if (Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;
                    Time.timeScale = 1f;
                }
            }
            yield return null;
        }
    }
}   


