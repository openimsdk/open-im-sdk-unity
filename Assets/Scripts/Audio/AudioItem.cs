﻿using UnityEngine;

[System.Serializable]
public class AudioItem
{

    public string name;
    public float volume = 1f;
    public bool loop;
    public AudioClip[] clip;
}
