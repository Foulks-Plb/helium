﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{  
    private AudioSource audioSrc;    
    private float musicVolume = 1f;

    // Use this for initialization
    void Start()
    {      
        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {        
        audioSrc.volume = musicVolume;
    }

    
    public void SetVolume(float vol)
    {
        musicVolume = vol;
    }


    public void OpenWebsite(string url)
    {
        Application.OpenURL(url);
    }


}
