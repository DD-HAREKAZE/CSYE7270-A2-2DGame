﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class audioManager : MonoBehaviour
{
    public Sound[] sounds;


    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds) 
        {
            s.source=gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    // Update is called once per frame
    public void Play(string name) 
    {
        Sound s=Array.Find(sounds, sound => sound.name == name);
        if (s == null) { Debug.Log("Sound Error when trying to play:" + name); return; }
        s.source.Play();
    }
}
