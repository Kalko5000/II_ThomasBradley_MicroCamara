using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recorder : MonoBehaviour
{
    private AudioSource sound;
    private bool start = false;
    
    // Start is called before the first frame update
    void Start()
    {        
        Debug.Log("Beggining Recording...");
        sound = GetComponent<AudioSource>();
        sound.clip = Microphone.Start(Microphone.devices[0], false, 7, 44100);
    }

    // Update is called once per frame
    void Update()
    {
        // Captura 7 segundos de audio
        if(Input.GetKeyDown(KeyCode.R) && Microphone.IsRecording(null) && start == false) {
            Debug.Log("Commencing Playback");
            sound.Play();
            start = true;
        } else if (Input.GetKeyDown(KeyCode.R)) {
            Debug.Log("Beggining Recording...");
            Microphone.End(Microphone.devices[0]);
            sound.clip = Microphone.Start(Microphone.devices[0], false, 7, 44100);
            start = false;
        }
        
    }
}
