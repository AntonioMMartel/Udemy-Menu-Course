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

    public AudioSource sfxLoop;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("MasterVolume")){
            masterSlider.value = PlayerPrefs.GetFloat("MasterVolume");
            audioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("MasterVolume"));   
        }

        if(PlayerPrefs.HasKey("MusicVolume")){
            musicSlider.value = PlayerPrefs.GetFloat("MusicVolume");
            audioMixer.SetFloat("MusicVolume", PlayerPrefs.GetFloat("MusicVolume"));
        }

        if(PlayerPrefs.HasKey("SFXVolume")){
            sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
            audioMixer.SetFloat("SFXVolume", PlayerPrefs.GetFloat("SFXVolume"));
        }
        sfxVolume.text = (sfxSlider.value + 80).ToString();
        masterVolume.text = (masterSlider.value + 80).ToString();
        musicVolume.text = (musicSlider.value + 80).ToString();
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

        PlayerPrefs.SetFloat("MasterVolume", masterSlider.value);
    }

    public void SetMusicVolume() {
        musicVolume.text = (musicSlider.value + 80).ToString();
        
        audioMixer.SetFloat("MusicVolume", musicSlider.value);

        PlayerPrefs.SetFloat("MusicVolume", musicSlider.value);
    }

    public void SetSfxVolume() {
        sfxVolume.text = (sfxSlider.value + 80).ToString();
        
        audioMixer.SetFloat("SFXVolume", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVolume", sfxSlider.value);
    }

    public void PlaySfxLoop() {
        sfxLoop.Play();
    }

    public void StopSfxLoop() {
        sfxLoop.Stop();
    }
}
