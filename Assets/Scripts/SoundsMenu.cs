using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsMenu : MonoBehaviour
{
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
        Destroy(soundsMenu);
    }
}