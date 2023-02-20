using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour
{
    private AudioSource sound;

    public void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public void PlayCrashSound()
    {
        sound.Play();
    }
}
