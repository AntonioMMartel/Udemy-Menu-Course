using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject optionsMenu, canvas, pauseMenu, loadingScreen, loadingIcon;
    public string mainMenuScene;
    public Text loadedText, loadingText;


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
        //SceneManager.LoadScene(mainMenuScene);

        StartCoroutine(LoadMain());
    }

    public IEnumerator LoadMain()
    {

        loadingScreen.SetActive(true);
        pauseMenu.SetActive(false);


        // Load scene async
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(mainMenuScene);

        // Press button to continue
        asyncLoad.allowSceneActivation = false;

        while(!asyncLoad.isDone)
        {
            if(asyncLoad.progress >= .9f)
            {
                loadedText.text = "Press Any button to start";
                loadingText.text = "Loaded";
                loadingIcon.SetActive(false);
                if(Input.anyKeyDown)
                {
                    asyncLoad.allowSceneActivation = true;
                    Time.timeScale = 1f;
                }
            }
            yield return null;
        }
    }

}
