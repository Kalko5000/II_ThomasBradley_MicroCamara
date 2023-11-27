using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour
{
    private AudioSource soundSource;

    // Start is called before the first frame update
    void Start()
    {
        soundSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other) { // Cambio por OnTrigger para que funcione al saltar encima de
        if(other.gameObject.tag == "Spider") {
            soundSource.Play(0);
        }
    }
}
