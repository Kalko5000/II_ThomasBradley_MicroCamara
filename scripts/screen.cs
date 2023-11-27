using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.WebCam;

public class screen : MonoBehaviour
{
    public int captureCounter = 1;
    
    private Material screenMaterial;
    private WebCamTexture webcam;
    private string saveTo;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(WebCamTexture.devices[0].name); // Nombre por consola
        webcam = new WebCamTexture();
        screenMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("s")) {
            screenMaterial.mainTexture = webcam;
            webcam.Play();
        }
        if(Input.GetKey("p")) {
            webcam.Stop();
            screenMaterial.mainTexture = null;
        }
        if(Input.GetKey("x")) {
            // Falta por implementar
        }
    }
}
