using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FrostweepGames.Plugins.Native;

[RequireComponent(typeof(AudioSource))]
public class MicRecorder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (var device in CustomMicrophone.devices)
        {
            print(device);
        }

        AudioSource micSource = GetComponent<AudioSource>();
        micSource.clip = CustomMicrophone.Start("MacBook Air Microphone", true, 10, 44100);
        micSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
