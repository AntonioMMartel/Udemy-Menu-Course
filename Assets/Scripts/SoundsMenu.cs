using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundsMenu : MonoBehaviour
{
    public GameObject soundsMenu;

    public AudioMixer audioMixer;

    public Slider masterSlider, musicSlider, sfxSlider;

    public Text masterVolume, musicVolume, sfxVolume;

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

    public void SetMasterVolume() {
        masterVolume.text = (masterSlider.value + 80).ToString();

        audioMixer.SetFloat("MasterVolume", masterSlider.value);
    }

    public void SetMusicVolume() {
        musicVolume.text = (musicSlider.value + 80).ToString();
        
        audioMixer.SetFloat("MusicVolume", musicSlider.value);
    }

    public void SetSfxVolume() {
        sfxVolume.text = (sfxSlider.value + 80).ToString();
        
        audioMixer.SetFloat("SFXVolume", sfxSlider.value);
    }
}
